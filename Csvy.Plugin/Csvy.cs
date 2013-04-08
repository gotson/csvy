using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using IniFiles;
using LaunchySharp;
using Csvy.Plugin.Helpers;
using Csvy.Plugin.UI;
using Csvy.Plugin.Referential;
using LumenWorks.Framework.IO.Csv;

namespace Csvy.Plugin
{
    public class Csvy : IPlugin
    {
        private string pluginName;
        private string pluginVersion;

        private IPluginHost pluginHost;
        private ICatItemFactory catItemFactory;
        private uint pluginHash;
        private OptionsWidget optionDialog;

        private ILaunchyPaths launchyPaths;
        private ConfigurationManager launchyIni;

        private List<ReferentialManager> referentials = new List<ReferentialManager>();

        #region IPlugin Implementation
        public void init(IPluginHost pluginHost)
        {
            // get Assembly information
            pluginName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            pluginVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

            // Launchy# stuff
            this.pluginHost = pluginHost;
            if (this.pluginHost == null)
            {
                return;
            }
            catItemFactory = this.pluginHost.catItemFactory();
            pluginHash = this.pluginHost.hash(pluginName);

            // Configuration manager (INI file)
            launchyPaths = this.pluginHost.launchyPaths();
            launchyIni = new ConfigurationManager(launchyPaths.getConfigPath() + Path.AltDirectorySeparatorChar + global::Csvy.Plugin.Properties.Resources.LAUNCHY_INI_FILE);

            // load referentials at runtime only. Catch exceptions in case the base64 string is broken
            try
            {
                referentials = SerializationHelper.DeserializeFromXMLString<List<ReferentialManager>>(SerializationHelper.Decode64(launchyIni.getValue(pluginName, global::Csvy.Plugin.Properties.Resources.CSVY_REFERENTIALS))) as List<ReferentialManager>;
            }
            catch (Exception)
            {
                referentials = new List<ReferentialManager>();
            }

            optionDialog = new OptionsWidget(this);
            optionDialog.PluginName = pluginName;
            optionDialog.PluginVersion = pluginVersion;
        }

        public uint getID()
        {
            return pluginHost.hash(pluginName); ;
        }

        public string getName()
        {
            return pluginName;
        }

        public void getLabels(List<IInputData> inputDataList)
        {
            if (inputDataList.Count != 2)
            {
                return;
            }

            string lowerText = inputDataList[0].getText().ToLower();
            foreach (var r in referentials)
            {
                if (lowerText.CompareTo(r.TriggerWord.ToLower()) == 0)
                {
                    inputDataList[0].setLabel(pluginHash);
                }
            }
        }

        public void getResults(List<IInputData> inputDataList, List<ICatItem> resultsList)
        {
            if (!inputDataList[0].hasLabel(pluginHash))
            {
                return;
            }

            // case when the user typed 1 <TAB>:
            // list all the elements of the referentials matching the trigger word and the input
            if (inputDataList.Count == 2)
            {
                string entry = inputDataList[1].getText().ToLower();
                ICatItem trigger = inputDataList[0].getTopResult();

                foreach (var r in referentials)
                {
                    // add items only if the trigger word is the same as the one in the referential
                    if (trigger.getShortName() == r.TriggerWord)
                    {
                        foreach (DataRow row in r.CsvHandler.Rows)
                        {
                            string s = SearchHelper.ReplaceMaskWithItem(r.DisplayMask, row);
                            // try to use Referential.ItemIconPath
                            string iconPath = SearchHelper.ReplaceMaskWithItem(r.ItemIconPath, row);
                            // else, try to use Referential.IconPath
                            if (string.IsNullOrEmpty(iconPath))
                                iconPath = r.IconPath;
                            // else, use the plugin icon
                            if (string.IsNullOrEmpty(iconPath))
                                iconPath = getPluginIcon();
                            if (SearchHelper.ContainsAnywhere(s.ToLower(), entry))
                            {
                                ICatItem result = catItemFactory.createCatItem(
                                            FullPathHelper.BuildFullPath(r.GetHashCode().ToString(), row[r.CsvHandler.PrimaryKey].ToString()),
                                            s,
                                            pluginHash,
                                            iconPath
                                );
                                resultsList.Add(result);
                            }
                        }
                    }
                }
            }
            // case when the user typed 2 <TAB>:
            // list all the actions of the chose item
            else if (inputDataList.Count == 3)
            {
                string catItemFullPath = inputDataList[1].getTopResult().getFullPath();

                int refHashCode = 0;
                int.TryParse(FullPathHelper.ParseFullPath(catItemFullPath, FullPathHelper.FullPathElement.Referential), out refHashCode);
                string itemFullPath = FullPathHelper.ParseFullPath(catItemFullPath, FullPathHelper.FullPathElement.Item);

                foreach (var r in referentials)
                {
                    if (refHashCode == r.GetHashCode())
                    {
                        DataRow target = r.CsvHandler[itemFullPath];
                        ICatItem result;
                        foreach (var a in r.Actions)
                        {
                            // do not display the action if the condition is not fulfilled
                            if (string.IsNullOrEmpty(a.Condition)
                                || !string.IsNullOrEmpty(SearchHelper.ReplaceMaskWithItem(a.Condition, target)))
                            {
                                // try to use Action.IconPath
                                string iconPath = SearchHelper.ReplaceMaskWithItem(a.IconPath, target);
                                // else, try to use Referential.ItemIconPath
                                if (string.IsNullOrEmpty(iconPath))
                                    iconPath = SearchHelper.ReplaceMaskWithItem(r.ItemIconPath, target);
                                // else, try to use Referential.IconPath
                                if (string.IsNullOrEmpty(iconPath))
                                    iconPath = r.IconPath;
                                // else, use the plugin icon
                                if (string.IsNullOrEmpty(iconPath))
                                    iconPath = getPluginIcon();
                                result = catItemFactory.createCatItem(
                                                FullPathHelper.BuildFullPath(refHashCode.ToString(), itemFullPath, a.GetHashCode().ToString()),
                                                SearchHelper.ReplaceMaskWithItem(a.DisplayName, target),
                                                pluginHash,
                                                string.IsNullOrEmpty(iconPath) ? getPluginIcon() : iconPath
                                );
                                resultsList.Add(result);
                            }
                        }
                    }
                }
            }
        }

        public void getCatalog(List<ICatItem> catalogItems)
        {
            foreach (var r in referentials)
            {
                catalogItems.Add(catItemFactory.createCatItem(
                    pluginName,
                    r.TriggerWord,
                    pluginHash,
                    string.IsNullOrEmpty(r.IconPath) ? getPluginIcon() : r.IconPath
                ));
                r.CsvHandler.Refresh();
            }
        }

        public void launchItem(List<IInputData> inputDataList, ICatItem it)
        {
            ICatItem catItem = inputDataList[inputDataList.Count - 1].getTopResult();
            string catItemFullPath = catItem.getFullPath();

            int refHashCode = 0;
            int.TryParse(FullPathHelper.ParseFullPath(catItemFullPath, FullPathHelper.FullPathElement.Referential), out refHashCode);
            string itemFullPath = FullPathHelper.ParseFullPath(catItemFullPath, FullPathHelper.FullPathElement.Item);
            int actionHashCode = 0;
            int.TryParse(FullPathHelper.ParseFullPath(catItemFullPath, FullPathHelper.FullPathElement.Action), out actionHashCode);

            try
            {
                foreach (var r in referentials)
                {
                    if (refHashCode == r.GetHashCode())
                    {
                        // find item
                        DataRow target = r.CsvHandler[itemFullPath];

                        // try to find an appropriate Action, given the ActionInstance
                        ActionInstance a = r.Actions.Find(delegate(ActionInstance act) { return act.GetHashCode() == actionHashCode; });
                        // if no action is found, try to find a default action
                        if (a == null)
                        {
                            a = r.Actions.Find(delegate(ActionInstance act) { return act.Default == true; });
                        }
                        // if an action is found, trigger it
                        if (a != null)
                        {
                            // split arguments using CSV Parser
                            string[] args = CsvHelper.CsvStringToArray(a.Arguments);
                            // replace mask for each argument
                            for (int i = 0; i < args.Length; i++)
                            {
                                args[i] = SearchHelper.ReplaceMaskWithItem(args[i], target);
                            }
                            // trigger action
                            ActionHelper.GetAvailableActions()[a.ActionType].Trigger(args);
                        }
                    }
                }
            }
            catch (Exception) { }
        }

        public bool hasDialog()
        {
            return true;
        }

        public IntPtr doDialog()
        {
            LoadConfiguration();

            optionDialog.Show();
            return optionDialog.Handle;
        }

        public void endDialog(bool acceptedByUser)
        {
            if (acceptedByUser)
            {
                ApplyConfiguration();
            }
        }

        public void launchyShow() { }

        public void launchyHide() { }
        #endregion

        #region Functions
        public string getPluginIcon()
        {
            return launchyPaths.getIconsPath() + System.IO.Path.DirectorySeparatorChar + pluginName + ".ico"; ;
        }

        private void LoadConfiguration()
        {
            // load runtime referentials
            optionDialog.Referentials = referentials;
        }

        public void ApplyConfiguration()
        {
            // save referentials to runtime + file
            referentials = optionDialog.Referentials;
            launchyIni.setValue(pluginName, global::Csvy.Plugin.Properties.Resources.CSVY_REFERENTIALS, SerializationHelper.Encode64(SerializationHelper.SerializeToXMLString<List<ReferentialManager>>(referentials)));
        }
        #endregion

        #region Properties
        public ConfigurationManager ConfigurationManager
        {
            get { return launchyIni; }
        }
        #endregion
    }
}

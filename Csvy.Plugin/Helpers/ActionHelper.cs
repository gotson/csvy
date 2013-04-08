using System;
using System.Collections.Generic;
using System.Reflection;
using Csvy.Action.Interface;

namespace Csvy.Plugin.Helpers
{
    public static class ActionHelper
    {
        private static Dictionary<String, ActionBase> actions = null;

        /// <summary>
        /// Uses reflection to retrieve all the classes implementing Action
        /// </summary>
        /// <returns>A dictionnary containing all available actions, where the key is the Action DisplayName</returns>
        public static Dictionary<String, ActionBase> GetAvailableActions()
        {
            if (actions == null)
            {
                var type = typeof(ActionBase);
                actions = new Dictionary<String, ActionBase>();
                try
                {
                    foreach (Assembly asm in AppDomain.CurrentDomain.GetAssemblies())
                        foreach (Type t in asm.GetTypes())
                            try
                            {
                                if (type.IsAssignableFrom(t) && t != type)
                                {
                                    ActionBase a = t.InvokeMember("Ctor", System.Reflection.BindingFlags.CreateInstance, null, t, new object[0]) as ActionBase;
                                    actions.Add(a.DisplayName,a);
                                }
                            }
                            catch (Exception e) { System.Windows.Forms.MessageBox.Show(e.Message); }
                }
                catch (Exception) { }
            }
            return actions;
        }
    }
}

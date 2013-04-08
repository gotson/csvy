using System;
using System.Diagnostics;
using System.IO;
using Csvy.Action.Interface;
using Microsoft.Win32;

namespace Csvy.Action.Implementation.Mstsc
{
    /// <summary>
    /// Mstsc opens a remote connection using mstsc.exe
    /// </summary>
    public sealed class ActionMstsc : ActionBase
    {
        #region Action implementation
        public override int ArgumentsNumber
        {
            get
            {
                return 3;
            }
        }

        public override string DisplayName
        {
            get
            {
                return "Mstsc";
            }
        }

        public override string Description
        {
            get
            {
                return @"Opens a remote connection to the specified server.

Expected number of arguments: 3
1: server address
2: user domain
3: username";
            }
        }

        protected override void Do(string[] args)
        {
            try
            {
                // create rdp file
                string template = global::Csvy.Action.Implementation.Mstsc.Properties.Resources.RdpTemplate; ;
                string targetPath = Path.Combine(Path.GetTempPath(), args[0] + ".rdp");
                using (var sw = new StreamWriter(targetPath))
                {
                    template = template.Replace(global::Csvy.Action.Implementation.Mstsc.Properties.Resources.MSTSC_SERVER_TOKEN, args[0]);
                    template = template.Replace(global::Csvy.Action.Implementation.Mstsc.Properties.Resources.MSTSC_USER_TOKEN, args[2]);
                    template = template.Replace(global::Csvy.Action.Implementation.Mstsc.Properties.Resources.MSTSC_DOMAIN_TOKEN, args[1]);
                    sw.Write(template);
                }

                // add server name in the registry to avoid Mstsc warning
                RegistryKey key = Registry.CurrentUser.OpenSubKey(global::Csvy.Action.Implementation.Mstsc.Properties.Resources.MSTSC_REG_KEY, true);
                if (key == null)
                {
                    key = Registry.CurrentUser.CreateSubKey(global::Csvy.Action.Implementation.Mstsc.Properties.Resources.MSTSC_REG_KEY, RegistryKeyPermissionCheck.ReadWriteSubTree);
                }
                key.SetValue(args[0], global::Csvy.Action.Implementation.Mstsc.Properties.Resources.MSTSC_REG_DEFAULT_VALUE, RegistryValueKind.DWord);

                // launch process
                Process.Start(global::Csvy.Action.Implementation.Mstsc.Properties.Resources.MSTSC_BINARY, targetPath);
            }
            catch (Exception) { }
        }
        #endregion
    }
}

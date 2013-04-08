using System;
using System.Collections.Generic;
using System.Text;
using Csvy.Action.Interface;

namespace Csvy.Action.Implementation.Clipboard
{
    public sealed class ActionClipboard : ActionBase
    {
        #region Action implementation
        public override int ArgumentsNumber
        {
            get { return 1; }
        }

        public override string DisplayName
        {
            get { return "Clipboard"; }
        }

        public override string Description
        {
            get
            {
                return @"Copy the given string in the clipboard.

Expected number of arguments: 1
1: string to copy";
            }
        }

        protected override void Do(string[] args)
        {
            try
            {
                System.Windows.Forms.Clipboard.SetText(args[0]);
            }
            catch (Exception) { }
        }
        #endregion
    }
}

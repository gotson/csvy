using System;
using System.Diagnostics;
using Csvy.Action.Interface;

namespace Csvy.Action.Implementation.Command
{
    /// <summary>
    /// Explorer can open explorer.exe on any given path
    /// </summary>
    public sealed class ActionCommand : ActionBase
    {
        #region Action implementation
        public override int ArgumentsNumber
        {
            get { return 2; }
        }

        public override string DisplayName
        {
            get { return "Command"; }
        }

        public override string Description
        {
            get
            {
                return @"Launch the given command with the given argument.

Expected number of arguments: 1
1: command to launch
2: argument to pass to the command";
            }
        }

        protected override void Do(string[] args)
        {
            try
            {
                var runCommand = new ProcessStartInfo(args[0], args[1]);
                Process.Start(runCommand);
            }
            catch (Exception) { }
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csvy.Action.Interface
{
    /// <summary>
    /// Base class to implement new Actions
    /// </summary>
    public abstract class ActionBase
    {
        #region To implement
        /// <summary>
        /// Number of arguments required by the Action
        /// </summary>
        public abstract int ArgumentsNumber { get; }

        /// <summary>
        /// Display Name of the Action
        /// </summary>
        public abstract string DisplayName { get; }

        /// <summary>
        /// Description of the Action
        /// </summary>
        public abstract string Description { get; }

        /// <summary>
        /// Code that will be executed when the Action is triggered
        /// </summary>
        /// <param name="args">An array containing the arguments passed to the Action</param>
        protected abstract void Do(string[] args);
        #endregion

        #region Base methods
        /// <summary>
        /// Base class function that verify the number of arguments, and removes those in excess
        /// </summary>
        /// <param name="args">An array containing the arguments passed to the Action</param>
        public void Trigger(string[] args)
        {
            //resize the arguments array to match the number of arguments expected by the action
            Array.Resize<string>(ref args, this.ArgumentsNumber);
            Do(args);
        }
        #endregion
    }
}

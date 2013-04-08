
namespace Csvy.Plugin.Referential
{
    public class ActionInstance
    {
        private string displayName;
        private string actionType;
        private string arguments;
        private bool isDefault;
        private string condition;
        private string iconPath;

        #region Constructors
        public ActionInstance() { }

        public ActionInstance(string displayName, string actionType, string arguments, bool isDefault, string condition, string iconPath)
        {
            this.displayName = displayName;
            this.actionType = actionType;
            this.arguments = arguments;
            this.isDefault = isDefault;
            this.condition = condition;
            this.iconPath = iconPath;
        }
        #endregion

        #region Properties
        public string DisplayName
        {
            get { return displayName; }
            set { displayName = value; }
        }

        public string ActionType
        {
            get { return actionType; }
            set { actionType = value; }
        }

        public string Arguments
        {
            get { return arguments; }
            set { arguments = value; }
        }

        public bool Default
        {
            get { return isDefault; }
            set { isDefault = value; }
        }

        public string Condition
        {
            get { return condition; }
            set { condition = value; }
        }

        public string IconPath
        {
            get { return iconPath; }
            set { iconPath = value; }
        }
        #endregion
    }
}

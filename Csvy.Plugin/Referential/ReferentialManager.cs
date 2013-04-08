using System;
using System.Collections.Generic;
using System.Text;

namespace Csvy.Plugin.Referential
{
    public class ReferentialManager
    {
        private CsvHandler referential = new CsvHandler();
        private List<ActionInstance> actions=new List<ActionInstance>();
        private string triggerWord;
        private string displayMask;
        private string iconPath;
        private string itemIconPath;

        #region Properties
        public string TriggerWord
        {
            get { return triggerWord; }
            set { triggerWord = value; }
        }

        public string DisplayMask
        {
            get { return displayMask; }
            set { displayMask = value; }
        }

        public string IconPath
        {
            get { return iconPath; }
            set { iconPath = value; }
        }

        public string ItemIconPath
        {
            get { return itemIconPath; }
            set { itemIconPath = value; }
        }

        public CsvHandler CsvHandler
        {
            get { return referential; }
            set { referential = value; }
        }

        public List<ActionInstance> Actions
        {
            get { return actions; }
            set { actions = value; }
        } 
        #endregion
    }
}

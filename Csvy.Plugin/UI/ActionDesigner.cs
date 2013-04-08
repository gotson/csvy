using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Csvy.Action.Interface;
using Csvy.Plugin.Helpers;

namespace Csvy.Plugin.UI
{
    public partial class ActionDesigner : Form
    {
        ExpressionDesigner expDesigner;

        public ActionDesigner(ReferentialDesigner parent, Csvy pluginParent)
        {
            InitializeComponent();

            expDesigner = new ExpressionDesigner(parent,pluginParent);

            // initialize combobox for available actions
            foreach (KeyValuePair<String, ActionBase> pair in ActionHelper.GetAvailableActions())
                comboActionType.Items.Add(pair.Key);

            try
            {
                this.TopMost = bool.Parse(pluginParent.ConfigurationManager.getValue(global::Csvy.Plugin.Properties.Resources.LAUNCHY_INI_GENOPS, global::Csvy.Plugin.Properties.Resources.LAUNCHY_INI_GENOPS_TOPMOST));
            }
            catch (Exception) { this.TopMost = false; }
        }

        #region Functions
        private void CheckValidation()
        {
            if (tbActionName.Text.Length > 0 && !String.IsNullOrEmpty(comboActionType.Text))
                btnAccept.Enabled = true;
            else
                btnAccept.Enabled = false;
        }

        public void Clear()
        {
            tbActionArguments.Text = string.Empty;
            tbActionName.Text = string.Empty;
            tbCondition.Text = string.Empty;
            tbIconPath.Text = string.Empty;
            try
            {
                comboActionType.SelectedIndex = 0;
            }
            catch (Exception) { }
        } 
        #endregion

        #region Properties
        public string ActionName
        {
            get { return tbActionName.Text; }
            set { tbActionName.Text = value; }
        }

        public string ActionType
        {
            get { return comboActionType.Text; }
            set { comboActionType.Text = value; }
        }

        public string ActionArguments
        {
            get { return tbActionArguments.Text; }
            set { tbActionArguments.Text = value; }
        }

        public string ActionCondition
        {
            get { return tbCondition.Text; }
            set { tbCondition.Text = value; }
        }

        public string ActionIconPath
        {
            get { return tbIconPath.Text; }
            set { tbIconPath.Text = value; }
        }
        #endregion

        #region Events
        private void comboActions_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBox1, ActionHelper.GetAvailableActions()[comboActionType.Text].Description);
            CheckValidation();
        }

        private void tbActionName_TextChanged(object sender, EventArgs e)
        {
            CheckValidation();
        }

        private void ActionDesigner_Shown(object sender, EventArgs e)
        {
            tbActionName.Focus();
            tbActionName.Select(tbActionName.Text.Length, 0);
        }

        private void btnDesignArgs_Click(object sender, EventArgs e)
        {
            expDesigner.ExpressionHelper(tbActionArguments);
        }

        private void btnDesignCondition_Click(object sender, EventArgs e)
        {
            expDesigner.ExpressionHelper(tbCondition);
        }

        private void btnDesignName_Click(object sender, EventArgs e)
        {
            expDesigner.ExpressionHelper(tbActionName);
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                tbIconPath.Text = openFileDialog1.FileName;
            }
        }

        private void btnDesignIconPath_Click(object sender, EventArgs e)
        {
            expDesigner.ExpressionHelper(tbIconPath);
        }
        #endregion
    }
}


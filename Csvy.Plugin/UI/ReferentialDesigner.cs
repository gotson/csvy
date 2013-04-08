using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Csvy.Plugin.Referential;
using Csvy.Plugin.Helpers;
using LumenWorks.Framework.IO.Csv;
using IniFiles;

namespace Csvy.Plugin.UI
{
    public partial class ReferentialDesigner : Form
    {
        ExpressionDesigner expDesigner;
        ActionDesigner actDesigner;

        public ReferentialDesigner(Csvy pluginParent)
        {
            InitializeComponent();

            try
            {
                this.TopMost = bool.Parse(pluginParent.ConfigurationManager.getValue(global::Csvy.Plugin.Properties.Resources.LAUNCHY_INI_GENOPS, global::Csvy.Plugin.Properties.Resources.LAUNCHY_INI_GENOPS_TOPMOST));
            }
            catch (Exception) { this.TopMost = false; }

            expDesigner = new ExpressionDesigner(this, pluginParent);
            actDesigner = new ActionDesigner(this, pluginParent);
        }

        #region Properties
        public ReferentialManager Referential
        {
            get
            {
                ReferentialManager referential = new ReferentialManager();
                referential.TriggerWord = tbTriggerWord.Text;
                referential.CsvHandler.FileName = tbReferential.Text;
                referential.CsvHandler.PrimaryKeyExtension = tbFullPathMask.Text;
                referential.DisplayMask = tbDisplayMask.Text;
                referential.IconPath = tbIconPath.Text;
                referential.ItemIconPath = tbItemIconPath.Text;
                referential.CsvHandler.CsvHasHeaders = cbHasHeaders.Checked;
                referential.CsvHandler.CsvDelimiter = string.IsNullOrEmpty(tbDelimiter.Text) ? CsvReader.DefaultDelimiter : tbDelimiter.Text.ToCharArray()[0];
                referential.CsvHandler.CsvQuote = string.IsNullOrEmpty(tbQuote.Text) ? CsvReader.DefaultQuote : tbQuote.Text.ToCharArray()[0];
                referential.CsvHandler.CsvEscape = string.IsNullOrEmpty(tbEscape.Text) ? CsvReader.DefaultEscape : tbEscape.Text.ToCharArray()[0];
                referential.CsvHandler.CsvComment = string.IsNullOrEmpty(tbComment.Text) ? CsvReader.DefaultComment : tbComment.Text.ToCharArray()[0];
                List<ActionInstance> actions = new List<ActionInstance>();
                foreach (ListViewItem item in lstActions.Items)
                {
                    ActionInstance a = new ActionInstance(item.Text, item.SubItems[1].Text, item.SubItems[2].Text, item.Checked, item.SubItems[3].Text, item.SubItems[4].Text);
                    actions.Add(a);
                }
                referential.Actions = actions;
                return referential;
            }
            set
            {
                tbTriggerWord.Text = value.TriggerWord;
                tbReferential.Text = value.CsvHandler.FileName;
                tbFullPathMask.Text = value.CsvHandler.PrimaryKeyExtension;
                tbDisplayMask.Text = value.DisplayMask;
                tbIconPath.Text = value.IconPath;
                tbItemIconPath.Text = value.ItemIconPath;
                cbHasHeaders.Checked = value.CsvHandler.CsvHasHeaders;
                tbDelimiter.Text = value.CsvHandler.CsvDelimiter.ToString();
                tbQuote.Text = value.CsvHandler.CsvQuote.ToString();
                tbEscape.Text = value.CsvHandler.CsvEscape.ToString();
                tbComment.Text = value.CsvHandler.CsvComment.ToString();
                lstActions.Items.Clear();
                foreach (var a in value.Actions)
                {
                    ListViewItem i = new ListViewItem(a.DisplayName);
                    i.Name = i.Text;
                    i.Checked = a.Default;
                    i.SubItems.Add(a.ActionType);
                    i.SubItems.Add(a.Arguments);
                    i.SubItems.Add(a.Condition);
                    i.SubItems.Add(a.IconPath);
                    lstActions.Items.Add(i);
                }
            }
        }
        #endregion

        #region Events
        private void btnBrowseRef_Click(object sender, EventArgs e)
        {
            if (openFileDialogRef.ShowDialog() == DialogResult.OK)
            {
                tbReferential.Text = openFileDialogRef.FileName;
            }
        }

        private void btnBrowseIcon_Click(object sender, EventArgs e)
        {
            if (openFileDialogIcon.ShowDialog() == DialogResult.OK)
            {
                tbIconPath.Text = openFileDialogIcon.FileName;
            }
        }

        private void btnBrowseItemIcon_Click(object sender, EventArgs e)
        {
            if (openFileDialogIcon.ShowDialog() == DialogResult.OK)
            {
                tbItemIconPath.Text = openFileDialogIcon.FileName;
            }
        }

        private void btnDesignName_Click(object sender, EventArgs e)
        {
            try
            {
                expDesigner.ExpressionHelper(tbDisplayMask);
            }
            catch (Exception) { }
        }

        private void btnDesignPath_Click(object sender, EventArgs e)
        {
            try
            {
                expDesigner.ExpressionHelper(tbFullPathMask);
            }
            catch (Exception) { }
        }

        private void btnDesignItemIconPath_Click(object sender, EventArgs e)
        {
            try
            {
                expDesigner.ExpressionHelper(tbItemIconPath);
            }
            catch (Exception) { }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            actDesigner.Clear();
            actDesigner.Text = "Add new action";
            DialogResult dr = actDesigner.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                ListViewItem i = new ListViewItem(actDesigner.ActionName);
                i.Name = i.Text;
                i.SubItems.Add(actDesigner.ActionType);
                i.SubItems.Add(actDesigner.ActionArguments);
                i.SubItems.Add(actDesigner.ActionCondition);
                i.SubItems.Add(actDesigner.ActionIconPath);
                lstActions.Items.Add(i);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                lstActions.Items.RemoveAt(lstActions.SelectedIndices[0]);
            }
            catch (Exception) { }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditAction(false);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            try
            {
                int location = lstActions.SelectedIndices[0];
                if (location > 0)
                {
                    ListViewItem item = lstActions.Items[location];
                    lstActions.Items.RemoveAt(location);
                    lstActions.Items.Insert(location - 1, item);
                }
            }
            catch (Exception) { }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            EditAction(true);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            try
            {
                int location = lstActions.SelectedIndices[0];
                if (location < lstActions.Items.Count - 1)
                {
                    ListViewItem item = lstActions.Items[location];
                    lstActions.Items.RemoveAt(location);
                    lstActions.Items.Insert(location + 1, item);
                }
            }
            catch (Exception) { }
        }

        private void lstActions_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            foreach (ListViewItem i in lstActions.Items)
            {
                i.Checked = false;
            }
        }

        private void lstActions_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int location = lstActions.SelectedIndices[0];
                if (location > 0)
                    btnUp.Image = global::Csvy.Plugin.Properties.Resources.arrow_up;
                if (location < lstActions.Items.Count - 1)
                    btnDown.Image = global::Csvy.Plugin.Properties.Resources.arrow_down;
                btnRemove.Image = global::Csvy.Plugin.Properties.Resources.delete;
                btnCopy.Image = global::Csvy.Plugin.Properties.Resources.copy;
                btnEdit.Image = global::Csvy.Plugin.Properties.Resources.edit;
            }
            catch (Exception)
            {
                // no item is selected
                btnUp.Image = global::Csvy.Plugin.Properties.Resources.arrow_up_bw;
                btnDown.Image = global::Csvy.Plugin.Properties.Resources.arrow_down_bw;
                btnRemove.Image = global::Csvy.Plugin.Properties.Resources.delete_bw;
                btnCopy.Image = global::Csvy.Plugin.Properties.Resources.copy_bw;
                btnEdit.Image = global::Csvy.Plugin.Properties.Resources.edit_bw;
            }
        }
        #endregion

        private void EditAction(bool duplicate)
        {
            try
            {
                ListViewItem current = lstActions.SelectedItems[0];
                int location = lstActions.SelectedIndices[0];
                actDesigner.ActionName = current.Text;
                actDesigner.ActionType = current.SubItems[1].Text;
                actDesigner.ActionArguments = current.SubItems[2].Text;
                actDesigner.ActionCondition = current.SubItems[3].Text;
                actDesigner.ActionIconPath = current.SubItems[4].Text;
                if (duplicate)
                    actDesigner.Text = "Duplicate action: " + current.Text;
                else
                    actDesigner.Text = "Edit action: " + current.Text;
                DialogResult dr = actDesigner.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    ListViewItem i = new ListViewItem(actDesigner.ActionName);
                    i.Name = i.Text;
                    i.SubItems.Add(actDesigner.ActionType);
                    i.SubItems.Add(actDesigner.ActionArguments);
                    i.SubItems.Add(actDesigner.ActionCondition);
                    i.SubItems.Add(actDesigner.ActionIconPath);
                    if (!duplicate)
                    {
                        lstActions.Items.RemoveAt(location);
                        lstActions.Items.Insert(location, i);
                    }
                    else
                        lstActions.Items.Insert(location + 1, i);
                    lstActions.Items[location].Checked = current.Checked;
                }
            }
            catch (Exception) { }
        }
    }
}

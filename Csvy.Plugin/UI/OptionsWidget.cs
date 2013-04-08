using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Csvy.Plugin.Referential;

namespace Csvy.Plugin.UI
{
    public partial class OptionsWidget : UserControl
    {
        Csvy pluginParent;
        List<ReferentialManager> referentials;

        public OptionsWidget(Csvy parent)
        {
            this.pluginParent = parent;
            InitializeComponent();
            referentials = new List<ReferentialManager>();
        }

        #region Properties
        public string PluginName
        {
            get { return lbPluginName.Text; }
            set { lbPluginName.Text = value; }
        }

        public string PluginVersion
        {
            get { return lbPluginVersion.Text; }
            set { lbPluginVersion.Text = value; }
        }

        public List<ReferentialManager> Referentials
        {
            get { return referentials; }
            set
            {
                referentials = value;
                RefToList();
            }
        }
        #endregion

        #region Events
        private void btnApply_Click(object sender, EventArgs e)
        {
            pluginParent.ApplyConfiguration();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ReferentialDesigner refDesigner = new ReferentialDesigner(pluginParent);
            refDesigner.Text = "Add new referential";
            DialogResult dr = refDesigner.ShowDialog(this);
            if (dr == DialogResult.OK)
            {
                referentials.Add(refDesigner.Referential);
                RefToList();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                referentials.RemoveAt(lstReferentials.SelectedIndices[0]);
                RefToList();
            }
            catch (Exception) { }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            EditReferential(false);
        }

        private void lstReferentials_DoubleClick(object sender, EventArgs e)
        {
            EditReferential(false);
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            try
            {
                int location = lstReferentials.SelectedIndices[0];
                if (location > 0)
                {
                    ReferentialManager item = referentials[location];
                    referentials.RemoveAt(location);
                    referentials.Insert(location - 1, item);
                    RefToList();
                    lstReferentials.Items[location - 1].Selected = true;
                }
            }
            catch (Exception) { }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            EditReferential(true);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            try
            {
                int location = lstReferentials.SelectedIndices[0];
                if (location < lstReferentials.Items.Count - 1)
                {
                    ReferentialManager item = referentials[location];
                    referentials.RemoveAt(location);
                    referentials.Insert(location + 1, item);
                    RefToList();
                    lstReferentials.Items[location + 1].Selected = true;
                }
            }
            catch (Exception) { }
        }

        private void lstReferentials_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int location = lstReferentials.SelectedIndices[0];
                if (location > 0)
                    btnUp.Image = global::Csvy.Plugin.Properties.Resources.arrow_up;
                else
                    btnUp.Image = global::Csvy.Plugin.Properties.Resources.arrow_up_bw;
                if (location < lstReferentials.Items.Count - 1)
                    btnDown.Image = global::Csvy.Plugin.Properties.Resources.arrow_down;
                else
                    btnDown.Image = global::Csvy.Plugin.Properties.Resources.arrow_down_bw;
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

        // Display the inner referential list inside the ListView
        private void RefToList()
        {
            lstReferentials.Items.Clear();
            foreach (var r in referentials)
            {
                ListViewItem i = new ListViewItem(r.TriggerWord);
                i.Name = i.Text;
                i.SubItems.Add(r.CsvHandler.FileName);
                i.SubItems.Add(r.IconPath);
                i.SubItems.Add(r.CsvHandler.CsvHasHeaders.ToString());
                i.SubItems.Add(r.CsvHandler.CsvDelimiter.ToString());
                i.SubItems.Add(r.CsvHandler.CsvQuote.ToString());
                i.SubItems.Add(r.CsvHandler.CsvEscape.ToString());
                i.SubItems.Add(r.CsvHandler.CsvComment.ToString());
                lstReferentials.Items.Add(i);
            }
        }

        private void EditReferential(bool duplicate)
        {
            try
            {
                int location = lstReferentials.SelectedIndices[0];
                ReferentialManager current = referentials[location];

                ReferentialDesigner refDesigner = new ReferentialDesigner(pluginParent);
                if (duplicate)
                    refDesigner.Text = "Duplicate referential: " + current.TriggerWord;
                else
                    refDesigner.Text = "Edit referential: " + current.TriggerWord;
                refDesigner.Referential = current;
                DialogResult dr = refDesigner.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    if (!duplicate)
                        referentials.RemoveAt(location);
                    else
                        location++;
                    referentials.Insert(location, refDesigner.Referential);
                    RefToList();
                    lstReferentials.Items[location].Selected = true;
                }
            }
            catch (Exception) { }
        }
    }
}

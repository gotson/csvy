using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Csvy.Plugin.Helpers;
using Csvy.Plugin.Referential;

namespace Csvy.Plugin.UI
{
    public partial class ExpressionDesigner : Form
    {
        // Parent is used only to retrieve the referential every time we show the dialog
        ReferentialDesigner parent;
        // Referential that will ke kept in cache, because the referential from the ReferentialDesigner
        // is generated on the fly everytime we use the get property
        ReferentialManager referential;
        // pagination to browse the CSV content. It's kept in cache to handle incorrect OnTextChange events
        int page = 1;

        public ExpressionDesigner(ReferentialDesigner parent, Csvy pluginParent)
        {
            this.parent = parent;
            InitializeComponent();

            try
            {
                this.TopMost = bool.Parse(pluginParent.ConfigurationManager.getValue(global::Csvy.Plugin.Properties.Resources.LAUNCHY_INI_GENOPS, global::Csvy.Plugin.Properties.Resources.LAUNCHY_INI_GENOPS_TOPMOST));
            }
            catch (Exception) { this.TopMost = false; }
        }

        #region Properties
        public string Expression
        {
            get { return tbExpression.Text; }
            set { tbExpression.Text = value; }
        }
        #endregion

        #region Public Functions
        public void ExpressionHelper(Control control)
        {
            Expression = control.Text;
            DialogResult dr = this.ShowDialog();
            if (dr == DialogResult.OK)
                control.Text = Expression;
        }
        #endregion

        #region Private Functions
        private void PopulateList()
        {
            // clear list content
            lstHeaders.Items.Clear();

            foreach (string header in referential.CsvHandler.Headers)
            {
                ListViewItem i = new ListViewItem("%" + header + "%");
                i.SubItems.Add(referential.CsvHandler.Rows[page - 1][header].ToString());
                lstHeaders.Items.Add(i);
            }
        }
        #endregion

        #region Events
        private void lstHeaders_ItemActivate(object sender, EventArgs e)
        {
            try
            {
                tbExpression.Text += lstHeaders.SelectedItems[0].Text;
                tbExpression.Focus();
                tbExpression.Select(tbExpression.Text.Length, 0);

            }
            catch (Exception) { }
        }

        private void ExpressionDesigner_Shown(object sender, EventArgs e)
        {
            referential = parent.Referential;
            page = 1;
            tbItemNumber.Text = page.ToString();
            try
            {
                lbMaxNumber.Text = "on " + referential.CsvHandler.Rows.Count;
            }
            catch (Exception)
            {
                lbMaxNumber.Text = "on ";
            }
            tbExpression.Focus();
            tbExpression.Select(tbExpression.Text.Length, 0);
            PopulateList();
            UpdatePreview();
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            try
            {
                int numberEntered = int.Parse(tbItemNumber.Text);
                numberEntered++;
                tbItemNumber.Text = numberEntered.ToString();
            }
            catch (Exception) { }
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            try
            {
                int numberEntered = int.Parse(tbItemNumber.Text);
                numberEntered--;
                tbItemNumber.Text = numberEntered.ToString();
            }
            catch (Exception) { }
        }

        private void tbExpression_TextChanged(object sender, EventArgs e)
        {
            UpdatePreview();
        }

        private void tbItemNumber_TextChanged(object sender, EventArgs e)
        {
            ValidatePage();
        }
        #endregion

        #region Private Functions
        private void UpdatePreview()
        {
            try
            {
                tbPreview.Text = "";
                string[] args = CsvHelper.CsvStringToArray(tbExpression.Text);
                // replace mask for each argument
                for (int i = 0; i < args.Length; i++)
                {
                    tbPreview.Text += SearchHelper.ReplaceMaskWithItem(args[i], referential.CsvHandler.Rows[page - 1]);
                    if (i < args.Length - 1)
                        tbPreview.Text += ",";
                }
            }
            catch (Exception) { }
        }

        private bool ValidatePage()
        {
            try
            {
                int numberEntered = int.Parse(tbItemNumber.Text);
                if (numberEntered < 1 || numberEntered > referential.CsvHandler.Rows.Count)
                {
                    throw new FormatException();
                }
                page = numberEntered;

                if (page > 1)
                    btnLeft.Image = global::Csvy.Plugin.Properties.Resources.arrow_left;
                else
                    btnLeft.Image = global::Csvy.Plugin.Properties.Resources.arrow_left_bw;
                if (page < referential.CsvHandler.Rows.Count)
                    btnRight.Image = global::Csvy.Plugin.Properties.Resources.arrow_right;
                else
                    btnRight.Image = global::Csvy.Plugin.Properties.Resources.arrow_right_bw;

                PopulateList();
                UpdatePreview();
                return true;
            }
            catch (Exception)
            {
                tbItemNumber.Text = page.ToString();
                return false;
            }
        }
        #endregion
    }
}

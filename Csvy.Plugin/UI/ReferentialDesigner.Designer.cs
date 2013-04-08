namespace Csvy.Plugin.UI
{
    partial class ReferentialDesigner
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialogRef = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.tbReferential = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTriggerWord = new System.Windows.Forms.TextBox();
            this.btnBrowseRef = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbComment = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbEscape = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbQuote = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDelimiter = new System.Windows.Forms.TextBox();
            this.cbHasHeaders = new System.Windows.Forms.CheckBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnBrowseIcon = new System.Windows.Forms.Button();
            this.tbIconPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnDesignItemIconPath = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btnBrowseItemIcon = new System.Windows.Forms.Button();
            this.tbItemIconPath = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnDesignPath = new System.Windows.Forms.Button();
            this.btnDesignName = new System.Windows.Forms.Button();
            this.tbFullPathMask = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDisplayMask = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnCopy = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDown = new System.Windows.Forms.PictureBox();
            this.btnUp = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.PictureBox();
            this.btnRemove = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.lstActions = new System.Windows.Forms.ListView();
            this.DisplayName = new System.Windows.Forms.ColumnHeader();
            this.ActionType = new System.Windows.Forms.ColumnHeader();
            this.Arguments = new System.Windows.Forms.ColumnHeader();
            this.Condition = new System.Windows.Forms.ColumnHeader();
            this.IconPath = new System.Windows.Forms.ColumnHeader();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.openFileDialogIcon = new System.Windows.Forms.OpenFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCopy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialogRef
            // 
            this.openFileDialogRef.Filter = "CSV files|*.csv";
            this.openFileDialogRef.Title = "Locate referential file (.csv)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Path to referential file (.csv):";
            // 
            // tbReferential
            // 
            this.tbReferential.Location = new System.Drawing.Point(11, 23);
            this.tbReferential.Name = "tbReferential";
            this.tbReferential.Size = new System.Drawing.Size(368, 20);
            this.tbReferential.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Trigger word";
            // 
            // tbTriggerWord
            // 
            this.tbTriggerWord.Location = new System.Drawing.Point(80, 48);
            this.tbTriggerWord.MaxLength = 10;
            this.tbTriggerWord.Name = "tbTriggerWord";
            this.tbTriggerWord.Size = new System.Drawing.Size(64, 20);
            this.tbTriggerWord.TabIndex = 3;
            // 
            // btnBrowseRef
            // 
            this.btnBrowseRef.AutoSize = true;
            this.btnBrowseRef.Location = new System.Drawing.Point(385, 21);
            this.btnBrowseRef.Name = "btnBrowseRef";
            this.btnBrowseRef.Size = new System.Drawing.Size(61, 23);
            this.btnBrowseRef.TabIndex = 2;
            this.btnBrowseRef.Text = "Browse...";
            this.btnBrowseRef.UseVisualStyleBackColor = true;
            this.btnBrowseRef.Click += new System.EventHandler(this.btnBrowseRef_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(485, 229);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.pictureBox3);
            this.tabPage1.Controls.Add(this.btnBrowseIcon);
            this.tabPage1.Controls.Add(this.tbIconPath);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.tbReferential);
            this.tabPage1.Controls.Add(this.btnBrowseRef);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tbTriggerWord);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(477, 203);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "General Options";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.tbComment);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.tbEscape);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tbQuote);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tbDelimiter);
            this.groupBox1.Controls.Add(this.cbHasHeaders);
            this.groupBox1.Location = new System.Drawing.Point(11, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 47);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "CSV options";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(338, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Comment";
            // 
            // tbComment
            // 
            this.tbComment.Location = new System.Drawing.Point(395, 17);
            this.tbComment.MaxLength = 1;
            this.tbComment.Name = "tbComment";
            this.tbComment.Size = new System.Drawing.Size(15, 20);
            this.tbComment.TabIndex = 10;
            this.tbComment.Text = "#";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(260, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Escape";
            // 
            // tbEscape
            // 
            this.tbEscape.Location = new System.Drawing.Point(309, 17);
            this.tbEscape.MaxLength = 1;
            this.tbEscape.Name = "tbEscape";
            this.tbEscape.Size = new System.Drawing.Size(15, 20);
            this.tbEscape.TabIndex = 9;
            this.tbEscape.Text = "\"";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(189, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Quote";
            // 
            // tbQuote
            // 
            this.tbQuote.Location = new System.Drawing.Point(231, 17);
            this.tbQuote.MaxLength = 1;
            this.tbQuote.Name = "tbQuote";
            this.tbQuote.Size = new System.Drawing.Size(15, 20);
            this.tbQuote.TabIndex = 8;
            this.tbQuote.Text = "\"";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(107, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Delimiter";
            // 
            // tbDelimiter
            // 
            this.tbDelimiter.Location = new System.Drawing.Point(160, 17);
            this.tbDelimiter.MaxLength = 1;
            this.tbDelimiter.Name = "tbDelimiter";
            this.tbDelimiter.Size = new System.Drawing.Size(15, 20);
            this.tbDelimiter.TabIndex = 7;
            this.tbDelimiter.Text = ",";
            // 
            // cbHasHeaders
            // 
            this.cbHasHeaders.AutoSize = true;
            this.cbHasHeaders.Checked = true;
            this.cbHasHeaders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbHasHeaders.Location = new System.Drawing.Point(6, 19);
            this.cbHasHeaders.Name = "cbHasHeaders";
            this.cbHasHeaders.Size = new System.Drawing.Size(87, 17);
            this.cbHasHeaders.TabIndex = 6;
            this.cbHasHeaders.Text = "Had headers";
            this.cbHasHeaders.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Csvy.Plugin.Properties.Resources.help_small;
            this.pictureBox3.Location = new System.Drawing.Point(452, 74);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(19, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 31;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "Choose the icon to display for this referential.\r\nLeave the path blank to use the" +
                    " plugin default icon.");
            // 
            // btnBrowseIcon
            // 
            this.btnBrowseIcon.AutoSize = true;
            this.btnBrowseIcon.Location = new System.Drawing.Point(385, 72);
            this.btnBrowseIcon.Name = "btnBrowseIcon";
            this.btnBrowseIcon.Size = new System.Drawing.Size(61, 23);
            this.btnBrowseIcon.TabIndex = 5;
            this.btnBrowseIcon.Text = "Browse...";
            this.btnBrowseIcon.UseVisualStyleBackColor = true;
            this.btnBrowseIcon.Click += new System.EventHandler(this.btnBrowseIcon_Click);
            // 
            // tbIconPath
            // 
            this.tbIconPath.Location = new System.Drawing.Point(80, 74);
            this.tbIconPath.Name = "tbIconPath";
            this.tbIconPath.Size = new System.Drawing.Size(299, 20);
            this.tbIconPath.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Icon Path";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Csvy.Plugin.Properties.Resources.help_small;
            this.pictureBox1.Location = new System.Drawing.Point(146, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox1, "An update of the catalog is necessary after a change of the trigger word");
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnDesignItemIconPath);
            this.tabPage3.Controls.Add(this.pictureBox4);
            this.tabPage3.Controls.Add(this.btnBrowseItemIcon);
            this.tabPage3.Controls.Add(this.tbItemIconPath);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.btnDesignPath);
            this.tabPage3.Controls.Add(this.btnDesignName);
            this.tabPage3.Controls.Add(this.tbFullPathMask);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.tbDisplayMask);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(477, 203);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Display";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnDesignItemIconPath
            // 
            this.btnDesignItemIconPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesignItemIconPath.AutoSize = true;
            this.btnDesignItemIconPath.Location = new System.Drawing.Point(384, 61);
            this.btnDesignItemIconPath.Name = "btnDesignItemIconPath";
            this.btnDesignItemIconPath.Size = new System.Drawing.Size(61, 23);
            this.btnDesignItemIconPath.TabIndex = 30;
            this.btnDesignItemIconPath.Text = "Design";
            this.toolTip1.SetToolTip(this.btnDesignItemIconPath, "Click to access the Expression Designer dialog");
            this.btnDesignItemIconPath.UseVisualStyleBackColor = true;
            this.btnDesignItemIconPath.Click += new System.EventHandler(this.btnDesignItemIconPath_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Csvy.Plugin.Properties.Resources.help_small;
            this.pictureBox4.Location = new System.Drawing.Point(451, 63);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(19, 19);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 31;
            this.pictureBox4.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox4, "You can either choose the icon to display for the referential items, or use eleme" +
                    "nts from the referential.\r\nLeave the path blank to use the referential default i" +
                    "con.");
            // 
            // btnBrowseItemIcon
            // 
            this.btnBrowseItemIcon.AutoSize = true;
            this.btnBrowseItemIcon.Location = new System.Drawing.Point(317, 61);
            this.btnBrowseItemIcon.Name = "btnBrowseItemIcon";
            this.btnBrowseItemIcon.Size = new System.Drawing.Size(61, 23);
            this.btnBrowseItemIcon.TabIndex = 29;
            this.btnBrowseItemIcon.Text = "Browse...";
            this.btnBrowseItemIcon.UseVisualStyleBackColor = true;
            this.btnBrowseItemIcon.Click += new System.EventHandler(this.btnBrowseItemIcon_Click);
            // 
            // tbItemIconPath
            // 
            this.tbItemIconPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbItemIconPath.Location = new System.Drawing.Point(107, 62);
            this.tbItemIconPath.Name = "tbItemIconPath";
            this.tbItemIconPath.Size = new System.Drawing.Size(204, 20);
            this.tbItemIconPath.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Item Icon Path";
            this.toolTip1.SetToolTip(this.label11, "The item path is displayed under the item name, as an information");
            // 
            // btnDesignPath
            // 
            this.btnDesignPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesignPath.AutoSize = true;
            this.btnDesignPath.Location = new System.Drawing.Point(420, 34);
            this.btnDesignPath.Name = "btnDesignPath";
            this.btnDesignPath.Size = new System.Drawing.Size(50, 23);
            this.btnDesignPath.TabIndex = 4;
            this.btnDesignPath.Text = "Design";
            this.toolTip1.SetToolTip(this.btnDesignPath, "Click to access the Expression Designer dialog");
            this.btnDesignPath.UseVisualStyleBackColor = true;
            this.btnDesignPath.Click += new System.EventHandler(this.btnDesignPath_Click);
            // 
            // btnDesignName
            // 
            this.btnDesignName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesignName.AutoSize = true;
            this.btnDesignName.Location = new System.Drawing.Point(420, 8);
            this.btnDesignName.Name = "btnDesignName";
            this.btnDesignName.Size = new System.Drawing.Size(50, 23);
            this.btnDesignName.TabIndex = 2;
            this.btnDesignName.Text = "Design";
            this.toolTip1.SetToolTip(this.btnDesignName, "Click to access the Expression Designer dialog");
            this.btnDesignName.UseVisualStyleBackColor = true;
            this.btnDesignName.Click += new System.EventHandler(this.btnDesignName_Click);
            // 
            // tbFullPathMask
            // 
            this.tbFullPathMask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbFullPathMask.Location = new System.Drawing.Point(107, 36);
            this.tbFullPathMask.Name = "tbFullPathMask";
            this.tbFullPathMask.Size = new System.Drawing.Size(307, 20);
            this.tbFullPathMask.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Item Display Path";
            this.toolTip1.SetToolTip(this.label6, "The item path is displayed under the item name, as an information");
            // 
            // tbDisplayMask
            // 
            this.tbDisplayMask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbDisplayMask.Location = new System.Drawing.Point(107, 10);
            this.tbDisplayMask.Name = "tbDisplayMask";
            this.tbDisplayMask.Size = new System.Drawing.Size(307, 20);
            this.tbDisplayMask.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Item Display Name";
            this.toolTip1.SetToolTip(this.label4, "The item display name is used to search items");
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnCopy);
            this.tabPage4.Controls.Add(this.label1);
            this.tabPage4.Controls.Add(this.pictureBox2);
            this.tabPage4.Controls.Add(this.btnDown);
            this.tabPage4.Controls.Add(this.btnUp);
            this.tabPage4.Controls.Add(this.btnEdit);
            this.tabPage4.Controls.Add(this.btnRemove);
            this.tabPage4.Controls.Add(this.btnAdd);
            this.tabPage4.Controls.Add(this.lstActions);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(477, 203);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Actions";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnCopy
            // 
            this.btnCopy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCopy.Image = global::Csvy.Plugin.Properties.Resources.copy_bw;
            this.btnCopy.Location = new System.Drawing.Point(447, 126);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(24, 24);
            this.btnCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCopy.TabIndex = 23;
            this.btnCopy.TabStop = false;
            this.toolTip1.SetToolTip(this.btnCopy, "Edit a copy of the selected action");
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "You can choose the default action by ticking the checkbox next to it.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Csvy.Plugin.Properties.Resources.help_small;
            this.pictureBox2.Location = new System.Drawing.Point(6, 179);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // btnDown
            // 
            this.btnDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDown.Image = global::Csvy.Plugin.Properties.Resources.arrow_down_bw;
            this.btnDown.Location = new System.Drawing.Point(447, 156);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(24, 24);
            this.btnDown.TabIndex = 6;
            this.btnDown.TabStop = false;
            this.toolTip1.SetToolTip(this.btnDown, "Move the selected action down");
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnUp
            // 
            this.btnUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUp.Image = global::Csvy.Plugin.Properties.Resources.arrow_up_bw;
            this.btnUp.Location = new System.Drawing.Point(447, 6);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(24, 24);
            this.btnUp.TabIndex = 5;
            this.btnUp.TabStop = false;
            this.toolTip1.SetToolTip(this.btnUp, "Move the selected action up");
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Image = global::Csvy.Plugin.Properties.Resources.edit_bw;
            this.btnEdit.Location = new System.Drawing.Point(447, 96);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(24, 24);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.TabStop = false;
            this.toolTip1.SetToolTip(this.btnEdit, "Edit selected action");
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRemove.Image = global::Csvy.Plugin.Properties.Resources.delete_bw;
            this.btnRemove.Location = new System.Drawing.Point(447, 66);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(24, 24);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.TabStop = false;
            this.toolTip1.SetToolTip(this.btnRemove, "Delete selected action");
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Image = global::Csvy.Plugin.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(447, 36);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(24, 24);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.TabStop = false;
            this.toolTip1.SetToolTip(this.btnAdd, "Add new action");
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lstActions
            // 
            this.lstActions.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstActions.CheckBoxes = true;
            this.lstActions.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.DisplayName,
            this.ActionType,
            this.Arguments,
            this.Condition,
            this.IconPath});
            this.lstActions.FullRowSelect = true;
            this.lstActions.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstActions.Location = new System.Drawing.Point(6, 6);
            this.lstActions.MultiSelect = false;
            this.lstActions.Name = "lstActions";
            this.lstActions.Size = new System.Drawing.Size(435, 172);
            this.lstActions.TabIndex = 0;
            this.lstActions.UseCompatibleStateImageBehavior = false;
            this.lstActions.View = System.Windows.Forms.View.Details;
            this.lstActions.SelectedIndexChanged += new System.EventHandler(this.lstActions_SelectedIndexChanged);
            this.lstActions.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstActions_ItemCheck);
            // 
            // DisplayName
            // 
            this.DisplayName.Text = "Name";
            this.DisplayName.Width = 79;
            // 
            // ActionType
            // 
            this.ActionType.Text = "Type";
            this.ActionType.Width = 82;
            // 
            // Arguments
            // 
            this.Arguments.Text = "Arguments";
            this.Arguments.Width = 181;
            // 
            // Condition
            // 
            this.Condition.Text = "Condition";
            this.Condition.Width = 77;
            // 
            // IconPath
            // 
            this.IconPath.Text = "Icon";
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.Location = new System.Drawing.Point(3, 247);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 16;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(84, 247);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 17;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // openFileDialogIcon
            // 
            this.openFileDialogIcon.Filter = "All files|*.*";
            this.openFileDialogIcon.Title = "Choose Icon";
            // 
            // ReferentialDesigner
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(492, 274);
            this.ControlBox = false;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReferentialDesigner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Referential Designer";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCopy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogRef;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbReferential;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTriggerWord;
        private System.Windows.Forms.Button btnBrowseRef;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox tbDisplayMask;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFullPathMask;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnDesignPath;
        private System.Windows.Forms.Button btnDesignName;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView lstActions;
        private System.Windows.Forms.ColumnHeader DisplayName;
        private System.Windows.Forms.ColumnHeader ActionType;
        private System.Windows.Forms.ColumnHeader Arguments;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox btnAdd;
        private System.Windows.Forms.PictureBox btnEdit;
        private System.Windows.Forms.PictureBox btnRemove;
        private System.Windows.Forms.PictureBox btnDown;
        private System.Windows.Forms.PictureBox btnUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader Condition;
        private System.Windows.Forms.ColumnHeader IconPath;
        private System.Windows.Forms.Button btnBrowseIcon;
        private System.Windows.Forms.TextBox tbIconPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialogIcon;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbHasHeaders;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbComment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbEscape;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbQuote;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDelimiter;
        private System.Windows.Forms.TextBox tbItemIconPath;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnDesignItemIconPath;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button btnBrowseItemIcon;
        private System.Windows.Forms.PictureBox btnCopy;
    }
}

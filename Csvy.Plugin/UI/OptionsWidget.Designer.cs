namespace Csvy.Plugin.UI
{
    partial class OptionsWidget
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnApply = new System.Windows.Forms.Button();
            this.lbPluginName = new System.Windows.Forms.Label();
            this.lbPluginVersion = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnAdd = new System.Windows.Forms.PictureBox();
            this.btnRemove = new System.Windows.Forms.PictureBox();
            this.btnEdit = new System.Windows.Forms.PictureBox();
            this.btnUp = new System.Windows.Forms.PictureBox();
            this.btnDown = new System.Windows.Forms.PictureBox();
            this.btnCopy = new System.Windows.Forms.PictureBox();
            this.TriggerWord = new System.Windows.Forms.ColumnHeader();
            this.File = new System.Windows.Forms.ColumnHeader();
            this.lstReferentials = new System.Windows.Forms.ListView();
            this.IconPath = new System.Windows.Forms.ColumnHeader();
            this.HadHeaders = new System.Windows.Forms.ColumnHeader();
            this.Delimiter = new System.Windows.Forms.ColumnHeader();
            this.Quote = new System.Windows.Forms.ColumnHeader();
            this.Escape = new System.Windows.Forms.ColumnHeader();
            this.Comment = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCopy)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Csvy.Plugin.Properties.Resources.horny_bird_small;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "CSV files|*.csv";
            this.openFileDialog1.Title = "Locate referential file (.csv)";
            // 
            // btnApply
            // 
            this.btnApply.AutoSize = true;
            this.btnApply.Location = new System.Drawing.Point(3, 273);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(48, 23);
            this.btnApply.TabIndex = 15;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // lbPluginName
            // 
            this.lbPluginName.AutoSize = true;
            this.lbPluginName.Location = new System.Drawing.Point(123, 3);
            this.lbPluginName.Name = "lbPluginName";
            this.lbPluginName.Size = new System.Drawing.Size(64, 13);
            this.lbPluginName.TabIndex = 7;
            this.lbPluginName.Text = "plugin name";
            // 
            // lbPluginVersion
            // 
            this.lbPluginVersion.AutoSize = true;
            this.lbPluginVersion.Location = new System.Drawing.Point(123, 19);
            this.lbPluginVersion.Name = "lbPluginVersion";
            this.lbPluginVersion.Size = new System.Drawing.Size(72, 13);
            this.lbPluginVersion.TabIndex = 16;
            this.lbPluginVersion.Text = "plugin version";
            // 
            // btnAdd
            // 
            this.btnAdd.Image = global::Csvy.Plugin.Properties.Resources.add;
            this.btnAdd.Location = new System.Drawing.Point(453, 123);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(24, 24);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.TabStop = false;
            this.toolTip1.SetToolTip(this.btnAdd, "Add a new referential");
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Image = global::Csvy.Plugin.Properties.Resources.delete_bw;
            this.btnRemove.Location = new System.Drawing.Point(453, 153);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(24, 24);
            this.btnRemove.TabIndex = 19;
            this.btnRemove.TabStop = false;
            this.toolTip1.SetToolTip(this.btnRemove, "Delete selected referential");
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::Csvy.Plugin.Properties.Resources.edit_bw;
            this.btnEdit.Location = new System.Drawing.Point(453, 183);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(24, 24);
            this.btnEdit.TabIndex = 20;
            this.btnEdit.TabStop = false;
            this.toolTip1.SetToolTip(this.btnEdit, "Edit selected referential");
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnUp
            // 
            this.btnUp.Image = global::Csvy.Plugin.Properties.Resources.arrow_up_bw;
            this.btnUp.Location = new System.Drawing.Point(453, 93);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(24, 24);
            this.btnUp.TabIndex = 21;
            this.btnUp.TabStop = false;
            this.toolTip1.SetToolTip(this.btnUp, "Move the selected referential up");
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Image = global::Csvy.Plugin.Properties.Resources.arrow_down_bw;
            this.btnDown.Location = new System.Drawing.Point(453, 243);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(24, 24);
            this.btnDown.TabIndex = 22;
            this.btnDown.TabStop = false;
            this.toolTip1.SetToolTip(this.btnDown, "Move the selected referential down");
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Image = global::Csvy.Plugin.Properties.Resources.copy_bw;
            this.btnCopy.Location = new System.Drawing.Point(453, 213);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(24, 24);
            this.btnCopy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCopy.TabIndex = 24;
            this.btnCopy.TabStop = false;
            this.toolTip1.SetToolTip(this.btnCopy, "Edit a copy of the selected referential");
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // TriggerWord
            // 
            this.TriggerWord.Text = "Trigger Word";
            this.TriggerWord.Width = 119;
            // 
            // File
            // 
            this.File.Text = "File";
            this.File.Width = 181;
            // 
            // lstReferentials
            // 
            this.lstReferentials.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.TriggerWord,
            this.File,
            this.IconPath,
            this.HadHeaders,
            this.Delimiter,
            this.Quote,
            this.Escape,
            this.Comment});
            this.lstReferentials.FullRowSelect = true;
            this.lstReferentials.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstReferentials.Location = new System.Drawing.Point(3, 93);
            this.lstReferentials.MultiSelect = false;
            this.lstReferentials.Name = "lstReferentials";
            this.lstReferentials.Size = new System.Drawing.Size(444, 174);
            this.lstReferentials.TabIndex = 17;
            this.lstReferentials.UseCompatibleStateImageBehavior = false;
            this.lstReferentials.View = System.Windows.Forms.View.Details;
            this.lstReferentials.SelectedIndexChanged += new System.EventHandler(this.lstReferentials_SelectedIndexChanged);
            this.lstReferentials.DoubleClick += new System.EventHandler(this.lstReferentials_DoubleClick);
            // 
            // IconPath
            // 
            this.IconPath.Text = "Icon";
            // 
            // HadHeaders
            // 
            this.HadHeaders.Text = "Had Headers";
            // 
            // Delimiter
            // 
            this.Delimiter.Text = "Delimiter";
            // 
            // Quote
            // 
            this.Quote.Text = "Quote";
            // 
            // Escape
            // 
            this.Escape.Text = "Escape";
            // 
            // Comment
            // 
            this.Comment.Text = "Comment";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Get the most of your CSV files, directly inside Launchy!";
            // 
            // OptionsWidget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lstReferentials);
            this.Controls.Add(this.lbPluginVersion);
            this.Controls.Add(this.lbPluginName);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.pictureBox1);
            this.Name = "OptionsWidget";
            this.Size = new System.Drawing.Size(486, 301);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRemove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnUp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCopy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Label lbPluginName;
        private System.Windows.Forms.Label lbPluginVersion;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ColumnHeader TriggerWord;
        private System.Windows.Forms.ColumnHeader File;
        private System.Windows.Forms.ListView lstReferentials;
        private System.Windows.Forms.PictureBox btnAdd;
        private System.Windows.Forms.PictureBox btnRemove;
        private System.Windows.Forms.PictureBox btnEdit;
        private System.Windows.Forms.PictureBox btnUp;
        private System.Windows.Forms.PictureBox btnDown;
        private System.Windows.Forms.ColumnHeader IconPath;
        private System.Windows.Forms.ColumnHeader HadHeaders;
        private System.Windows.Forms.ColumnHeader Delimiter;
        private System.Windows.Forms.ColumnHeader Quote;
        private System.Windows.Forms.ColumnHeader Escape;
        private System.Windows.Forms.ColumnHeader Comment;
        private System.Windows.Forms.PictureBox btnCopy;
        private System.Windows.Forms.Label label1;
    }
}

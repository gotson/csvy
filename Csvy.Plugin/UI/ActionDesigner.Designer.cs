namespace Csvy.Plugin.UI
{
    partial class ActionDesigner
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboActionType = new System.Windows.Forms.ComboBox();
            this.tbActionName = new System.Windows.Forms.TextBox();
            this.tbActionArguments = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnDesignArgs = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDesignCondition = new System.Windows.Forms.Button();
            this.btnDesignName = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnDesignIconPath = new System.Windows.Forms.Button();
            this.tbCondition = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbIconPath = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowse = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.Enabled = false;
            this.btnAccept.Location = new System.Drawing.Point(179, 142);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 11;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(260, 142);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Arguments";
            // 
            // comboActionType
            // 
            this.comboActionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboActionType.FormattingEnabled = true;
            this.comboActionType.Location = new System.Drawing.Point(75, 32);
            this.comboActionType.Name = "comboActionType";
            this.comboActionType.Size = new System.Drawing.Size(143, 21);
            this.comboActionType.Sorted = true;
            this.comboActionType.TabIndex = 3;
            this.comboActionType.SelectedIndexChanged += new System.EventHandler(this.comboActions_SelectedIndexChanged);
            // 
            // tbActionName
            // 
            this.tbActionName.Location = new System.Drawing.Point(75, 6);
            this.tbActionName.Name = "tbActionName";
            this.tbActionName.Size = new System.Drawing.Size(168, 20);
            this.tbActionName.TabIndex = 1;
            this.tbActionName.TextChanged += new System.EventHandler(this.tbActionName_TextChanged);
            // 
            // tbActionArguments
            // 
            this.tbActionArguments.Location = new System.Drawing.Point(75, 59);
            this.tbActionArguments.Name = "tbActionArguments";
            this.tbActionArguments.Size = new System.Drawing.Size(168, 20);
            this.tbActionArguments.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Csvy.Plugin.Properties.Resources.help_small;
            this.pictureBox1.Location = new System.Drawing.Point(224, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(19, 19);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // btnDesignArgs
            // 
            this.btnDesignArgs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesignArgs.AutoSize = true;
            this.btnDesignArgs.Location = new System.Drawing.Point(249, 57);
            this.btnDesignArgs.Name = "btnDesignArgs";
            this.btnDesignArgs.Size = new System.Drawing.Size(61, 23);
            this.btnDesignArgs.TabIndex = 5;
            this.btnDesignArgs.Text = "Design";
            this.toolTip1.SetToolTip(this.btnDesignArgs, "Click to access the Expression Designer dialog");
            this.btnDesignArgs.UseVisualStyleBackColor = true;
            this.btnDesignArgs.Click += new System.EventHandler(this.btnDesignArgs_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Csvy.Plugin.Properties.Resources.help_small;
            this.pictureBox2.Location = new System.Drawing.Point(316, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(19, 19);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "You can specify a %HEADER% token or a $FUNCTION as a condition.\r\nIf the value is " +
                    "blank, the action will not be displayed.\r\n\r\nLeave the condition blank to always " +
                    "display the action.");
            // 
            // btnDesignCondition
            // 
            this.btnDesignCondition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesignCondition.AutoSize = true;
            this.btnDesignCondition.Location = new System.Drawing.Point(249, 83);
            this.btnDesignCondition.Name = "btnDesignCondition";
            this.btnDesignCondition.Size = new System.Drawing.Size(61, 23);
            this.btnDesignCondition.TabIndex = 7;
            this.btnDesignCondition.Text = "Design";
            this.toolTip1.SetToolTip(this.btnDesignCondition, "Click to access the Expression Designer dialog");
            this.btnDesignCondition.UseVisualStyleBackColor = true;
            this.btnDesignCondition.Click += new System.EventHandler(this.btnDesignCondition_Click);
            // 
            // btnDesignName
            // 
            this.btnDesignName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesignName.AutoSize = true;
            this.btnDesignName.Location = new System.Drawing.Point(249, 4);
            this.btnDesignName.Name = "btnDesignName";
            this.btnDesignName.Size = new System.Drawing.Size(61, 23);
            this.btnDesignName.TabIndex = 2;
            this.btnDesignName.Text = "Design";
            this.toolTip1.SetToolTip(this.btnDesignName, "Click to access the Expression Designer dialog");
            this.btnDesignName.UseVisualStyleBackColor = true;
            this.btnDesignName.Click += new System.EventHandler(this.btnDesignName_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Csvy.Plugin.Properties.Resources.help_small;
            this.pictureBox3.Location = new System.Drawing.Point(316, 112);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(19, 19);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 28;
            this.pictureBox3.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox3, "You can either choose the icon to display for this action, or use elements from t" +
                    "he referential.\r\nLeave the path blank to use the referential item default icon.");
            // 
            // btnDesignIconPath
            // 
            this.btnDesignIconPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDesignIconPath.AutoSize = true;
            this.btnDesignIconPath.Location = new System.Drawing.Point(249, 109);
            this.btnDesignIconPath.Name = "btnDesignIconPath";
            this.btnDesignIconPath.Size = new System.Drawing.Size(61, 23);
            this.btnDesignIconPath.TabIndex = 10;
            this.btnDesignIconPath.Text = "Design";
            this.toolTip1.SetToolTip(this.btnDesignIconPath, "Click to access the Expression Designer dialog");
            this.btnDesignIconPath.UseVisualStyleBackColor = true;
            this.btnDesignIconPath.Click += new System.EventHandler(this.btnDesignIconPath_Click);
            // 
            // tbCondition
            // 
            this.tbCondition.Location = new System.Drawing.Point(75, 85);
            this.tbCondition.Name = "tbCondition";
            this.tbCondition.Size = new System.Drawing.Size(168, 20);
            this.tbCondition.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Condition";
            // 
            // tbIconPath
            // 
            this.tbIconPath.Location = new System.Drawing.Point(75, 111);
            this.tbIconPath.Name = "tbIconPath";
            this.tbIconPath.Size = new System.Drawing.Size(101, 20);
            this.tbIconPath.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Icon Path";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "All files|*.*";
            this.openFileDialog1.Title = "Choose Icon";
            // 
            // btnBrowse
            // 
            this.btnBrowse.AutoSize = true;
            this.btnBrowse.Location = new System.Drawing.Point(182, 109);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(61, 23);
            this.btnBrowse.TabIndex = 9;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // ActionDesigner
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(341, 171);
            this.ControlBox = false;
            this.Controls.Add(this.btnDesignIconPath);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.tbIconPath);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDesignName);
            this.Controls.Add(this.btnDesignCondition);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.tbCondition);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDesignArgs);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tbActionArguments);
            this.Controls.Add(this.tbActionName);
            this.Controls.Add(this.comboActionType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ActionDesigner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Action Designer";
            this.Shown += new System.EventHandler(this.ActionDesigner_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboActionType;
        private System.Windows.Forms.TextBox tbActionName;
        private System.Windows.Forms.TextBox tbActionArguments;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnDesignArgs;
        private System.Windows.Forms.TextBox tbCondition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnDesignCondition;
        private System.Windows.Forms.Button btnDesignName;
        private System.Windows.Forms.TextBox tbIconPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnDesignIconPath;
    }
}
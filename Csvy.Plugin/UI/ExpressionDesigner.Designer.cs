namespace Csvy.Plugin.UI
{
    partial class ExpressionDesigner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpressionDesigner));
            this.lstHeaders = new System.Windows.Forms.ListView();
            this.hToken = new System.Windows.Forms.ColumnHeader();
            this.hExample = new System.Windows.Forms.ColumnHeader();
            this.tbExpression = new System.Windows.Forms.TextBox();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pbHelp = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tbPreview = new System.Windows.Forms.TextBox();
            this.btnRight = new System.Windows.Forms.PictureBox();
            this.btnLeft = new System.Windows.Forms.PictureBox();
            this.tbItemNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMaxNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLeft)).BeginInit();
            this.SuspendLayout();
            // 
            // lstHeaders
            // 
            this.lstHeaders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lstHeaders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hToken,
            this.hExample});
            this.lstHeaders.FullRowSelect = true;
            this.lstHeaders.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lstHeaders.Location = new System.Drawing.Point(11, 30);
            this.lstHeaders.MultiSelect = false;
            this.lstHeaders.Name = "lstHeaders";
            this.lstHeaders.Size = new System.Drawing.Size(596, 149);
            this.lstHeaders.TabIndex = 1;
            this.lstHeaders.UseCompatibleStateImageBehavior = false;
            this.lstHeaders.View = System.Windows.Forms.View.Details;
            this.lstHeaders.ItemActivate += new System.EventHandler(this.lstHeaders_ItemActivate);
            // 
            // hToken
            // 
            this.hToken.Text = "Token";
            this.hToken.Width = 178;
            // 
            // hExample
            // 
            this.hExample.Text = "Example data";
            this.hExample.Width = 253;
            // 
            // tbExpression
            // 
            this.tbExpression.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbExpression.Location = new System.Drawing.Point(11, 185);
            this.tbExpression.Name = "tbExpression";
            this.tbExpression.Size = new System.Drawing.Size(409, 20);
            this.tbExpression.TabIndex = 2;
            this.tbExpression.TextChanged += new System.EventHandler(this.tbExpression_TextChanged);
            // 
            // btnAccept
            // 
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.Location = new System.Drawing.Point(451, 185);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 3;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(532, 185);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // pbHelp
            // 
            this.pbHelp.Image = global::Csvy.Plugin.Properties.Resources.help_small;
            this.pbHelp.Location = new System.Drawing.Point(426, 185);
            this.pbHelp.Name = "pbHelp";
            this.pbHelp.Size = new System.Drawing.Size(19, 19);
            this.pbHelp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pbHelp.TabIndex = 23;
            this.pbHelp.TabStop = false;
            this.toolTip1.SetToolTip(this.pbHelp, resources.GetString("pbHelp.ToolTip"));
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Preview";
            // 
            // tbPreview
            // 
            this.tbPreview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbPreview.Location = new System.Drawing.Point(63, 211);
            this.tbPreview.Name = "tbPreview";
            this.tbPreview.ReadOnly = true;
            this.tbPreview.Size = new System.Drawing.Size(357, 20);
            this.tbPreview.TabIndex = 25;
            this.tbPreview.TabStop = false;
            // 
            // btnRight
            // 
            this.btnRight.Image = global::Csvy.Plugin.Properties.Resources.arrow_right;
            this.btnRight.Location = new System.Drawing.Point(583, 3);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(24, 24);
            this.btnRight.TabIndex = 26;
            this.btnRight.TabStop = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // btnLeft
            // 
            this.btnLeft.Image = global::Csvy.Plugin.Properties.Resources.arrow_left_bw;
            this.btnLeft.Location = new System.Drawing.Point(416, 3);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(24, 24);
            this.btnLeft.TabIndex = 27;
            this.btnLeft.TabStop = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // tbItemNumber
            // 
            this.tbItemNumber.Location = new System.Drawing.Point(479, 7);
            this.tbItemNumber.Name = "tbItemNumber";
            this.tbItemNumber.Size = new System.Drawing.Size(29, 20);
            this.tbItemNumber.TabIndex = 28;
            this.tbItemNumber.TextChanged += new System.EventHandler(this.tbItemNumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Item";
            // 
            // lbMaxNumber
            // 
            this.lbMaxNumber.AutoSize = true;
            this.lbMaxNumber.Location = new System.Drawing.Point(514, 10);
            this.lbMaxNumber.Name = "lbMaxNumber";
            this.lbMaxNumber.Size = new System.Drawing.Size(19, 13);
            this.lbMaxNumber.TabIndex = 30;
            this.lbMaxNumber.Text = "on";
            // 
            // ExpressionDesigner
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(620, 235);
            this.ControlBox = false;
            this.Controls.Add(this.lbMaxNumber);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbItemNumber);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.tbPreview);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbHelp);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.tbExpression);
            this.Controls.Add(this.lstHeaders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExpressionDesigner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Expression Designer";
            this.Shown += new System.EventHandler(this.ExpressionDesigner_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pbHelp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnLeft)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstHeaders;
        private System.Windows.Forms.ColumnHeader hToken;
        private System.Windows.Forms.ColumnHeader hExample;
        private System.Windows.Forms.TextBox tbExpression;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.PictureBox pbHelp;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbPreview;
        private System.Windows.Forms.PictureBox btnRight;
        private System.Windows.Forms.PictureBox btnLeft;
        private System.Windows.Forms.TextBox tbItemNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbMaxNumber;
    }
}
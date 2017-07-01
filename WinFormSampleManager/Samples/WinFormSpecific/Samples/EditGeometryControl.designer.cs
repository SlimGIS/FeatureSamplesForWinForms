namespace SlimGis.Samples
{
    partial class EditGeometryControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditGeometryControl));
            this.translateCheckBox = new System.Windows.Forms.CheckBox();
            this.rotateCheckBox = new System.Windows.Forms.CheckBox();
            this.resizeCheckBox = new System.Windows.Forms.CheckBox();
            this.reshapeCheckBox = new System.Windows.Forms.CheckBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // translateCheckBox
            // 
            this.translateCheckBox.AutoSize = true;
            this.translateCheckBox.Checked = true;
            this.translateCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.translateCheckBox.Location = new System.Drawing.Point(3, 3);
            this.translateCheckBox.Name = "translateCheckBox";
            this.translateCheckBox.Size = new System.Drawing.Size(90, 21);
            this.translateCheckBox.TabIndex = 0;
            this.translateCheckBox.Text = "Translate";
            this.translateCheckBox.UseVisualStyleBackColor = true;
            this.translateCheckBox.CheckedChanged += new System.EventHandler(this.SettingCheckBox_CheckedChanged);
            // 
            // rotateCheckBox
            // 
            this.rotateCheckBox.AutoSize = true;
            this.rotateCheckBox.Checked = true;
            this.rotateCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.rotateCheckBox.Location = new System.Drawing.Point(3, 30);
            this.rotateCheckBox.Name = "rotateCheckBox";
            this.rotateCheckBox.Size = new System.Drawing.Size(72, 21);
            this.rotateCheckBox.TabIndex = 1;
            this.rotateCheckBox.Text = "Rotate";
            this.rotateCheckBox.UseVisualStyleBackColor = true;
            this.rotateCheckBox.CheckedChanged += new System.EventHandler(this.SettingCheckBox_CheckedChanged);
            // 
            // resizeCheckBox
            // 
            this.resizeCheckBox.AutoSize = true;
            this.resizeCheckBox.Checked = true;
            this.resizeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.resizeCheckBox.Location = new System.Drawing.Point(3, 57);
            this.resizeCheckBox.Name = "resizeCheckBox";
            this.resizeCheckBox.Size = new System.Drawing.Size(73, 21);
            this.resizeCheckBox.TabIndex = 2;
            this.resizeCheckBox.Text = "Resize";
            this.resizeCheckBox.UseVisualStyleBackColor = true;
            this.resizeCheckBox.CheckedChanged += new System.EventHandler(this.SettingCheckBox_CheckedChanged);
            // 
            // reshapeCheckBox
            // 
            this.reshapeCheckBox.AutoSize = true;
            this.reshapeCheckBox.Checked = true;
            this.reshapeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.reshapeCheckBox.Location = new System.Drawing.Point(3, 84);
            this.reshapeCheckBox.Name = "reshapeCheckBox";
            this.reshapeCheckBox.Size = new System.Drawing.Size(87, 21);
            this.reshapeCheckBox.TabIndex = 3;
            this.reshapeCheckBox.Text = "Reshape";
            this.reshapeCheckBox.UseVisualStyleBackColor = true;
            this.reshapeCheckBox.CheckedChanged += new System.EventHandler(this.SettingCheckBox_CheckedChanged);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionLabel.Location = new System.Drawing.Point(3, 108);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(322, 376);
            this.descriptionLabel.TabIndex = 4;
            this.descriptionLabel.Text = resources.GetString("descriptionLabel.Text");
            // 
            // EditGeometryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.reshapeCheckBox);
            this.Controls.Add(this.resizeCheckBox);
            this.Controls.Add(this.rotateCheckBox);
            this.Controls.Add(this.translateCheckBox);
            this.Name = "EditGeometryControl";
            this.Size = new System.Drawing.Size(328, 484);
            this.Load += new System.EventHandler(this.EditGeometryControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox translateCheckBox;
        private System.Windows.Forms.CheckBox rotateCheckBox;
        private System.Windows.Forms.CheckBox resizeCheckBox;
        private System.Windows.Forms.CheckBox reshapeCheckBox;
        private System.Windows.Forms.Label descriptionLabel;
    }
}

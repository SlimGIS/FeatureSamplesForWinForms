namespace SlimGis.Samples
{
    partial class UseBuildInToolsControl
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
            this.zoomBarCheckBox = new System.Windows.Forms.CheckBox();
            this.scaleBarCheckBox = new System.Windows.Forms.CheckBox();
            this.viewportBlockCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // zoomBarCheckBox
            // 
            this.zoomBarCheckBox.AutoSize = true;
            this.zoomBarCheckBox.Location = new System.Drawing.Point(3, 3);
            this.zoomBarCheckBox.Name = "zoomBarCheckBox";
            this.zoomBarCheckBox.Size = new System.Drawing.Size(69, 17);
            this.zoomBarCheckBox.TabIndex = 0;
            this.zoomBarCheckBox.Text = "ZoomBar";
            this.zoomBarCheckBox.UseVisualStyleBackColor = true;
            this.zoomBarCheckBox.CheckedChanged += new System.EventHandler(this.SettingCheckBox_CheckedChanged);
            // 
            // scaleBarCheckBox
            // 
            this.scaleBarCheckBox.AutoSize = true;
            this.scaleBarCheckBox.Location = new System.Drawing.Point(3, 26);
            this.scaleBarCheckBox.Name = "scaleBarCheckBox";
            this.scaleBarCheckBox.Size = new System.Drawing.Size(69, 17);
            this.scaleBarCheckBox.TabIndex = 1;
            this.scaleBarCheckBox.Text = "ScaleBar";
            this.scaleBarCheckBox.UseVisualStyleBackColor = true;
            this.scaleBarCheckBox.CheckedChanged += new System.EventHandler(this.SettingCheckBox_CheckedChanged);
            // 
            // viewportBlockCheckBox
            // 
            this.viewportBlockCheckBox.AutoSize = true;
            this.viewportBlockCheckBox.Location = new System.Drawing.Point(3, 49);
            this.viewportBlockCheckBox.Name = "viewportBlockCheckBox";
            this.viewportBlockCheckBox.Size = new System.Drawing.Size(94, 17);
            this.viewportBlockCheckBox.TabIndex = 2;
            this.viewportBlockCheckBox.Text = "ViewportBlock";
            this.viewportBlockCheckBox.UseVisualStyleBackColor = true;
            this.viewportBlockCheckBox.CheckedChanged += new System.EventHandler(this.SettingCheckBox_CheckedChanged);
            // 
            // UseBuildInToolsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewportBlockCheckBox);
            this.Controls.Add(this.scaleBarCheckBox);
            this.Controls.Add(this.zoomBarCheckBox);
            this.Name = "UseBuildInToolsControl";
            this.Size = new System.Drawing.Size(293, 381);
            this.Load += new System.EventHandler(this.UseBuildInToolsControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox zoomBarCheckBox;
        private System.Windows.Forms.CheckBox scaleBarCheckBox;
        private System.Windows.Forms.CheckBox viewportBlockCheckBox;
    }
}

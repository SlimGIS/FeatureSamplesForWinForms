namespace SlimGis.Samples
{
    partial class UseLineStyleControl
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
            this.randomStyleButton = new System.Windows.Forms.Button();
            this.useDashCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // randomStyleButton
            // 
            this.randomStyleButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.randomStyleButton.Location = new System.Drawing.Point(3, 3);
            this.randomStyleButton.Name = "randomStyleButton";
            this.randomStyleButton.Size = new System.Drawing.Size(285, 23);
            this.randomStyleButton.TabIndex = 0;
            this.randomStyleButton.Text = "Random Style";
            this.randomStyleButton.UseVisualStyleBackColor = true;
            this.randomStyleButton.Click += new System.EventHandler(this.randomStyleButton_Click);
            // 
            // useDashCheckBox
            // 
            this.useDashCheckBox.AutoSize = true;
            this.useDashCheckBox.Location = new System.Drawing.Point(3, 32);
            this.useDashCheckBox.Name = "useDashCheckBox";
            this.useDashCheckBox.Size = new System.Drawing.Size(73, 17);
            this.useDashCheckBox.TabIndex = 1;
            this.useDashCheckBox.Text = "Use Dash";
            this.useDashCheckBox.UseVisualStyleBackColor = true;
            this.useDashCheckBox.CheckedChanged += new System.EventHandler(this.useDashCheckBox_CheckedChanged);
            // 
            // UseLineStyleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.useDashCheckBox);
            this.Controls.Add(this.randomStyleButton);
            this.Name = "UseLineStyleControl";
            this.Size = new System.Drawing.Size(291, 355);
            this.Load += new System.EventHandler(this.UseLineStyleControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button randomStyleButton;
        private System.Windows.Forms.CheckBox useDashCheckBox;
    }
}

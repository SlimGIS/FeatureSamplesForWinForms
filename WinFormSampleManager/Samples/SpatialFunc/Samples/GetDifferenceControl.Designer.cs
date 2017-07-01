namespace SlimGis.Samples
{
    partial class GetDifferenceControl
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
            this.getDifferenceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getDifferenceButton
            // 
            this.getDifferenceButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.getDifferenceButton.Location = new System.Drawing.Point(2, 2);
            this.getDifferenceButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.getDifferenceButton.Name = "getDifferenceButton";
            this.getDifferenceButton.Size = new System.Drawing.Size(266, 19);
            this.getDifferenceButton.TabIndex = 0;
            this.getDifferenceButton.Text = "Get Difference";
            this.getDifferenceButton.UseVisualStyleBackColor = true;
            this.getDifferenceButton.Click += new System.EventHandler(this.GetDifferenceButton_Click);
            // 
            // GetDifferenceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.getDifferenceButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GetDifferenceControl";
            this.Size = new System.Drawing.Size(270, 308);
            this.Load += new System.EventHandler(this.GetDifferenceControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getDifferenceButton;
    }
}

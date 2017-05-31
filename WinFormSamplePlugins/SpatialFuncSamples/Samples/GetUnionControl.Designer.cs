namespace SlimGis.Samples
{
    partial class GetUnionControl
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
            this.getUnionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getUnionButton
            // 
            this.getUnionButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.getUnionButton.Location = new System.Drawing.Point(2, 2);
            this.getUnionButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.getUnionButton.Name = "getUnionButton";
            this.getUnionButton.Size = new System.Drawing.Size(224, 19);
            this.getUnionButton.TabIndex = 0;
            this.getUnionButton.Text = "Get Union";
            this.getUnionButton.UseVisualStyleBackColor = true;
            this.getUnionButton.Click += new System.EventHandler(this.GetUnionButton_Click);
            // 
            // GetUnionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.getUnionButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GetUnionControl";
            this.Size = new System.Drawing.Size(229, 288);
            this.Load += new System.EventHandler(this.GetUnionControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getUnionButton;
    }
}

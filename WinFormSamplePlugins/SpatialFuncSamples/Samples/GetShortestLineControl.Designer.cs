namespace SlimGis.Samples
{
    partial class GetShortestLineControl
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
            this.getShortestLineButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getShortestLineButton
            // 
            this.getShortestLineButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.getShortestLineButton.Location = new System.Drawing.Point(3, 3);
            this.getShortestLineButton.Name = "getShortestLineButton";
            this.getShortestLineButton.Size = new System.Drawing.Size(307, 23);
            this.getShortestLineButton.TabIndex = 0;
            this.getShortestLineButton.Text = "Get Shortest Line";
            this.getShortestLineButton.UseVisualStyleBackColor = true;
            this.getShortestLineButton.Click += new System.EventHandler(this.GetShortestLineButton_Click);
            // 
            // GetShortestLineControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.getShortestLineButton);
            this.Name = "GetShortestLineControl";
            this.Size = new System.Drawing.Size(313, 400);
            this.Load += new System.EventHandler(this.GetShortestLineControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getShortestLineButton;
    }
}

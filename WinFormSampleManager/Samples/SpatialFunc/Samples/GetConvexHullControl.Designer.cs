namespace SlimGis.Samples
{
    partial class GetConvexHullControl
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
            this.getConvexHullButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getConvexHullButton
            // 
            this.getConvexHullButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.getConvexHullButton.Location = new System.Drawing.Point(3, 3);
            this.getConvexHullButton.Name = "getConvexHullButton";
            this.getConvexHullButton.Size = new System.Drawing.Size(339, 23);
            this.getConvexHullButton.TabIndex = 0;
            this.getConvexHullButton.Text = "Get Convex Hull";
            this.getConvexHullButton.UseVisualStyleBackColor = true;
            this.getConvexHullButton.Click += new System.EventHandler(this.GetConvexHullButton_Click);
            // 
            // GetConvexHullControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.getConvexHullButton);
            this.Name = "GetConvexHullControl";
            this.Size = new System.Drawing.Size(345, 325);
            this.Load += new System.EventHandler(this.GetConvexHullControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getConvexHullButton;
    }
}

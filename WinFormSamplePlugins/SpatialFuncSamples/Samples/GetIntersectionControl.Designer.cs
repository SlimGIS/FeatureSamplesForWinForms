namespace SlimGis.Samples
{
    partial class GetIntersectionControl
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
            this.getIntersectionButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getIntersectionButton
            // 
            this.getIntersectionButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.getIntersectionButton.Location = new System.Drawing.Point(3, 3);
            this.getIntersectionButton.Name = "getIntersectionButton";
            this.getIntersectionButton.Size = new System.Drawing.Size(302, 23);
            this.getIntersectionButton.TabIndex = 0;
            this.getIntersectionButton.Text = "Get Intersection";
            this.getIntersectionButton.UseVisualStyleBackColor = true;
            this.getIntersectionButton.Click += new System.EventHandler(this.GetIntersectionButton_Click);
            // 
            // GetIntersectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.getIntersectionButton);
            this.Name = "GetIntersectionControl";
            this.Size = new System.Drawing.Size(308, 329);
            this.Load += new System.EventHandler(this.GetIntersectionControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getIntersectionButton;
    }
}

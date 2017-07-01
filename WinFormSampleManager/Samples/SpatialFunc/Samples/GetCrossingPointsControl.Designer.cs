namespace SlimGis.Samples
{
    partial class GetCrossingPointsControl
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
            this.getCrossingButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getCrossingButton
            // 
            this.getCrossingButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.getCrossingButton.Location = new System.Drawing.Point(3, 3);
            this.getCrossingButton.Name = "getCrossingButton";
            this.getCrossingButton.Size = new System.Drawing.Size(214, 23);
            this.getCrossingButton.TabIndex = 0;
            this.getCrossingButton.Text = "Get Crossing";
            this.getCrossingButton.UseVisualStyleBackColor = true;
            this.getCrossingButton.Click += new System.EventHandler(this.getCrossingButton_Click);
            // 
            // GetCrossingPointsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.getCrossingButton);
            this.Name = "GetCrossingPointsControl";
            this.Size = new System.Drawing.Size(220, 329);
            this.Load += new System.EventHandler(this.GetCrossingPointsControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getCrossingButton;
    }
}

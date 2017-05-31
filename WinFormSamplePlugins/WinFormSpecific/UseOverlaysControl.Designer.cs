namespace SlimGis.Samples
{
    partial class UseOverlaysControl
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
            this.SuspendLayout();
            // 
            // randomStyleButton
            // 
            this.randomStyleButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.randomStyleButton.Location = new System.Drawing.Point(3, 3);
            this.randomStyleButton.Name = "randomStyleButton";
            this.randomStyleButton.Size = new System.Drawing.Size(313, 30);
            this.randomStyleButton.TabIndex = 0;
            this.randomStyleButton.Text = "Random style for countries";
            this.randomStyleButton.UseVisualStyleBackColor = true;
            this.randomStyleButton.Click += new System.EventHandler(this.randomStyleButton_Click);
            // 
            // UseOverlaysControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.randomStyleButton);
            this.Name = "UseOverlaysControl";
            this.Size = new System.Drawing.Size(319, 385);
            this.Load += new System.EventHandler(this.UseOverlaysControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button randomStyleButton;
    }
}

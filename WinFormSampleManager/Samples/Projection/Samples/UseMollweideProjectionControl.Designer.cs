namespace SlimGis.Samples
{
    partial class UseMollweideProjectionControl
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
            this.reprojectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reprojectButton
            // 
            this.reprojectButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reprojectButton.Location = new System.Drawing.Point(3, 3);
            this.reprojectButton.Name = "reprojectButton";
            this.reprojectButton.Size = new System.Drawing.Size(367, 30);
            this.reprojectButton.TabIndex = 0;
            this.reprojectButton.Text = "Reproject to Mollweide Projection";
            this.reprojectButton.UseVisualStyleBackColor = true;
            this.reprojectButton.Click += new System.EventHandler(this.reprojectButton_Click);
            // 
            // UseMollweideProjectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.reprojectButton);
            this.Name = "UseMollweideProjectionControl";
            this.Size = new System.Drawing.Size(373, 397);
            this.Load += new System.EventHandler(this.UseMollweideProjectionControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button reprojectButton;
    }
}

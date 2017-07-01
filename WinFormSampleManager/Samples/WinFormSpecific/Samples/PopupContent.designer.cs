namespace SlimGis.Samples
{
    partial class PopupContent
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
            this.poiIconPictureBox = new System.Windows.Forms.PictureBox();
            this.poiNameLabel = new System.Windows.Forms.Label();
            this.poiTypeLabel = new System.Windows.Forms.Label();
            this.poiDescriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.poiIconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // poiIconPictureBox
            // 
            this.poiIconPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.poiIconPictureBox.Location = new System.Drawing.Point(273, 13);
            this.poiIconPictureBox.Name = "poiIconPictureBox";
            this.poiIconPictureBox.Size = new System.Drawing.Size(80, 80);
            this.poiIconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.poiIconPictureBox.TabIndex = 0;
            this.poiIconPictureBox.TabStop = false;
            // 
            // poiNameLabel
            // 
            this.poiNameLabel.AutoSize = true;
            this.poiNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poiNameLabel.Location = new System.Drawing.Point(10, 13);
            this.poiNameLabel.Name = "poiNameLabel";
            this.poiNameLabel.Size = new System.Drawing.Size(85, 29);
            this.poiNameLabel.TabIndex = 1;
            this.poiNameLabel.Text = "label1";
            // 
            // poiTypeLabel
            // 
            this.poiTypeLabel.AutoSize = true;
            this.poiTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.poiTypeLabel.ForeColor = System.Drawing.Color.DarkGray;
            this.poiTypeLabel.Location = new System.Drawing.Point(12, 76);
            this.poiTypeLabel.Name = "poiTypeLabel";
            this.poiTypeLabel.Size = new System.Drawing.Size(41, 15);
            this.poiTypeLabel.TabIndex = 2;
            this.poiTypeLabel.Text = "label1";
            // 
            // poiDescriptionLabel
            // 
            this.poiDescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.poiDescriptionLabel.Location = new System.Drawing.Point(12, 113);
            this.poiDescriptionLabel.Name = "poiDescriptionLabel";
            this.poiDescriptionLabel.Size = new System.Drawing.Size(351, 118);
            this.poiDescriptionLabel.TabIndex = 3;
            this.poiDescriptionLabel.Text = "label1";
            // 
            // PopupContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.poiDescriptionLabel);
            this.Controls.Add(this.poiTypeLabel);
            this.Controls.Add(this.poiNameLabel);
            this.Controls.Add(this.poiIconPictureBox);
            this.Name = "PopupContent";
            this.Size = new System.Drawing.Size(374, 245);
            ((System.ComponentModel.ISupportInitialize)(this.poiIconPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox poiIconPictureBox;
        private System.Windows.Forms.Label poiNameLabel;
        private System.Windows.Forms.Label poiTypeLabel;
        private System.Windows.Forms.Label poiDescriptionLabel;
    }
}

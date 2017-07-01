namespace SlimGis.Samples
{
    partial class DrawGeometryControl
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
            this.trackModeComboBox = new System.Windows.Forms.ComboBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.noteLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // trackModeComboBox
            // 
            this.trackModeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackModeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trackModeComboBox.FormattingEnabled = true;
            this.trackModeComboBox.Location = new System.Drawing.Point(3, 32);
            this.trackModeComboBox.Name = "trackModeComboBox";
            this.trackModeComboBox.Size = new System.Drawing.Size(266, 21);
            this.trackModeComboBox.TabIndex = 0;
            this.trackModeComboBox.SelectedIndexChanged += new System.EventHandler(this.trackModeComboBox_SelectedIndexChanged);
            // 
            // resetButton
            // 
            this.resetButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resetButton.Location = new System.Drawing.Point(3, 3);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(266, 23);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionLabel.Location = new System.Drawing.Point(3, 65);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(266, 324);
            this.descriptionLabel.TabIndex = 2;
            this.descriptionLabel.Text = "label1";
            // 
            // noteLabel
            // 
            this.noteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.noteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteLabel.ForeColor = System.Drawing.Color.Gray;
            this.noteLabel.Location = new System.Drawing.Point(3, 389);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(266, 39);
            this.noteLabel.TabIndex = 3;
            this.noteLabel.Text = "label1";
            // 
            // DrawGeometryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.noteLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.trackModeComboBox);
            this.Name = "DrawGeometryControl";
            this.Size = new System.Drawing.Size(272, 436);
            this.Load += new System.EventHandler(this.DrawGeometryControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox trackModeComboBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label noteLabel;
    }
}

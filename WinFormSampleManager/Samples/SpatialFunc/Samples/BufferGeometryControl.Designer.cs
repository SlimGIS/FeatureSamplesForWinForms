namespace SlimGis.Samples
{
    partial class BufferGeometryControl
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
            this.bufferDistanceComboBox = new System.Windows.Forms.ComboBox();
            this.bufferGeometryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bufferDistanceComboBox
            // 
            this.bufferDistanceComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bufferDistanceComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.bufferDistanceComboBox.FormattingEnabled = true;
            this.bufferDistanceComboBox.Location = new System.Drawing.Point(2, 2);
            this.bufferDistanceComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bufferDistanceComboBox.Name = "bufferDistanceComboBox";
            this.bufferDistanceComboBox.Size = new System.Drawing.Size(272, 21);
            this.bufferDistanceComboBox.TabIndex = 0;
            // 
            // bufferGeometryButton
            // 
            this.bufferGeometryButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bufferGeometryButton.Location = new System.Drawing.Point(2, 27);
            this.bufferGeometryButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bufferGeometryButton.Name = "bufferGeometryButton";
            this.bufferGeometryButton.Size = new System.Drawing.Size(271, 19);
            this.bufferGeometryButton.TabIndex = 1;
            this.bufferGeometryButton.Text = "Buffer";
            this.bufferGeometryButton.UseVisualStyleBackColor = true;
            this.bufferGeometryButton.Click += new System.EventHandler(this.BufferGeometryButton_Click);
            // 
            // BufferGeometryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bufferGeometryButton);
            this.Controls.Add(this.bufferDistanceComboBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "BufferGeometryControl";
            this.Size = new System.Drawing.Size(275, 324);
            this.Load += new System.EventHandler(this.BufferGeometryControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox bufferDistanceComboBox;
        private System.Windows.Forms.Button bufferGeometryButton;
    }
}

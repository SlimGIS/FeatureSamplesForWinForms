namespace SlimGis.Samples
{
    partial class SpatialQueryControl
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
            this.queryOptionComboBox = new System.Windows.Forms.ComboBox();
            this.spatialQueryButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // queryOptionComboBox
            // 
            this.queryOptionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.queryOptionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.queryOptionComboBox.FormattingEnabled = true;
            this.queryOptionComboBox.Items.AddRange(new object[] {
            "Disjointed",
            "Intersecting",
            "Overlapping",
            "Within"});
            this.queryOptionComboBox.Location = new System.Drawing.Point(3, 3);
            this.queryOptionComboBox.Name = "queryOptionComboBox";
            this.queryOptionComboBox.Size = new System.Drawing.Size(352, 24);
            this.queryOptionComboBox.TabIndex = 0;
            // 
            // spatialQueryButton
            // 
            this.spatialQueryButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.spatialQueryButton.Location = new System.Drawing.Point(3, 33);
            this.spatialQueryButton.Name = "spatialQueryButton";
            this.spatialQueryButton.Size = new System.Drawing.Size(352, 30);
            this.spatialQueryButton.TabIndex = 1;
            this.spatialQueryButton.Text = "Spatial Query";
            this.spatialQueryButton.UseVisualStyleBackColor = true;
            this.spatialQueryButton.Click += new System.EventHandler(this.SpatialQueryButton_Click);
            // 
            // SpatialQueryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.spatialQueryButton);
            this.Controls.Add(this.queryOptionComboBox);
            this.Name = "SpatialQueryControl";
            this.Size = new System.Drawing.Size(358, 437);
            this.Load += new System.EventHandler(this.SpatialQueryControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox queryOptionComboBox;
        private System.Windows.Forms.Button spatialQueryButton;
    }
}

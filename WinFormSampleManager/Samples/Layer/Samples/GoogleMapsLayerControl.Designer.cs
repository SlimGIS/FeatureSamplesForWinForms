namespace SlimGis.Samples
{
    partial class GoogleMapsLayerControl
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
            this.layerTypeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // layerTypeComboBox
            // 
            this.layerTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layerTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.layerTypeComboBox.FormattingEnabled = true;
            this.layerTypeComboBox.Items.AddRange(new object[] {
            "RoadMap",
            "Satellite",
            "Terrain",
            "Hybrid"});
            this.layerTypeComboBox.Location = new System.Drawing.Point(3, 3);
            this.layerTypeComboBox.Name = "layerTypeComboBox";
            this.layerTypeComboBox.Size = new System.Drawing.Size(430, 24);
            this.layerTypeComboBox.TabIndex = 1;
            this.layerTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.layerTypeComboBox_SelectedIndexChanged);
            // 
            // GoogleMapsLayerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.layerTypeComboBox);
            this.Name = "GoogleMapsLayerControl";
            this.Size = new System.Drawing.Size(436, 423);
            this.Load += new System.EventHandler(this.GoogleMapsLayerControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox layerTypeComboBox;
    }
}

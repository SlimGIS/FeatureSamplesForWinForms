namespace SlimGis.Samples
{
    partial class UseHeatStyleControl
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
            this.colorPaletteTypeComboBox = new System.Windows.Forms.ComboBox();
            this.heatPointSizeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // colorPaletteTypeComboBox
            // 
            this.colorPaletteTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.colorPaletteTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorPaletteTypeComboBox.FormattingEnabled = true;
            this.colorPaletteTypeComboBox.Items.AddRange(new object[] {
            "Default",
            "Gray",
            "Rainbow",
            "RedWhiteBlue",
            "Thermal"});
            this.colorPaletteTypeComboBox.Location = new System.Drawing.Point(3, 3);
            this.colorPaletteTypeComboBox.Name = "colorPaletteTypeComboBox";
            this.colorPaletteTypeComboBox.Size = new System.Drawing.Size(237, 21);
            this.colorPaletteTypeComboBox.TabIndex = 0;
            this.colorPaletteTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.colorPaletteTypeComboBox_SelectedIndexChanged);
            // 
            // heatPointSizeComboBox
            // 
            this.heatPointSizeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.heatPointSizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.heatPointSizeComboBox.FormattingEnabled = true;
            this.heatPointSizeComboBox.Items.AddRange(new object[] {
            "Large",
            "Medium",
            "Samll"});
            this.heatPointSizeComboBox.Location = new System.Drawing.Point(3, 30);
            this.heatPointSizeComboBox.Name = "heatPointSizeComboBox";
            this.heatPointSizeComboBox.Size = new System.Drawing.Size(237, 21);
            this.heatPointSizeComboBox.TabIndex = 1;
            this.heatPointSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.heatPointSizeComboBox_SelectedIndexChanged);
            // 
            // UseHeatStyleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.heatPointSizeComboBox);
            this.Controls.Add(this.colorPaletteTypeComboBox);
            this.Name = "UseHeatStyleControl";
            this.Size = new System.Drawing.Size(243, 424);
            this.Load += new System.EventHandler(this.UseHeatStyleControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox colorPaletteTypeComboBox;
        private System.Windows.Forms.ComboBox heatPointSizeComboBox;
    }
}

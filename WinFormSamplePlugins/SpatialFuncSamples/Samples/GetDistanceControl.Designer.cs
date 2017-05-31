namespace SlimGis.Samples
{
    partial class GetDistanceControl
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
            this.getDistanceButton = new System.Windows.Forms.Button();
            this.distanceUnitComboBox = new System.Windows.Forms.ComboBox();
            this.gettingDistanceProgressBar = new System.Windows.Forms.ProgressBar();
            this.distanceLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // getDistanceButton
            // 
            this.getDistanceButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.getDistanceButton.Location = new System.Drawing.Point(3, 3);
            this.getDistanceButton.Name = "getDistanceButton";
            this.getDistanceButton.Size = new System.Drawing.Size(309, 23);
            this.getDistanceButton.TabIndex = 0;
            this.getDistanceButton.Text = "Get Distance";
            this.getDistanceButton.UseVisualStyleBackColor = true;
            this.getDistanceButton.Click += new System.EventHandler(this.GetDistanceButton_Click);
            // 
            // distanceUnitComboBox
            // 
            this.distanceUnitComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.distanceUnitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.distanceUnitComboBox.FormattingEnabled = true;
            this.distanceUnitComboBox.Items.AddRange(new object[] {
            "ft",
            "km",
            "m",
            "mi",
            "us-ft",
            "yd"});
            this.distanceUnitComboBox.Location = new System.Drawing.Point(191, 32);
            this.distanceUnitComboBox.Name = "distanceUnitComboBox";
            this.distanceUnitComboBox.Size = new System.Drawing.Size(121, 24);
            this.distanceUnitComboBox.TabIndex = 1;
            this.distanceUnitComboBox.SelectedIndexChanged += new System.EventHandler(this.DistanceUnitComboBox_SelectedIndexChanged);
            // 
            // gettingDistanceProgressBar
            // 
            this.gettingDistanceProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gettingDistanceProgressBar.Location = new System.Drawing.Point(3, 33);
            this.gettingDistanceProgressBar.MarqueeAnimationSpeed = 30;
            this.gettingDistanceProgressBar.Name = "gettingDistanceProgressBar";
            this.gettingDistanceProgressBar.Size = new System.Drawing.Size(182, 23);
            this.gettingDistanceProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.gettingDistanceProgressBar.TabIndex = 2;
            this.gettingDistanceProgressBar.Visible = false;
            // 
            // distanceLabel
            // 
            this.distanceLabel.AutoSize = true;
            this.distanceLabel.Location = new System.Drawing.Point(3, 35);
            this.distanceLabel.Name = "distanceLabel";
            this.distanceLabel.Size = new System.Drawing.Size(36, 17);
            this.distanceLabel.TabIndex = 3;
            this.distanceLabel.Text = "NaN";
            // 
            // GetDistanceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.distanceLabel);
            this.Controls.Add(this.gettingDistanceProgressBar);
            this.Controls.Add(this.distanceUnitComboBox);
            this.Controls.Add(this.getDistanceButton);
            this.Name = "GetDistanceControl";
            this.Size = new System.Drawing.Size(315, 411);
            this.Load += new System.EventHandler(this.GetDistanceControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getDistanceButton;
        private System.Windows.Forms.ComboBox distanceUnitComboBox;
        private System.Windows.Forms.ProgressBar gettingDistanceProgressBar;
        private System.Windows.Forms.Label distanceLabel;
    }
}

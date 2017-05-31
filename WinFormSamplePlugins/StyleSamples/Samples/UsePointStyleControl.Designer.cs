namespace SlimGis.Samples
{
    partial class UsePointStyleControl
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
            this.symbolTypeComboBox = new System.Windows.Forms.ComboBox();
            this.symbolSizeComboBox = new System.Windows.Forms.ComboBox();
            this.randomStyleButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // symbolTypeComboBox
            // 
            this.symbolTypeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.symbolTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.symbolTypeComboBox.FormattingEnabled = true;
            this.symbolTypeComboBox.Location = new System.Drawing.Point(2, 2);
            this.symbolTypeComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.symbolTypeComboBox.Name = "symbolTypeComboBox";
            this.symbolTypeComboBox.Size = new System.Drawing.Size(234, 21);
            this.symbolTypeComboBox.TabIndex = 0;
            this.symbolTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.SettingComboBox_SelectedIndexChanged);
            // 
            // symbolSizeComboBox
            // 
            this.symbolSizeComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.symbolSizeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.symbolSizeComboBox.FormattingEnabled = true;
            this.symbolSizeComboBox.Location = new System.Drawing.Point(2, 27);
            this.symbolSizeComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.symbolSizeComboBox.Name = "symbolSizeComboBox";
            this.symbolSizeComboBox.Size = new System.Drawing.Size(234, 21);
            this.symbolSizeComboBox.TabIndex = 1;
            this.symbolSizeComboBox.SelectedIndexChanged += new System.EventHandler(this.SettingComboBox_SelectedIndexChanged);
            // 
            // randomStyleButton
            // 
            this.randomStyleButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.randomStyleButton.Location = new System.Drawing.Point(2, 51);
            this.randomStyleButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.randomStyleButton.Name = "randomStyleButton";
            this.randomStyleButton.Size = new System.Drawing.Size(235, 24);
            this.randomStyleButton.TabIndex = 2;
            this.randomStyleButton.Text = "Random Style";
            this.randomStyleButton.UseVisualStyleBackColor = true;
            this.randomStyleButton.Click += new System.EventHandler(this.ReandomStyleButton_Click);
            // 
            // UsePointStyleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.randomStyleButton);
            this.Controls.Add(this.symbolSizeComboBox);
            this.Controls.Add(this.symbolTypeComboBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UsePointStyleControl";
            this.Size = new System.Drawing.Size(237, 325);
            this.Load += new System.EventHandler(this.UsePointStyleControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox symbolTypeComboBox;
        private System.Windows.Forms.ComboBox symbolSizeComboBox;
        private System.Windows.Forms.Button randomStyleButton;
    }
}

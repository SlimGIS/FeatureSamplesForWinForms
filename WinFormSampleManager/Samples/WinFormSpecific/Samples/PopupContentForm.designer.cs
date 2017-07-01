namespace SlimGis.Samples
{
    partial class PopupContentForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.poiIconComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.poiDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.poiNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // poiIconComboBox
            // 
            this.poiIconComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.poiIconComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.poiIconComboBox.FormattingEnabled = true;
            this.poiIconComboBox.Items.AddRange(new object[] {
            "Park",
            "Bank",
            "Sports"});
            this.poiIconComboBox.Location = new System.Drawing.Point(83, 66);
            this.poiIconComboBox.Name = "poiIconComboBox";
            this.poiIconComboBox.Size = new System.Drawing.Size(286, 24);
            this.poiIconComboBox.TabIndex = 0;
            this.poiIconComboBox.SelectedIndexChanged += new System.EventHandler(this.poiIconComboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.poiDescriptionTextBox);
            this.groupBox1.Controls.Add(this.poiNameTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.poiIconComboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 228);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "POI information";
            // 
            // poiDescriptionTextBox
            // 
            this.poiDescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.poiDescriptionTextBox.Location = new System.Drawing.Point(83, 96);
            this.poiDescriptionTextBox.Multiline = true;
            this.poiDescriptionTextBox.Name = "poiDescriptionTextBox";
            this.poiDescriptionTextBox.Size = new System.Drawing.Size(286, 126);
            this.poiDescriptionTextBox.TabIndex = 4;
            // 
            // poiNameTextBox
            // 
            this.poiNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.poiNameTextBox.Location = new System.Drawing.Point(83, 32);
            this.poiNameTextBox.Name = "poiNameTextBox";
            this.poiNameTextBox.Size = new System.Drawing.Size(286, 22);
            this.poiNameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name : ";
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(312, 246);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(231, 246);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // PopupContentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 281);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Text = "PopupContentForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox poiIconComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox poiNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox poiDescriptionTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button addButton;
    }
}
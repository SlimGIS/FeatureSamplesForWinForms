using System.Windows.Forms;

namespace SlimGis.Samples
{
    partial class SampleControl
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
            this.sampleLeftPanel = new System.Windows.Forms.Panel();
            this.sampleControlPanel = new System.Windows.Forms.Panel();
            this.sampleDescriptionPanel = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.viewSourceLinkLabel = new System.Windows.Forms.LinkLabel();
            this.sampleDescriptionLabel = new System.Windows.Forms.Label();
            this.sampleNameLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sampleMapContentPanel = new System.Windows.Forms.Panel();
            this.sampleLeftPanel.SuspendLayout();
            this.sampleDescriptionPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // sampleLeftPanel
            // 
            this.sampleLeftPanel.Controls.Add(this.sampleControlPanel);
            this.sampleLeftPanel.Controls.Add(this.sampleDescriptionPanel);
            this.sampleLeftPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.sampleLeftPanel.Location = new System.Drawing.Point(634, 0);
            this.sampleLeftPanel.Name = "sampleLeftPanel";
            this.sampleLeftPanel.Size = new System.Drawing.Size(332, 609);
            this.sampleLeftPanel.TabIndex = 0;
            // 
            // sampleControlPanel
            // 
            this.sampleControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sampleControlPanel.Location = new System.Drawing.Point(0, 177);
            this.sampleControlPanel.Name = "sampleControlPanel";
            this.sampleControlPanel.Padding = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.sampleControlPanel.Size = new System.Drawing.Size(332, 432);
            this.sampleControlPanel.TabIndex = 1;
            // 
            // sampleDescriptionPanel
            // 
            this.sampleDescriptionPanel.Controls.Add(this.panel4);
            this.sampleDescriptionPanel.Controls.Add(this.pictureBox1);
            this.sampleDescriptionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.sampleDescriptionPanel.Location = new System.Drawing.Point(0, 0);
            this.sampleDescriptionPanel.Name = "sampleDescriptionPanel";
            this.sampleDescriptionPanel.Size = new System.Drawing.Size(332, 177);
            this.sampleDescriptionPanel.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.viewSourceLinkLabel);
            this.panel4.Controls.Add(this.sampleDescriptionLabel);
            this.panel4.Controls.Add(this.sampleNameLabel);
            this.panel4.Location = new System.Drawing.Point(7, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(319, 161);
            this.panel4.TabIndex = 1;
            // 
            // viewSourceLinkLabel
            // 
            this.viewSourceLinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.viewSourceLinkLabel.AutoSize = true;
            this.viewSourceLinkLabel.Location = new System.Drawing.Point(9, 134);
            this.viewSourceLinkLabel.Name = "viewSourceLinkLabel";
            this.viewSourceLinkLabel.Size = new System.Drawing.Size(147, 17);
            this.viewSourceLinkLabel.TabIndex = 2;
            this.viewSourceLinkLabel.TabStop = true;
            this.viewSourceLinkLabel.Text = "View source on github";
            this.viewSourceLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.viewSourceLinkLabel_LinkClicked);
            // 
            // sampleDescriptionLabel
            // 
            this.sampleDescriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sampleDescriptionLabel.Location = new System.Drawing.Point(9, 35);
            this.sampleDescriptionLabel.Name = "sampleDescriptionLabel";
            this.sampleDescriptionLabel.Size = new System.Drawing.Size(300, 99);
            this.sampleDescriptionLabel.TabIndex = 1;
            this.sampleDescriptionLabel.Text = "label1";
            // 
            // sampleNameLabel
            // 
            this.sampleNameLabel.AutoSize = true;
            this.sampleNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sampleNameLabel.Location = new System.Drawing.Point(8, 9);
            this.sampleNameLabel.Name = "sampleNameLabel";
            this.sampleNameLabel.Size = new System.Drawing.Size(122, 20);
            this.sampleNameLabel.TabIndex = 0;
            this.sampleNameLabel.Text = "Sample name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Location = new System.Drawing.Point(19, 10);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(313, 157);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // sampleMapContentPanel
            // 
            this.sampleMapContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sampleMapContentPanel.Location = new System.Drawing.Point(0, 0);
            this.sampleMapContentPanel.Name = "sampleMapContentPanel";
            this.sampleMapContentPanel.Size = new System.Drawing.Size(634, 609);
            this.sampleMapContentPanel.TabIndex = 1;
            // 
            // SampleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.sampleMapContentPanel);
            this.Controls.Add(this.sampleLeftPanel);
            this.Name = "SampleControl";
            this.Size = new System.Drawing.Size(966, 609);
            this.sampleLeftPanel.ResumeLayout(false);
            this.sampleDescriptionPanel.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sampleLeftPanel;
        private System.Windows.Forms.Panel sampleMapContentPanel;
        private System.Windows.Forms.Panel sampleDescriptionPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel sampleControlPanel;
        private System.Windows.Forms.Label sampleNameLabel;
        private System.Windows.Forms.LinkLabel viewSourceLinkLabel;
        private System.Windows.Forms.Label sampleDescriptionLabel;
    }
}

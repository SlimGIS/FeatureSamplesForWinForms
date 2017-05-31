namespace SlimGis.Samples
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.sampleTreeView = new System.Windows.Forms.TreeView();
            this.sampleContentPanel = new System.Windows.Forms.Panel();
            this.loadPluginsFailLabel = new System.Windows.Forms.Label();
            this.fullScreenPictureBox = new System.Windows.Forms.PictureBox();
            this.loadingSamplePanel = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label2 = new System.Windows.Forms.Label();
            this.sampleViewShadowPictureBox = new System.Windows.Forms.PictureBox();
            this.sampleFooter = new SlimGis.ShareKit.Winforms.SampleFooter();
            this.sampleHeader = new SlimGis.ShareKit.Winforms.SampleHeader();
            this.sampleContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullScreenPictureBox)).BeginInit();
            this.loadingSamplePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sampleViewShadowPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sampleTreeView
            // 
            this.sampleTreeView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sampleTreeView.Location = new System.Drawing.Point(5, 84);
            this.sampleTreeView.Name = "sampleTreeView";
            this.sampleTreeView.Size = new System.Drawing.Size(283, 663);
            this.sampleTreeView.TabIndex = 2;
            this.sampleTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.sampleTreeView_AfterSelect);
            // 
            // sampleContentPanel
            // 
            this.sampleContentPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sampleContentPanel.BackColor = System.Drawing.Color.Transparent;
            this.sampleContentPanel.Controls.Add(this.loadPluginsFailLabel);
            this.sampleContentPanel.Controls.Add(this.fullScreenPictureBox);
            this.sampleContentPanel.Controls.Add(this.loadingSamplePanel);
            this.sampleContentPanel.Location = new System.Drawing.Point(300, 84);
            this.sampleContentPanel.Name = "sampleContentPanel";
            this.sampleContentPanel.Size = new System.Drawing.Size(1146, 670);
            this.sampleContentPanel.TabIndex = 3;
            // 
            // loadPluginsFailLabel
            // 
            this.loadPluginsFailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadPluginsFailLabel.AutoSize = true;
            this.loadPluginsFailLabel.Location = new System.Drawing.Point(239, 306);
            this.loadPluginsFailLabel.Name = "loadPluginsFailLabel";
            this.loadPluginsFailLabel.Size = new System.Drawing.Size(680, 17);
            this.loadPluginsFailLabel.TabIndex = 4;
            this.loadPluginsFailLabel.Text = "Cannot detect samples. Please make sure the sample assemblies are in the same fol" +
    "der of this executable.";
            this.loadPluginsFailLabel.Visible = false;
            // 
            // fullScreenPictureBox
            // 
            this.fullScreenPictureBox.BackColor = System.Drawing.Color.LightGray;
            this.fullScreenPictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fullScreenPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("fullScreenPictureBox.Image")));
            this.fullScreenPictureBox.Location = new System.Drawing.Point(0, 0);
            this.fullScreenPictureBox.Name = "fullScreenPictureBox";
            this.fullScreenPictureBox.Size = new System.Drawing.Size(40, 40);
            this.fullScreenPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.fullScreenPictureBox.TabIndex = 3;
            this.fullScreenPictureBox.TabStop = false;
            this.fullScreenPictureBox.Click += new System.EventHandler(this.fullScreenPictureBox_Click);
            // 
            // loadingSamplePanel
            // 
            this.loadingSamplePanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadingSamplePanel.Controls.Add(this.progressBar1);
            this.loadingSamplePanel.Controls.Add(this.label2);
            this.loadingSamplePanel.Location = new System.Drawing.Point(476, 310);
            this.loadingSamplePanel.Name = "loadingSamplePanel";
            this.loadingSamplePanel.Size = new System.Drawing.Size(200, 51);
            this.loadingSamplePanel.TabIndex = 2;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(3, 3);
            this.progressBar1.MarqueeAnimationSpeed = 30;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(194, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(0, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loading Samples ...";
            // 
            // sampleViewShadowPictureBox
            // 
            this.sampleViewShadowPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.sampleViewShadowPictureBox.BackColor = System.Drawing.Color.Gainsboro;
            this.sampleViewShadowPictureBox.Location = new System.Drawing.Point(12, 88);
            this.sampleViewShadowPictureBox.Name = "sampleViewShadowPictureBox";
            this.sampleViewShadowPictureBox.Size = new System.Drawing.Size(282, 666);
            this.sampleViewShadowPictureBox.TabIndex = 1;
            this.sampleViewShadowPictureBox.TabStop = false;
            // 
            // sampleFooter
            // 
            this.sampleFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sampleFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.sampleFooter.Location = new System.Drawing.Point(0, 761);
            this.sampleFooter.Margin = new System.Windows.Forms.Padding(0);
            this.sampleFooter.Name = "sampleFooter";
            this.sampleFooter.Size = new System.Drawing.Size(1455, 53);
            this.sampleFooter.TabIndex = 5;
            // 
            // sampleHeader
            // 
            this.sampleHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sampleHeader.BackColor = System.Drawing.Color.Black;
            this.sampleHeader.Location = new System.Drawing.Point(0, 0);
            this.sampleHeader.Name = "sampleHeader";
            this.sampleHeader.Size = new System.Drawing.Size(1455, 80);
            this.sampleHeader.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1452, 814);
            this.Controls.Add(this.sampleHeader);
            this.Controls.Add(this.sampleFooter);
            this.Controls.Add(this.sampleContentPanel);
            this.Controls.Add(this.sampleTreeView);
            this.Controls.Add(this.sampleViewShadowPictureBox);
            this.Name = "MainForm";
            this.Text = "SlimGis MapKit Samples for WinForms";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.sampleContentPanel.ResumeLayout(false);
            this.sampleContentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullScreenPictureBox)).EndInit();
            this.loadingSamplePanel.ResumeLayout(false);
            this.loadingSamplePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sampleViewShadowPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox sampleViewShadowPictureBox;
        private System.Windows.Forms.TreeView sampleTreeView;
        private System.Windows.Forms.Panel sampleContentPanel;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel loadingSamplePanel;
        private System.Windows.Forms.PictureBox fullScreenPictureBox;
        private System.Windows.Forms.Label loadPluginsFailLabel;
        private ShareKit.Winforms.SampleFooter sampleFooter;
        private ShareKit.Winforms.SampleHeader sampleHeader;
    }
}


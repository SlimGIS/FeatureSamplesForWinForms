using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SlimGis.Samples
{
    public partial class SampleControl : UserControl
    {
        private readonly int leftPanelWidth;

        public SampleControl()
        {
            InitializeComponent();
            leftPanelWidth = sampleLeftPanel.Width;
        }

        public Panel MapContent
        {
            get { return sampleMapContentPanel; }
        }

        public Panel ControlContent
        {
            get { return sampleControlPanel; }
        }

        public string SampleName
        {
            get { return sampleNameLabel.Text; }
            set { sampleNameLabel.Text = value; }
        }

        public string SampleDescription
        {
            get { return sampleDescriptionLabel.Text; }
            set { sampleDescriptionLabel.Text = value; }
        }

        public Uri SourceUri { get; set; }

        public void ExitFullScreen()
        {
            sampleLeftPanel.Width = leftPanelWidth;
            sampleLeftPanel.Visible = true;
        }

        public void FullScreen()
        {
            sampleLeftPanel.Width = 0;
            sampleLeftPanel.Visible = false;
        }

        private void viewSourceLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(SourceUri.AbsoluteUri);
        }
    }
}

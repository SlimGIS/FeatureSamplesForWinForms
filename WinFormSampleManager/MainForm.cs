using System;
using System.Windows.Forms;
using SlimGis.Samples.Properties;
using System.ComponentModel;
using System.Linq;

namespace SlimGis.Samples
{
    public partial class MainForm : Form
    {
        private bool isSampleFullScreen;
        private SampleModel currentSample;

        public MainForm()
        {
            InitializeComponent();
            GlobalResources.Instance.PropertyChanged += Instance_PropertyChanged;
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await GlobalResources.Instance.LoadAsync();
        }

        private void Instance_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(GlobalResources.Instance.ListPanelVisiable):
                    sampleTreeView.Visible = GlobalResources.Instance.ListPanelVisiable;
                    sampleViewShadowPictureBox.Visible = GlobalResources.Instance.ListPanelVisiable;
                    break;

                case nameof(GlobalResources.Instance.LoadingBarVisiable):
                    loadingSamplePanel.Visible = GlobalResources.Instance.LoadingBarVisiable;
                    if (!loadingSamplePanel.Visible)
                    {
                        foreach (var item in GlobalResources.Instance.Samples)
                        {
                            TreeNode[] children = item.Samples.Select(s => new TreeNode(s.Name) { Tag = s }).ToArray();
                            TreeNode treeNode = new TreeNode(item.Name, children);
                            treeNode.Tag = item;
                            sampleTreeView.Nodes.Add(treeNode);
                        }
                        var currentSample = GlobalResources.Instance.Samples.SelectMany(category => category.Samples).OfType<SampleModel>().FirstOrDefault();
                        SelectNewSample(currentSample);
                    }
                    break;

                case nameof(GlobalResources.Instance.LoadSamplesFailedVisiable):
                    loadPluginsFailLabel.Visible = GlobalResources.Instance.LoadSamplesFailedVisiable;
                    break;

                default:
                    break;
            }
        }

        private void SelectNewSample(SampleModel newSample)
        {
            if (newSample == currentSample) return;
            if (currentSample?.SampleControl != null) sampleContentPanel.Controls.Remove(currentSample.SampleControl);
            if (newSample != null)
            {
                newSample.SampleControl.Location = new System.Drawing.Point(0, 0);
                newSample.SampleControl.Width = sampleContentPanel.Width;
                newSample.SampleControl.Height = sampleContentPanel.Height;
                newSample.SampleControl.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
                sampleContentPanel.Controls.Add(newSample.SampleControl);
            }
            currentSample?.Reset();
            currentSample = newSample;
        }

        private void fullScreenPictureBox_Click(object sender, EventArgs e)
        {
            isSampleFullScreen = !isSampleFullScreen;
            if (currentSample != null) currentSample.IsFullScreen = isSampleFullScreen;

            bool viewVisible = !isSampleFullScreen;
            sampleHeader.Visible = viewVisible;
            sampleFooter.Visible = viewVisible;
            sampleTreeView.Visible = viewVisible;
            sampleViewShadowPictureBox.Visible = viewVisible;
            sampleContentPanel.Dock = viewVisible ? DockStyle.None : DockStyle.Fill;
            fullScreenPictureBox.Image = viewVisible ? Resources.fullscreen : Resources.fullscreen_exit;

            if (sampleContentPanel.Dock == DockStyle.None)
            {
                sampleContentPanel.Height = sampleViewShadowPictureBox.Height + sampleViewShadowPictureBox.Location.Y - sampleContentPanel.Location.Y;
                sampleContentPanel.Width = sampleHeader.Width - sampleContentPanel.Location.X - 4;
                sampleContentPanel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            }
        }

        private void sampleTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            SampleModel tempSampleModel = e.Node.Tag as SampleModel;
            if (tempSampleModel != null)
            {
                SelectNewSample(tempSampleModel);
                return;
            }

            SampleCategoryPlugin tempSampleCategoryPlugin = e.Node.Tag as SampleCategoryPlugin;
            if (tempSampleCategoryPlugin != null) SelectNewSample(tempSampleCategoryPlugin.Samples.FirstOrDefault());
        }
    }
}

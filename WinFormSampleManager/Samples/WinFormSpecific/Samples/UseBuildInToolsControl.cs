using SlimGis.MapKit.Geometries;
using SlimGis.MapKit.Layers;
using SlimGis.MapKit.WinForms;
using System;
using System.Windows.Forms;

namespace SlimGis.Samples
{
    public partial class UseBuildInToolsControl : UserControl
    {
        private BuildInToolsMapContentControl mapContent;

        public UseBuildInToolsControl()
        {
            InitializeComponent();
            mapContent = new BuildInToolsMapContentControl();
            scaleBarCheckBox.Checked = MapContent.ScaleBar.Visible;
            zoomBarCheckBox.Checked = MapContent.ZoomBar.Visible;
            viewportBlockCheckBox.Checked = MapContent.ViewportBlock.Visible;
        }

        public BuildInToolsMapContentControl MapContent => mapContent;

        private void UseBuildInToolsControl_Load(object sender, EventArgs e)
        {
            MapContent.Map.MapUnit = GeoUnit.Meter;

            LayerOverlay staticOverlay = new LayerOverlay { Name = "Static Overlay" };
            staticOverlay.Layers.Add(new OpenStreetMapLayer());
            MapContent.Map.Overlays.Add(staticOverlay);

            MapContent.Map.ZoomToFullBound();
        }

        private void SettingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == scaleBarCheckBox) MapContent.ScaleBar.Visible = scaleBarCheckBox.Checked;
            else if (sender == zoomBarCheckBox) MapContent.ZoomBar.Visible = zoomBarCheckBox.Checked;
            else if (sender == viewportBlockCheckBox) MapContent.ViewportBlock.Visible = viewportBlockCheckBox.Checked;
        }
    }
}

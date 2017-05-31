using SlimGis.MapKit.Geometries;
using SlimGis.MapKit.Layers;
using SlimGis.MapKit.Symbologies;
using SlimGis.MapKit.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SlimGis.Samples
{
    public partial class UseOverlaysControl : UserControl
    {
        private MapControl mapContent;

        public UseOverlaysControl()
        {
            InitializeComponent();
            mapContent = new MapControl();
        }

        public MapControl MapContent => mapContent;

        private void UseOverlaysControl_Load(object sender, EventArgs e)
        {
            MapContent.MapUnit = GeoUnit.Meter;

            LayerOverlay staticOverlay = new LayerOverlay { Name = "Static Overlay" };
            staticOverlay.Layers.Add(new OpenStreetMapLayer());
            MapContent.Overlays.Add(staticOverlay);

            ShapefileLayer dynamicLayer = new ShapefileLayer("SampleData/countries-900913.shp");
            dynamicLayer.Styles.Add(new FillStyle(GeoColor.FromHtml("#55FAB04D"), GeoColors.White));

            LayerOverlay dynamicOverlay = new LayerOverlay { Name = "Dynamic Overlay" };
            dynamicOverlay.Layers.Add(dynamicLayer);
            MapContent.Overlays.Add(dynamicOverlay);

            MapContent.ZoomToFullBound();

            for (int i = 0; i < MapContent.Overlays.Count; i++)
            {
                Overlay overlay = MapContent.Overlays[i];
                CheckBox overlayCheckBox = new CheckBox();
                overlayCheckBox.Text = overlay.Name;
                overlayCheckBox.TextAlign = ContentAlignment.MiddleLeft;
                overlayCheckBox.Location = new Point(3, 39 + i * 25);
                overlayCheckBox.Checked = overlay.IsVisible;
                Controls.Add(overlayCheckBox);

                overlayCheckBox.CheckedChanged += delegate { overlay.IsVisible = overlayCheckBox.Checked; };
            }
        }

        private void randomStyleButton_Click(object sender, EventArgs e)
        {
            FeatureLayer featureLayer = MapContent.FindLayer<FeatureLayer>("countries-900913");
            featureLayer.UseRandomStyle();
            MapContent.Refresh("Dynamic Overlay");
        }
    }
}

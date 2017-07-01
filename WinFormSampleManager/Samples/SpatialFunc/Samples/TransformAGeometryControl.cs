using SlimGis.MapKit.Geometries;
using SlimGis.MapKit.Layers;
using SlimGis.MapKit.Symbologies;
using SlimGis.MapKit.WinForms;
using System;
using System.Windows.Forms;

namespace SlimGis.Samples
{
    public partial class TransformAGeometryControl : UserControl
    {
        private MapControl mapContent;
        private Feature highlightFeature;
        private Feature transformingFeature;

        public TransformAGeometryControl()
        {
            InitializeComponent();
            mapContent = new MapControl();
        }

        public MapControl MapContent => mapContent;

        private void TransformAGeometryControl_Load(object sender, EventArgs e)
        {
            MapContent.MapUnit = GeoUnit.Meter;
            MapContent.UseOpenStreetMapAsBaseMap();

            ShapefileSource dataSource = new ShapefileSource("SampleData/countries-900913.shp");
            dataSource.Open();
            highlightFeature = dataSource.GetFeatureById("1", RequireColumnsType.None);
            transformingFeature = highlightFeature.Clone();

            MemoryLayer highlightLayer = new MemoryLayer();
            highlightLayer.Features.Add(transformingFeature);
            highlightLayer.Styles.Add(new FillStyle(GeoColor.FromHtml("#55FAB04D")));
            MapContent.AddDynamicLayers("HighlightOverlay", highlightLayer);

            MapContent.ZoomTo(highlightFeature);
        }

        private void ScaleUpButton_Click(object sender, EventArgs e)
        {
            transformingFeature.Geometry.ScaleUp(10);
            MapContent.Refresh("HighlightOverlay");
        }

        private void ScaleDownButton_Click(object sender, EventArgs e)
        {
            transformingFeature.Geometry.ScaleDown(10);
            MapContent.Refresh("HighlightOverlay");
        }

        private void RotateButton_Click(object sender, EventArgs e)
        {
            transformingFeature.Geometry.Rotate(10);
            MapContent.Refresh("HighlightOverlay");
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            transformingFeature.Geometry = highlightFeature.Geometry.Clone();
            MapContent.Refresh("HighlightOverlay");
        }
    }
}

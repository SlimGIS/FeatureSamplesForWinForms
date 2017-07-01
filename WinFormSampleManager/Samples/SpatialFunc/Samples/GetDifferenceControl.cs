using SlimGis.MapKit.Geometries;
using SlimGis.MapKit.Layers;
using SlimGis.MapKit.Symbologies;
using SlimGis.MapKit.WinForms;
using System;
using System.Windows.Forms;

namespace SlimGis.Samples
{
    public partial class GetDifferenceControl : UserControl
    {
        private Feature highlightFeature;
        private Feature highlightBoundFeature;
        private MapControl mapContent;

        public GetDifferenceControl()
        {
            InitializeComponent();
            mapContent = new MapControl();
        }

        public MapControl MapContent => mapContent;

        private void GetDifferenceControl_Load(object sender, EventArgs e)
        {
            MapContent.MapUnit = GeoUnit.Meter;
            MapContent.UseOpenStreetMapAsBaseMap();

            ShapefileSource dataSource = new ShapefileSource("SampleData/countries-900913.shp");
            dataSource.Open();
            highlightFeature = dataSource.GetFeatureById("1", RequireColumnsType.None);

            GeoBound highlightBound = highlightFeature.GetBound();
            highlightBoundFeature = new Feature(highlightBound);

            MemoryLayer highlightLayer = new MemoryLayer() { Name = "HighlightLayer" };
            highlightLayer.Features.Add(highlightFeature);
            highlightLayer.Features.Add(highlightBoundFeature);
            highlightLayer.Styles.Add(new FillStyle(GeoColor.FromHtml("#55FAB04D")));
            highlightLayer.Styles.Add(new LineStyle(GeoColor.FromHtml("#00BCD4"), 4));
            MapContent.AddStaticLayers("HighlightOverlay", highlightLayer);

            MemoryLayer resultLayer = new MemoryLayer { Name = "ResultLayer" };
            resultLayer.Styles.Add(new FillStyle(GeoColor.FromHtml("#55FAB04D"), GeoColors.White));
            MapContent.AddDynamicLayers("ResultOverlay", resultLayer);

            MapContent.ZoomTo(highlightFeature);
        }

        private void GetDifferenceButton_Click(object sender, EventArgs e)
        {
            MemoryLayer resultLayer = MapContent.FindLayer<MemoryLayer>("ResultLayer");

            if (resultLayer.Features.Count == 0)
            {
                MapContent.FindLayer<MemoryLayer>("HighlightLayer").Features.Clear();

                Geometry difference = highlightBoundFeature.Geometry.GetDifference(highlightFeature.Geometry);
                resultLayer.Features.Add(new Feature(difference));
                MapContent.Refresh("HighlightOverlay", "ResultOverlay");
            }
        }
    }
}

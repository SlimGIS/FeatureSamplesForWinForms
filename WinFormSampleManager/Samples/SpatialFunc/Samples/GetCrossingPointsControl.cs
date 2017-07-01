using SlimGis.MapKit.Geometries;
using SlimGis.MapKit.Layers;
using SlimGis.MapKit.Symbologies;
using SlimGis.MapKit.WinForms;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows.Forms;

namespace SlimGis.Samples
{
    public partial class GetCrossingPointsControl : UserControl
    {
        private Feature highlightFeature;
        private Feature crossLineFeature;
        private MapControl mapContent;

        public GetCrossingPointsControl()
        {
            InitializeComponent();
            mapContent = new MapControl();
        }

        public MapControl MapContent => mapContent;

        private void GetCrossingPointsControl_Load(object sender, EventArgs e)
        {
            MapContent.MapUnit = GeoUnit.Meter;
            MapContent.UseOpenStreetMapAsBaseMap();

            ShapefileSource dataSource = new ShapefileSource("SampleData/countries-900913.shp");
            dataSource.Open();
            highlightFeature = dataSource.GetFeatureById("1", RequireColumnsType.None);

            GeoBound tempBound = highlightFeature.GetBound();
            tempBound.ScaleDown(20);
            crossLineFeature = new Feature(new GeoLine(tempBound.GetVertices().Skip(1)));

            MemoryLayer highlightLayer = new MemoryLayer();
            highlightLayer.Features.Add(highlightFeature);
            highlightLayer.Features.Add(crossLineFeature);
            highlightLayer.Styles.Add(new FillStyle(GeoColor.FromHtml("#55FAB04D")));
            highlightLayer.Styles.Add(new LineStyle(GeoColor.FromHtml("#00BCD4"), 4));
            MapContent.AddStaticLayers("HighlightOverlay", highlightLayer);

            MemoryLayer resultLayer = new MemoryLayer { Name = "ResultLayer" };
            resultLayer.Styles.Add(new SymbolStyle(SymbolType.Circle, GeoColor.FromHtml("#99FF5722"), GeoColors.White));
            MapContent.AddDynamicLayers("ResultOverlay", resultLayer);

            MapContent.ZoomTo(highlightFeature);
        }

        private void getCrossingButton_Click(object sender, EventArgs e)
        {
            MemoryLayer resultLayer = MapContent.FindLayer<MemoryLayer>("ResultLayer");

            if (resultLayer.Features.Count == 0)
            {
                Collection<GeoPoint> crossingPoints = highlightFeature.Geometry.GetCrossing(crossLineFeature.Geometry);
                resultLayer.Features.AddRange(crossingPoints.Select(p => new Feature(p)));
                MapContent.Refresh("ResultOverlay");
            }
        }
    }
}

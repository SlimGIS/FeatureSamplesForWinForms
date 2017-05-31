using SlimGis.MapKit.Geometries;
using SlimGis.MapKit.Layers;
using SlimGis.MapKit.Symbologies;
using SlimGis.MapKit.WinForms;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlimGis.Samples
{
    public partial class GetShortestLineControl : UserControl
    {
        private Feature feature1;
        private Feature feature2;
        private MapControl mapContent;

        public GetShortestLineControl()
        {
            InitializeComponent();
            mapContent = new MapControl();
        }

        public MapControl MapContent => mapContent;

        private void GetShortestLineControl_Load(object sender, EventArgs e)
        {
            MapContent.MapUnit = GeoUnit.Meter;
            MapContent.UseOpenStreetMapAsBaseMap();

            ShapefileSource dataSource = new ShapefileSource("SampleData/countries-900913.shp");
            dataSource.Open();
            feature1 = new Feature(dataSource.GetFeatureById("1", RequireColumnsType.None).GetBound());
            feature2 = new Feature(dataSource.GetFeatureById("10", RequireColumnsType.None).GetBound());

            MemoryLayer highlightLayer = new MemoryLayer();
            highlightLayer.Features.Add(feature1);
            highlightLayer.Features.Add(feature2);
            highlightLayer.Styles.Add(new FillStyle(GeoColor.FromHtml("#55FAB04D")));
            MapContent.AddStaticLayers("HighlightOverlay", highlightLayer);

            MemoryLayer resultLayer = new MemoryLayer { Name = "ResultLayer" };
            resultLayer.Styles.Add(new LineStyle(GeoColor.FromHtml("#00BCD4"), 4));
            resultLayer.Styles.Add(new SymbolStyle(SymbolType.Circle, GeoColor.FromHtml("#99FF5722"), GeoColors.White));
            MapContent.AddDynamicLayers("ResultOverlay", resultLayer);

            MapContent.ZoomTo(GeoBound.CreateToInclude(new[] { feature1, feature2 }));
        }

        private async void GetShortestLineButton_Click(object sender, EventArgs e)
        {
            MemoryLayer resultLayer = MapContent.FindLayer<MemoryLayer>("ResultLayer");
            if (resultLayer.Features.Count == 0)
            {
                GeoMultiLine shortestResult = await Task.Run(() => feature1.Geometry.GetShortestLineTo(feature2.Geometry));
                GeoLine shortestLine = shortestResult.Lines.First();

                resultLayer.Features.Add(new Feature(shortestLine));
                resultLayer.Features.Add(new Feature(new GeoPoint(shortestLine.Coordinates.First())));
                resultLayer.Features.Add(new Feature(new GeoPoint(shortestLine.Coordinates.Last())));
                MapContent.Refresh("ResultOverlay");
            }
        }
    }
}

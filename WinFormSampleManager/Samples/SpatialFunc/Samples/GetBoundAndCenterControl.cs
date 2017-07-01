using SlimGis.MapKit.Geometries;
using SlimGis.MapKit.Layers;
using SlimGis.MapKit.Symbologies;
using SlimGis.MapKit.Utilities;
using SlimGis.MapKit.WinForms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SlimGis.Samples
{
    public partial class GetBoundAndCenterControl : UserControl
    {
        private ShapefileLayer dataLayer;
        private MapControl mapContent;

        public GetBoundAndCenterControl()
        {
            InitializeComponent();
            mapContent = new MapControl();
            mapContent.MapClick += MapContent_MapClick;
        }

        public MapControl MapContent => mapContent;

        private void GetBoundAndCenterControl_Load(object sender, EventArgs e)
        {
            MapContent.MapUnit = GeoUnit.Meter;
            MapContent.UseOpenStreetMapAsBaseMap();

            dataLayer = new ShapefileLayer("SampleData/countries-900913.shp");
            dataLayer.Open();

            GeoPen outlinePen = new GeoPen(GeoColor.FromHtml("#00BCD4"), 2) { DashPattern = new float[] { 4, 4 } };

            MemoryLayer highlightLayer = new MemoryLayer { Name = "HighlightLayer" };
            highlightLayer.Styles.Add(new FillStyle(GeoColor.FromHtml("#55FAB04D")));
            highlightLayer.Styles.Add(new LineStyle(outlinePen));
            highlightLayer.Styles.Add(new SymbolStyle(SymbolType.Circle, GeoColor.FromHtml("#99FF5722"), GeoColors.White));
            MapContent.AddDynamicLayers("HighlightOverlay", highlightLayer);

            MapContent.ZoomTo(new GeoBound(2171997.6512, 8356849.2669, 3515687.9933, 11097616.86));
        }

        private void MapContent_MapClick(object sender, MapMouseEventArgs e)
        {
            Feature identifiedFeature = IdentifyHelper.Identify(dataLayer, e.WorldCoordinate, MapContent.CurrentScale, MapContent.MapUnit).FirstOrDefault();
            if (identifiedFeature != null)
            {
                MemoryLayer highlightLayer = MapContent.FindLayer<MemoryLayer>("HighlightLayer");

                highlightLayer.Features.Clear();
                highlightLayer.Features.Add(identifiedFeature);

                GeoBound identifiedBound = identifiedFeature.GetBound();
                highlightLayer.Features.Add(new Feature(new GeoLine(identifiedBound.GetVertices())));

                GeoPoint identifiedCenter = identifiedBound.GetCentroid();
                highlightLayer.Features.Add(new Feature(identifiedCenter));

                MapContent.Refresh("HighlightOverlay");
            }
        }
    }
}

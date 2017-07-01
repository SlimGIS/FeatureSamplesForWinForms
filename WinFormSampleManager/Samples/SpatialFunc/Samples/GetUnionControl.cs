using SlimGis.MapKit.Geometries;
using SlimGis.MapKit.Layers;
using SlimGis.MapKit.Symbologies;
using SlimGis.MapKit.WinForms;
using System;
using System.Windows.Forms;

namespace SlimGis.Samples
{
    public partial class GetUnionControl : UserControl
    {
        private Feature feature1;
        private Feature feature2;
        private MapControl mapContent;

        public GetUnionControl()
        {
            InitializeComponent();
            mapContent = new MapControl();
        }

        public MapControl MapContent => mapContent;

        private void GetUnionControl_Load(object sender, EventArgs e)
        {
            MapContent.MapUnit = GeoUnit.Meter;
            MapContent.UseOpenStreetMapAsBaseMap();

            GeoBound bound = new GeoBound(2171997.6512, 8356849.2669, 3515687.9933, 11097616.86);
            GeoPoint center = bound.GetCentroid();
            double x1 = bound.MinX + bound.Width * .25;
            double y = center.Y;
            double x2 = bound.MaxX - bound.Width * .25;
            double radius = bound.Width * 3 / 8;

            feature1 = new Feature(new GeoEllipse(new GeoPoint(x1, y), radius));
            feature2 = new Feature(new GeoEllipse(new GeoPoint(x2, y), radius));

            MemoryLayer highlightLayer = new MemoryLayer { Name = "HighlightLayer" };
            highlightLayer.Features.Add(feature1);
            highlightLayer.Features.Add(feature2);
            highlightLayer.Styles.Add(new FillStyle(GeoColor.FromHtml("#55FAB04D"), GeoColors.White));
            MapContent.AddStaticLayers("HighlightOverlay", highlightLayer);

            MemoryLayer resultLayer = new MemoryLayer { Name = "ResultLayer" };
            resultLayer.Styles.Add(new FillStyle(GeoColor.FromHtml("#55FAB04D"), GeoColors.White));
            MapContent.AddDynamicLayers("ResultOverlay", resultLayer);

            MapContent.ZoomTo(bound);
        }

        private void GetUnionButton_Click(object sender, EventArgs e)
        {
            MemoryLayer resultLayer = MapContent.FindLayer<MemoryLayer>("ResultLayer");

            if (resultLayer.Features.Count == 0)
            {
                MapContent.FindLayer<MemoryLayer>("HighlightLayer").Features.Clear();

                GeoAreaBase unionResult = ((GeoAreaBase)feature1.Geometry).Union((GeoAreaBase)feature2.Geometry);
                resultLayer.Features.Add(new Feature(unionResult));
                MapContent.Refresh("HighlightOverlay", "ResultOverlay");
            }
        }
    }
}

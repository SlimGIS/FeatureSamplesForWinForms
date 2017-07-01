using SlimGis.MapKit.Geometries;
using SlimGis.MapKit.Layers;
using SlimGis.MapKit.Symbologies;
using SlimGis.MapKit.WinForms;
using System;
using System.Windows.Forms;

namespace SlimGis.Samples
{
    public partial class GetConvexHullControl : UserControl
    {
        private Feature highlightFeature;
        private MapControl mapContent;

        public GetConvexHullControl()
        {
            InitializeComponent();
            mapContent = new MapControl();
        }

        public MapControl MapContent => mapContent;

        private void GetConvexHullControl_Load(object sender, EventArgs e)
        {
            MapContent.MapUnit = GeoUnit.Meter;
            MapContent.UseOpenStreetMapAsBaseMap();

            ShapefileSource dataSource = new ShapefileSource("SampleData/countries-900913.shp");
            dataSource.Open();
            highlightFeature = dataSource.GetFeatureById("1", RequireColumnsType.None);

            MemoryLayer bufferedLayer = new MemoryLayer { Name = "BufferResultLayer" };
            bufferedLayer.Styles.Add(new FillStyle(GeoColor.FromHtml("#553F8CB4"), GeoColors.White));
            MapContent.AddDynamicLayers("BufferedOverlay", bufferedLayer);

            MemoryLayer highlightLayer = new MemoryLayer();
            highlightLayer.Features.Add(highlightFeature);
            highlightLayer.Styles.Add(new FillStyle(GeoColor.FromHtml("#55FAB04D")));
            MapContent.AddStaticLayers("HighlightOverlay", highlightLayer);

            MapContent.ZoomTo(highlightFeature);
        }

        private void GetConvexHullButton_Click(object sender, EventArgs e)
        {
            MemoryLayer bufferResultLayer = MapContent.FindLayer<MemoryLayer>("BufferResultLayer");
            if (bufferResultLayer.Features.Count == 0)
            {
                Feature bufferedFeature = new Feature(highlightFeature.Geometry.GetConvexHull());
                bufferResultLayer.Features.Add(bufferedFeature);
                MapContent.Refresh("BufferedOverlay");
            }
        }
    }
}

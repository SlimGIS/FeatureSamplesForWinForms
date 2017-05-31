using SlimGis.MapKit.Geometries;
using SlimGis.MapKit.Layers;
using SlimGis.MapKit.Symbologies;
using SlimGis.MapKit.WinForms;
using System.Windows.Forms;

namespace SlimGis.Samples
{
    public partial class MemoryLayerControl : UserControl
    {
        private MapControl mapContent;

        public MemoryLayerControl()
        {
            InitializeComponent();
            mapContent = new MapControl();
        }

        public MapControl MapContent => mapContent;

        private void MemoryLayerControl_Load(object sender, System.EventArgs e)
        {
            MapContent.MapUnit = GeoUnit.Meter;
            MapContent.UseOpenStreetMapAsBaseMap();

            ShapefileSource dataSource = new ShapefileSource("SampleData/countries-900913.shp");
            Feature tempFeature = dataSource.GetFeatureById("1", RequireColumnsType.None);

            MemoryLayer memoryLayer = new MemoryLayer { Name = "ResultLayer" };
            memoryLayer.Styles.Add(new FillStyle(GeoColor.FromHtml("#55FAB04D"), GeoColors.White));
            memoryLayer.Features.Add(tempFeature);

            LayerOverlay layerOverlay = new LayerOverlay();
            layerOverlay.Layers.Add(memoryLayer);
            MapContent.Overlays.Add(layerOverlay);

            MapContent.ZoomTo(tempFeature);
        }
    }
}

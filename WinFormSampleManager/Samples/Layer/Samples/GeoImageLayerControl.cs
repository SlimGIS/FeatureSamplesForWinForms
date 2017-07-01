using SlimGis.MapKit.Geometries;
using SlimGis.MapKit.Layers;
using SlimGis.MapKit.Symbologies;
using SlimGis.MapKit.Utilities;
using SlimGis.MapKit.WinForms;
using System;
using System.Windows.Forms;

namespace SlimGis.Samples
{
    public partial class GeoImageLayerControl : UserControl
    {
        private MapControl mapContent;

        public GeoImageLayerControl()
        {
            InitializeComponent();
            mapContent = new MapControl();
        }

        public MapControl MapContent => mapContent;

        private void GeoImageLayerControl_Load(object sender, EventArgs e)
        {
            MapContent.MapUnit = GeoUnit.Meter;

            GeoImage image = new GeoImage(@"SampleData/bing-aerial-900913.png") { Bound = GeoCommonHelper.GetMaxBound(GeoUnit.Meter) };
            GeoImageLayer geoImageLayer = new GeoImageLayer(image);

            LayerOverlay layerOverlay = new LayerOverlay();
            layerOverlay.Layers.Add(geoImageLayer);
            MapContent.Overlays.Add(layerOverlay);
            MapContent.ZoomToFullBound();
        }
    }
}

using SlimGis.MapKit.Geometries;
using SlimGis.MapKit.Layers;
using SlimGis.MapKit.WinForms;
using System;
using System.Windows.Forms;

namespace SlimGis.Samples
{
    public partial class WmsLayerControl : UserControl
    {
        private MapControl mapContent;

        public WmsLayerControl()
        {
            InitializeComponent();
            mapContent = new MapControl();
        }

        public MapControl MapContent => mapContent;

        private void WmsLayerControl_Load(object sender, EventArgs e)
        {
            MapContent.MapUnit = GeoUnit.Meter;
            MapContent.UseOpenStreetMapAsBaseMap();

            WmsLayer wmsLayer = new WmsLayer("https://ahocevar.com/geoserver/wms");
            wmsLayer.Name = "Wms";
            wmsLayer.Crs = "EPSG:900913";
            wmsLayer.Layers.Add("topp:states");
            wmsLayer.Parameters.Add("TILED", "TRUE");

            LayerOverlay layerOverlay = new LayerOverlay();
            layerOverlay.Layers.Add(wmsLayer);
            MapContent.Overlays.Add(layerOverlay);

            MapContent.ZoomToFullBound();
        }
    }
}

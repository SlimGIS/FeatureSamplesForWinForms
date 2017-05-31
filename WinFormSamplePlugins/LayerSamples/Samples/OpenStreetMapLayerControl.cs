using SlimGis.MapKit.Geometries;
using SlimGis.MapKit.Layers;
using SlimGis.MapKit.WinForms;
using System;
using System.Windows.Forms;

namespace SlimGis.Samples
{
    public partial class OpenStreetMapLayerControl : UserControl
    {
        private MapControl mapContent;

        public OpenStreetMapLayerControl()
        {
            InitializeComponent();
            mapContent = new MapControl();
        }

        public MapControl MapContent => mapContent;

        private void OpenStreetMapLayerControl_Load(object sender, EventArgs e)
        {
            MapContent.MapUnit = GeoUnit.Meter;

            OpenStreetMapLayer openStreetMapLayer = new OpenStreetMapLayer();
            LayerOverlay layerOverlay = new LayerOverlay();
            layerOverlay.Layers.Add(openStreetMapLayer);
            MapContent.Overlays.Add(layerOverlay);

            // We can also use the code below to add a google maps to our map.
            // Map1.UseOpenStreetMapAsBaseMap();

            MapContent.ZoomToFullBound();
        }
    }
}

using SlimGis.MapKit.Controls;
using SlimGis.MapKit.Geometries;
using SlimGis.MapKit.Layers;
using SlimGis.MapKit.Symbologies;
using SlimGis.MapKit.WinForms;
using System;
using System.Windows.Forms;

namespace SlimGis.Samples
{
    public partial class GoogleMapsLayerControl : UserControl
    {
        private MapControl mapContent;

        public GoogleMapsLayerControl()
        {
            InitializeComponent();
            mapContent = new MapControl();
            layerTypeComboBox.SelectedIndex = 0;
        }

        public MapControl MapContent => mapContent;

        private void GoogleMapsLayerControl_Load(object sender, EventArgs e)
        {
            MapContent.MapUnit = GeoUnit.Meter;

            GoogleMapsLayer googleMapsLayer = new GoogleMapsLayer(GoogleMapsType.RoadMap, "AIzaSyC2CYaFRRi-Caf24Lq_2xu5seA3EzLWKv0");
            LayerOverlay layerOverlay = new LayerOverlay();
            layerOverlay.Layers.Add(googleMapsLayer);
            MapContent.Overlays.Add(layerOverlay);

            // We can also use the code below to add a google maps to our map.
            // Map1.UseGoogleMapsAsBaseMap(GoogleMapsType.RoadMap, "Your api key", "Your client id");

            MapContent.ZoomToFullBound();
        }

        private void layerTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            GoogleMapsLayer gooleMapsLayer = MapContent.FindLayer<GoogleMapsLayer>("Google Maps");
            if (gooleMapsLayer != null)
            {
                gooleMapsLayer.MapsType = (GoogleMapsType)layerTypeComboBox.SelectedIndex;
                MapContent.Refresh(RefreshType.Redraw);
            }
        }
    }
}

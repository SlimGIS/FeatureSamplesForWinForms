using SlimGis.MapKit.Controls;
using SlimGis.MapKit.Geometries;
using SlimGis.MapKit.Layers;
using SlimGis.MapKit.WinForms;
using System;
using System.Windows.Forms;

namespace SlimGis.Samples
{
    public partial class BingMapsLayerControl : UserControl
    {
        private MapControl mapContent;

        public BingMapsLayerControl()
        {
            InitializeComponent();
            mapContent = new MapControl();
            layerTypeComboBox.SelectedIndex = 0;
        }

        public MapControl MapContent => mapContent;

        private void BingMapsLayerControl_Load(object sender, EventArgs e)
        {
            MapContent.MapUnit = GeoUnit.Meter;

            BingMapsLayer bingMapsLayer = new BingMapsLayer(BingMapsType.Road, "AswP3q2unPpwB7h5xK-DbPvN_2ZbjQqGeQ18dp3HfSn3IKon4dLM3-IDX3jswTMd");

            LayerOverlay layerOverlay = new LayerOverlay();
            layerOverlay.Layers.Add(bingMapsLayer);
            MapContent.Overlays.Add(layerOverlay);

            // We can also use the code below to add a google maps to our map.
            // Map1.UseBingMapsAsBaseMap(GoogleMapsType.RoadMap, "Your bingmaps key");

            MapContent.ZoomToFullBound();
        }

        private void layerTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BingMapsLayer bingMapsLayer = MapContent.FindLayer<BingMapsLayer>("Bing Maps");
            if (bingMapsLayer != null)
            {
                bingMapsLayer.MapsType = (BingMapsType)layerTypeComboBox.SelectedIndex;
                MapContent.Refresh(RefreshType.Redraw);
            }
        }
    }
}

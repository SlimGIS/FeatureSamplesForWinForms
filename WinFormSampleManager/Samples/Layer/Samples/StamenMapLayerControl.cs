using SlimGis.MapKit.Controls;
using SlimGis.MapKit.Geometries;
using SlimGis.MapKit.Layers;
using SlimGis.MapKit.Symbologies;
using SlimGis.MapKit.WinForms;
using System;
using System.Windows.Forms;

namespace SlimGis.Samples
{
    public partial class StamenMapLayerControl : UserControl
    {
        private MapControl mapContent;

        public StamenMapLayerControl()
        {
            InitializeComponent();
            mapContent = new MapControl();
            layerTypeComboBox.SelectedIndex = 0;
        }

        public MapControl MapContent => mapContent;

        private void StamenMapLayerControl_Load(object sender, EventArgs e)
        {
            MapContent.MapUnit = GeoUnit.Meter;

            StamenMapLayer stamenMapLayer = new StamenMapLayer();
            LayerOverlay layerOverlay = new LayerOverlay();
            layerOverlay.Layers.Add(stamenMapLayer);
            MapContent.Overlays.Add(layerOverlay);

            // We can also use the code below to add a stamen maps to our map.
            // Map1.UseStamenMapAsBaseMap(StamenMapType.Toner);

            MapContent.ZoomToFullBound();
        }

        private void layerTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            StamenMapLayer stamenMapLayer = MapContent.FindLayer<StamenMapLayer>("Stamen Map");
            if (stamenMapLayer != null)
            {
                stamenMapLayer.MapType = (StamenMapType)layerTypeComboBox.SelectedIndex;
                MapContent.Refresh(RefreshType.Redraw);
            }
        }
    }
}

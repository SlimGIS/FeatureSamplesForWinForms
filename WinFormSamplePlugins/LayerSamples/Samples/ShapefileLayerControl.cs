using SlimGis.MapKit.Geometries;
using SlimGis.MapKit.Layers;
using SlimGis.MapKit.Symbologies;
using SlimGis.MapKit.WinForms;
using System;
using System.Windows.Forms;

namespace SlimGis.Samples
{
    public partial class ShapefileLayerControl : UserControl
    {
        private MapControl mapContent;

        public ShapefileLayerControl()
        {
            InitializeComponent();
            mapContent = new MapControl();
        }

        public MapControl MapContent => mapContent;

        private void ShapefileLayerControl_Load(object sender, EventArgs e)
        {
            MapContent.MapUnit = GeoUnit.Meter;
            MapContent.UseOpenStreetMapAsBaseMap();

            ShapefileLayer shapefileLayer = new ShapefileLayer("SampleData/countries-900913.shp");
            shapefileLayer.Styles.Add(new FillStyle(GeoColor.FromHtml("#55FAB04D"), GeoColors.White));

            LayerOverlay layerOverlay = new LayerOverlay();
            layerOverlay.Layers.Add(shapefileLayer);
            MapContent.Overlays.Add(layerOverlay);

            MapContent.ZoomToFullBound();
        }
    }
}

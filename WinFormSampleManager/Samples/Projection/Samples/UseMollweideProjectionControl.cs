using SlimGis.MapKit.Geometries;
using SlimGis.MapKit.Layers;
using SlimGis.MapKit.Symbologies;
using SlimGis.MapKit.WinForms;
using System;
using System.Windows.Forms;

namespace SlimGis.Samples
{
    public partial class UseMollweideProjectionControl : UserControl
    {
        private MapControl mapContent;

        public UseMollweideProjectionControl()
        {
            InitializeComponent();
            mapContent = new MapControl();
        }

        public MapControl MapContent => mapContent;

        private void UseMollweideProjectionControl_Load(object sender, EventArgs e)
        {
            MapContent.MapUnit = GeoUnit.Degree;

            ShapefileLayer featureLayer = new ShapefileLayer("SampleData/countries-wgs84.shp");
            featureLayer.Styles.Add(new FillStyle(GeoColor.FromHtml("#FAB04D"), GeoColors.White));
            MapContent.AddStaticLayers("countries-wgs84", featureLayer);

            MapContent.ZoomToFullBound();
        }

        private void reprojectButton_Click(object sender, EventArgs e)
        {
            if (MapContent.MapUnit == GeoUnit.Meter) return;

            MapContent.MapUnit = GeoUnit.Meter;
            FeatureLayer featureLayer = MapContent.FindLayer<ShapefileLayer>("countries-wgs84");
            SpatialReference srsSource = SpatialReferences.GetWgs84();
            SpatialReference srsTarget = SpatialReference.ParseSrid(54009);
            featureLayer.Source.Projection = new Proj4Projection(srsSource, srsTarget);

            MapContent.Overlays["countries-wgs84"].Invalidate();
            MapContent.ZoomToFullBound();
        }
    }
}

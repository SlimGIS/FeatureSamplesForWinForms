using SlimGis.MapKit.Geometries;
using SlimGis.MapKit.Layers;
using SlimGis.MapKit.Symbologies;
using SlimGis.MapKit.WinForms;
using System;
using System.Windows.Forms;

namespace SlimGis.Samples
{
    public partial class UseFillStyleControl : UserControl
    {
        private MapControl mapContent;

        public UseFillStyleControl()
        {
            InitializeComponent();
            mapContent = new MapControl();
        }

        public MapControl MapContent => mapContent;

        private void UseFillStyleControl_Load(object sender, EventArgs e)
        {
            MapContent.MapUnit = GeoUnit.Meter;
            MapContent.UseOpenStreetMapAsBaseMap();

            ShapefileLayer areaLayer = new ShapefileLayer("SampleData/countries-900913.shp");
            areaLayer.Styles.Add(new FillStyle(GeoColor.FromHtml("#55FAB04D"), GeoColors.White, 1));
            MapContent.AddStaticLayers("AreaOverlay", areaLayer);

            MapContent.ZoomTo(areaLayer.GetBound());
        }

        private void randomStyleButton_Click(object sender, EventArgs e)
        {
            ShapefileLayer areaLayer = MapContent.FindLayer<ShapefileLayer>("countries-900913");
            areaLayer.UseRandomStyle(120);
            MapContent.Refresh("AreaOverlay");
        }
    }
}

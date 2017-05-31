using SlimGis.MapKit.Geometries;
using SlimGis.MapKit.Layers;
using SlimGis.MapKit.Symbologies;
using SlimGis.MapKit.WinForms;
using System;
using System.Windows.Forms;

namespace SlimGis.Samples
{
    public partial class UseLineStyleControl : UserControl
    {
        private MapControl mapContent;

        public UseLineStyleControl()
        {
            InitializeComponent();
            mapContent = new MapControl();
        }

        public MapControl MapContent => mapContent;

        private void UseLineStyleControl_Load(object sender, EventArgs e)
        {
            MapContent.MapUnit = GeoUnit.Meter;
            MapContent.UseOpenStreetMapAsBaseMap();

            ShapefileLayer lineLayer = new ShapefileLayer("SampleData/streets-900913.shp");
            lineLayer.Styles.Add(new LineStyle(GeoColor.FromHtml("#55FAB04D"), 1));
            MapContent.AddStaticLayers("LineOverlay", lineLayer);

            GeoBound bound = lineLayer.GetBound();
            bound.ScaleDown(90);
            MapContent.ZoomTo(bound);
        }

        private void randomStyleButton_Click(object sender, EventArgs e)
        {
            ShapefileLayer lineLayer = MapContent.FindLayer<ShapefileLayer>("streets-900913");
            float[] dashPattern = ((LineStyle)lineLayer.Styles[0]).Pen.DashPattern;
            lineLayer.UseRandomStyle();
            ((LineStyle)lineLayer.Styles[0]).Pen.DashPattern = dashPattern;

            MapContent.Refresh("LineOverlay");
        }

        private void useDashCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool useDash = ((CheckBox)sender).Checked;

            ShapefileLayer lineLayer = MapContent.FindLayer<ShapefileLayer>("streets-900913");
            ((LineStyle)lineLayer.Styles[0]).Pen.DashPattern = useDash ? new[] { 4f, 4f } : null;
            MapContent.Refresh("LineOverlay");
        }
    }
}

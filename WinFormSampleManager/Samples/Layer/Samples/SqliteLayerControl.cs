using SlimGis.MapKit.Geometries;
using SlimGis.MapKit.Layers;
using SlimGis.MapKit.Symbologies;
using SlimGis.MapKit.WinForms;
using System;
using System.Windows.Forms;

namespace SlimGis.Samples
{
    public partial class SqliteLayerControl : UserControl
    {
        private MapControl mapContent;

        public SqliteLayerControl()
        {
            InitializeComponent();
            mapContent = new MapControl();
        }

        public MapControl MapContent => mapContent;

        private void SqliteLayerControl_Load(object sender, EventArgs e)
        {
            MapContent.MapUnit = GeoUnit.Meter;
            MapContent.UseOpenStreetMapAsBaseMap();

            string connectionString = SqliteSource.CreateConnectionString("SampleData/usstates-900913.sqlite");
            SqliteLayer sqliteLayer = new SqliteLayer(connectionString, "table_name", "id", "geometry");
            sqliteLayer.Styles.Add(new FillStyle(GeoColor.FromHtml("#55FAB04D"), GeoColors.White));

            LayerOverlay layerOverlay = new LayerOverlay();
            layerOverlay.Layers.Add(sqliteLayer);
            MapContent.Overlays.Add(layerOverlay);

            MapContent.ZoomTo(sqliteLayer.GetBound());
        }
    }
}

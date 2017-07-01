using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SlimGis.MapKit.WinForms;
using SlimGis.MapKit.Layers;
using SlimGis.MapKit.Geometries;
using SlimGis.MapKit.Symbologies;

namespace SlimGis.Samples
{
    public partial class FindClosestPointControl : UserControl
    {
        private Feature highlightFeature;
        private MapControl mapContent;

        public FindClosestPointControl()
        {
            InitializeComponent();
            mapContent = new MapControl();
            mapContent.MapMouseMove += MapContent_MapMouseMove;
        }

        public MapControl MapContent => mapContent;

        private void FindClosestPointControl_Load(object sender, EventArgs e)
        {
            MapContent.MapUnit = GeoUnit.Meter;
            MapContent.UseOpenStreetMapAsBaseMap();

            ShapefileSource dataSource = new ShapefileSource("SampleData/countries-900913.shp");
            dataSource.Open();
            highlightFeature = dataSource.GetFeatureById("1", RequireColumnsType.None);

            MemoryLayer highlightLayer = new MemoryLayer();
            highlightLayer.Features.Add(highlightFeature);
            highlightLayer.Styles.Add(new FillStyle(GeoColor.FromHtml("#55FAB04D")));
            MapContent.AddStaticLayers("HighlightOverlay", highlightLayer);

            MapContent.ZoomTo(highlightFeature);
        }

        private void MapContent_MapMouseMove(object sender, MapMouseEventArgs e)
        {
            FindClosestPoint(e);
        }

        private void FindClosestPoint(MapMouseEventArgs e)
        {
            MemoryLayer closetPointLayer = MapContent.FindLayer<MemoryLayer>("ClosetPointLayer");
            if (closetPointLayer == null)
            {
                closetPointLayer = new MemoryLayer { Name = "ClosetPointLayer" };
                closetPointLayer.Styles.Add(new SymbolStyle(SymbolType.Circle, GeoColor.FromHtml("#AA3F8CB4"), GeoColors.White));
                MapContent.AddDynamicLayers("ClosestPointOverlay", closetPointLayer);
            }

            GeoPoint closestPoint = highlightFeature.Geometry.GetClosestPointTo(new GeoPoint(e.WorldCoordinate));
            closetPointLayer.Features.Clear();
            if (closestPoint != null)
            {
                closetPointLayer.Features.Add(new Feature(closestPoint));
                MapContent.Refresh("ClosestPointOverlay");
            }
        }
    }
}

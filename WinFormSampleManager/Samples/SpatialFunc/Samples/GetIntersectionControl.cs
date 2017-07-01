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
using SlimGis.MapKit.Geometries;
using SlimGis.MapKit.Layers;
using SlimGis.MapKit.Symbologies;

namespace SlimGis.Samples
{
    public partial class GetIntersectionControl : UserControl
    {
        private Feature feature1;
        private Feature feature2;
        private MapControl mapContent;

        public GetIntersectionControl()
        {
            InitializeComponent();
            mapContent = new MapControl();
        }

        public MapControl MapContent => mapContent;

        private void GetIntersectionControl_Load(object sender, EventArgs e)
        {
            MapContent.MapUnit = GeoUnit.Meter;
            MapContent.UseOpenStreetMapAsBaseMap();

            GeoBound bound = new GeoBound(2171997.6512, 8356849.2669, 3515687.9933, 11097616.86);
            GeoPoint center = bound.GetCentroid();
            double x1 = bound.MinX + bound.Width * .25;
            double y = center.Y;
            double x2 = bound.MaxX - bound.Width * .25;
            double radius = bound.Width * 3 / 8;

            feature1 = new Feature(new GeoEllipse(new GeoPoint(x1, y), radius));
            feature2 = new Feature(new GeoEllipse(new GeoPoint(x2, y), radius));

            MemoryLayer highlightLayer = new MemoryLayer { Name = "HighlightLayer" };
            highlightLayer.Features.Add(feature1);
            highlightLayer.Features.Add(feature2);
            highlightLayer.Styles.Add(new FillStyle(GeoColor.FromHtml("#55FAB04D"), GeoColors.White));
            MapContent.AddStaticLayers("HighlightOverlay", highlightLayer);

            MemoryLayer resultLayer = new MemoryLayer { Name = "ResultLayer" };
            resultLayer.Styles.Add(new FillStyle(GeoColor.FromHtml("#99FF5722"), GeoColors.White));
            MapContent.AddDynamicLayers("ResultOverlay", resultLayer);

            MapContent.ZoomTo(bound);
        }

        private void GetIntersectionButton_Click(object sender, EventArgs e)
        {
            MemoryLayer resultLayer = MapContent.FindLayer<MemoryLayer>("ResultLayer");
            if (resultLayer.Features.Count == 0)
            {
                Geometry intersection = feature1.Geometry.GetIntersection(feature2.Geometry);
                resultLayer.Features.Add(new Feature(intersection));

                MapContent.Refresh("ResultOverlay");
            }
        }        
    }
}

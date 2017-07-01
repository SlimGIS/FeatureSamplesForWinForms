using SlimGis.MapKit.Geometries;
using SlimGis.MapKit.Symbologies;
using SlimGis.MapKit.WinForms;
using SlimGis.Samples.Properties;
using System;
using System.Windows.Forms;

namespace SlimGis.Samples
{
    public partial class UseMarkersControl : UserControl
    {
        private MapControl mapContent;

        public UseMarkersControl()
        {
            InitializeComponent();
            mapContent = new MapControl();
        }

        public MapControl MapContent => mapContent;

        private void UseMarkersControl_Load(object sender, EventArgs e)
        {
            MapContent.MapUnit = GeoUnit.Meter;
            MapContent.UseOpenStreetMapAsBaseMap();

            GeoBound currentBound = new GeoBound(1534877.2788, 5720521.3921, 1536797.864, 5721952.8921);
            GeoImage sourceImage = new GeoImage(Resources._6x9_icons_50);

            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                double x = r.Next(1534877, 1536797);
                double y = r.Next(5720521, 5721952);
                AddMarker(x, y, GetRandomIcon(r, sourceImage));
            }

            MapContent.ZoomTo(currentBound);
        }

        private void AddMarker(double worldX, double worldY, GeoImage markerImage)
        {
            Marker marker = new Marker();
            marker.Location = new GeoCoordinate(worldX, worldY);
            marker.Image = markerImage;
            MapContent.Placements.Add(marker);
        }

        private GeoImage GetRandomIcon(Random r, GeoImage source)
        {
            int index = r.Next(0, 49);
            int row = (int)Math.Floor(index / 6d);
            int colInLastRow = index % 6;

            GeoSize sourceSize = source.GetSize();
            int cellWidth = (int)(sourceSize.Width / 6d);
            int cellHeight = (int)(sourceSize.Height / 9d);
            int top = (int)(row * cellHeight);
            int left = (int)(colInLastRow * cellWidth);
            return source.ClipTo(new ScreenBoundF(left, top, left + cellWidth, top + cellHeight), cellWidth, cellHeight);
        }
    }
}

using SlimGis.MapKit.Geometries;
using SlimGis.MapKit.Layers;
using SlimGis.MapKit.Symbologies;
using SlimGis.MapKit.WinForms;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlimGis.Samples
{
    public partial class GetLineOnALineControl : UserControl
    {
        private MapControl mapContent;

        public GetLineOnALineControl()
        {
            InitializeComponent();
            mapContent = new MapControl();
        }

        public MapControl MapContent => mapContent;

        private void GetLineOnALineControl_Load(object sender, EventArgs e)
        {
            MapContent.MapUnit = GeoUnit.Meter;
            MapContent.UseOpenStreetMapAsBaseMap();
            GeoBound currentBound = new GeoBound(2171997.6512, 8356849.2669, 3515687.9933, 11097616.86);

            MemoryLayer baselineLayer = new MemoryLayer { Name = "BaseLineLayer" };
            baselineLayer.Styles.Add(new LineStyle(GeoColors.White, 8));
            baselineLayer.Styles.Add(new LineStyle(GeoColor.FromHtml("#88FAB04D"), 4));
            baselineLayer.Features.Add(CreateLineFeature(currentBound));
            MapContent.AddStaticLayers("BaseLineOverlay", baselineLayer);

            MemoryLayer highlightLayer = new MemoryLayer { Name = "HighlightLayer" };
            highlightLayer.Styles.Add(new LineStyle(GeoColor.FromHtml("#9903A9F4"), 4));
            MapContent.AddDynamicLayers("HighlightOverlay", highlightLayer);

            MapContent.ZoomTo(currentBound);
        }

        private async void startButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            MemoryLayer baselineLayer = MapContent.FindLayer<MemoryLayer>("BaseLineLayer");
            MemoryLayer highlightLayer = MapContent.FindLayer<MemoryLayer>("HighlightLayer");
            GeoLine baseline = (GeoLine)baselineLayer.Features.First().Geometry;

            int times = 100;
            double percentageRatio = 100d / times;

            button.Enabled = false;
            for (int i = 0; i <= times; i++)
            {
                await MoveLine(highlightLayer, baseline, percentageRatio, i);
            }

            for (int i = times; i >= 0; i--)
            {
                await MoveLine(highlightLayer, baseline, percentageRatio, i);
            }
            button.Enabled = true;
        }

        private async Task MoveLine(MemoryLayer highlightLayer, GeoLine baseline, double percentageRatio, int i)
        {
            GeoLinearBase line = await Task.Run(() => baseline.GetSegmentation((float)percentageRatio * i));
            highlightLayer.Features.Clear();

            if (line != null) highlightLayer.Features.Add(new Feature(line));
            MapContent.Refresh("HighlightOverlay");

            await Task.Run(() => Thread.Sleep(50));
        }

        private Feature CreateLineFeature(GeoBound bound)
        {
            GeoLine line = new GeoLine();

            double startX = bound.MinX + bound.Width * .15;
            double endX = bound.MinX + bound.Width * .85;
            double centerY = bound.GetCentroid().Y;
            double height = bound.Height * .25;
            int segmentCount = 30;
            double segmentHorizontalLength = (endX - startX) / segmentCount;

            for (int i = 0; i < segmentCount; i++)
            {
                double x = startX + segmentHorizontalLength * i;
                double y = Math.Sin(Math.PI * 2 * i / segmentCount) * height + centerY;
                line.Coordinates.Add(new GeoCoordinate(x, y));
            }

            return new Feature(line);
        }
    }
}

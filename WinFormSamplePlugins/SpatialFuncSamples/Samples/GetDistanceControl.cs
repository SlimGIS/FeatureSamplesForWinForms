using SlimGis.MapKit.Geometries;
using SlimGis.MapKit.Layers;
using SlimGis.MapKit.Symbologies;
using SlimGis.MapKit.Utilities;
using SlimGis.MapKit.WinForms;
using System;
using System.Globalization;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlimGis.Samples
{
    public partial class GetDistanceControl : UserControl
    {
        private LengthUnit[] targetUnits;
        private Feature feature1;
        private Feature feature2;
        private double distanceInMeter;
        private MapControl mapContent;

        public GetDistanceControl()
        {
            InitializeComponent();
            distanceUnitComboBox.SelectedIndex = 0;

            mapContent = new MapControl();
            targetUnits = new[] { LengthUnit.Feet, LengthUnit.Kilometer, LengthUnit.Meter, LengthUnit.Mile, LengthUnit.UsSurveyFeet, LengthUnit.Yard };
        }

        public MapControl MapContent => mapContent;

        private void GetDistanceControl_Load(object sender, EventArgs e)
        {
            MapContent.MapUnit = GeoUnit.Meter;
            MapContent.UseOpenStreetMapAsBaseMap();

            ShapefileSource dataSource = new ShapefileSource("SampleData/countries-900913.shp");
            dataSource.Open();
            feature1 = dataSource.GetFeatureById("1", RequireColumnsType.None);
            feature2 = dataSource.GetFeatureById("10", RequireColumnsType.None);

            MemoryLayer highlightLayer = new MemoryLayer();
            highlightLayer.Features.Add(feature1);
            highlightLayer.Features.Add(feature2);
            highlightLayer.Styles.Add(new FillStyle(GeoColor.FromHtml("#55FAB04D")));
            MapContent.AddStaticLayers("HighlightOverlay", highlightLayer);

            MemoryLayer resultLayer = new MemoryLayer { Name = "ResultLayer" };
            resultLayer.Styles.Add(new SymbolStyle(SymbolType.Circle, GeoColor.FromHtml("#99FF5722"), GeoColors.White));
            resultLayer.Styles.Add(new LineStyle(GeoColor.FromHtml("#00BCD4"), 4));
            MapContent.AddDynamicLayers("ResultOverlay", resultLayer);

            MapContent.ZoomTo(GeoBound.CreateToInclude(new[] { feature1, feature2 }));
        }

        private async void GetDistanceButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.Enabled = false;
            distanceUnitComboBox.Enabled = false;
            distanceLabel.Visible = false;
            gettingDistanceProgressBar.Visible = true;

            distanceInMeter = await Task.Run(() => feature1.Geometry.GetDistanceTo(feature2.Geometry));
            double tempResult = GeoConversion.ConvertLength(distanceInMeter, LengthUnit.Meter, targetUnits[distanceUnitComboBox.SelectedIndex]);
            distanceLabel.Text = tempResult.ToString("N0", CultureInfo.InvariantCulture);

            gettingDistanceProgressBar.Visible = false;
            distanceLabel.Visible = true;
            distanceUnitComboBox.Enabled = true;
            button.Enabled = true;
        }

        private void DistanceUnitComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (distanceInMeter == 0) return;
            double tempResult = GeoConversion.ConvertLength(distanceInMeter, LengthUnit.Meter, targetUnits[distanceUnitComboBox.SelectedIndex]);
            distanceLabel.Text = tempResult.ToString("N0", CultureInfo.InvariantCulture);
        }
    }
}

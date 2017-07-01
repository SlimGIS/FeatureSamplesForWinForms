using SlimGis.MapKit.Geometries;
using SlimGis.MapKit.Layers;
using SlimGis.MapKit.Symbologies;
using SlimGis.MapKit.Utilities;
using SlimGis.MapKit.WinForms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SlimGis.Samples
{
    public partial class GetLengthControl : UserControl
    {
        private ShapefileLayer dataLayer;
        private MapControl mapContent;

        public GetLengthControl()
        {
            InitializeComponent();
            mapContent = new MapControl();
            mapContent.MapClick += MapContent_MapSingleClick;
        }

        public MapControl MapContent => mapContent;

        private void GetLengthControl_Load(object sender, EventArgs e)
        {
            MapContent.MapUnit = GeoUnit.Meter;
            MapContent.UseOpenStreetMapAsBaseMap();

            dataLayer = new ShapefileLayer("SampleData/streets-900913.shp");
            dataLayer.Styles.Add(new LineStyle(GeoColor.FromHtml("#55FAB04D"), 4));
            MapContent.AddStaticLayers("AustinStreetsOverlay", dataLayer);

            MemoryLayer highlightLayer = new MemoryLayer { Name = "HighlightLayer" };
            highlightLayer.Columns.Add(new FeatureColumn("Distance", UnifiedColumnType.Text));
            highlightLayer.Styles.Add(new LineStyle(GeoColor.FromHtml("#8800BCD4"), 8));

            LabelStyle distanceLabelStyle = new LabelStyle("Distance", new GeoFont(), GeoColor.FromHtml("#111111"), GeoColors.White);
            distanceLabelStyle.LineSegmentRatio = 100;
            highlightLayer.Styles.Add(distanceLabelStyle);
            MapContent.AddDynamicLayers("HighlightOverlay", highlightLayer);

            MapContent.ZoomTo(new GeoBound(-10880446.205, 3540612.6137, -10879623.9531, 3541519.945));
        }

        private void MapContent_MapSingleClick(object sender, MapMouseEventArgs e)
        {
            Feature identifiedFeature = IdentifyHelper.Identify(dataLayer, e.WorldCoordinate, MapContent.CurrentScale, MapContent.MapUnit).FirstOrDefault();
            if (identifiedFeature != null)
            {
                double distanceInMeter = ((GeoLinearBase)identifiedFeature.Geometry).GetLength();
                identifiedFeature.FieldValues.Add("Distance", $"{distanceInMeter:N2} m");

                MemoryLayer highlightLayer = MapContent.FindLayer<MemoryLayer>("HighlightLayer");

                highlightLayer.Features.Clear();
                highlightLayer.Features.Add(identifiedFeature);

                MapContent.Refresh("HighlightOverlay");
            }
        }
    }
}

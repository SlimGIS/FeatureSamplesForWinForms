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
    public partial class GetAreaControl : UserControl
    {
        private ShapefileLayer dataLayer;
        private MapControl mapContent;

        public GetAreaControl()
        {
            InitializeComponent();
            mapContent = new MapControl();
            mapContent.MapClick += MapContent_MapSingleClick;
        }

        public MapControl MapContent => mapContent;

        private void GetAreaControl_Load(object sender, EventArgs e)
        {
            MapContent.MapUnit = GeoUnit.Meter;
            MapContent.UseOpenStreetMapAsBaseMap();

            dataLayer = new ShapefileLayer("SampleData/sections-900913.shp");
            dataLayer.Styles.Add(new FillStyle(GeoColors.Transparent, GeoColor.FromHtml("#99FAB04D"), 1));
            MapContent.AddStaticLayers("SectionOverlay", dataLayer);

            MemoryLayer highlightLayer = new MemoryLayer { Name = "HighlightLayer" };
            highlightLayer.Columns.Add(new FeatureColumn("Area", UnifiedColumnType.Text));
            highlightLayer.Styles.Add(new FillStyle(GeoColor.FromHtml("#66FFFF00"), GeoColors.White));

            LabelStyle areaLabelStyle = new LabelStyle("Area", new GeoFont(), GeoColor.FromHtml("#111111"), GeoColors.White);
            highlightLayer.Styles.Add(areaLabelStyle);
            MapContent.AddDynamicLayers("HighlightOverlay", highlightLayer);

            MapContent.ZoomTo(new GeoBound(-10111509.577, 4582117.8006, -10099064.6735, 4598828.7496));
        }

        private void MapContent_MapSingleClick(object sender, MapMouseEventArgs e)
        {
            Feature identifiedFeature = IdentifyHelper.Identify(dataLayer, e.WorldCoordinate, MapContent.CurrentScale, MapContent.MapUnit).FirstOrDefault();
            if (identifiedFeature != null)
            {
                double areaInSquareKilometer = ((GeoAreaBase)identifiedFeature.Geometry).GetArea(GeoUnit.Meter, AreaUnit.SquareKilometers);
                identifiedFeature.FieldValues.Add("Area", $"{areaInSquareKilometer:N2} sq. km");

                MemoryLayer highlightLayer = MapContent.FindLayer<MemoryLayer>("HighlightLayer");
                highlightLayer.Features.Clear();
                highlightLayer.Features.Add(identifiedFeature);

                MapContent.Refresh("HighlightOverlay");
            }
        }
    }
}

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
using SlimGis.MapKit.Utilities;

namespace SlimGis.Samples
{
    public partial class GetWellKnownDataControl : UserControl
    {
        private ShapefileLayer dataLayer;
        private MapControl mapContent;

        public GetWellKnownDataControl()
        {
            InitializeComponent();
            mapContent = new MapControl();
            mapContent.MapClick += MapContent_MapSingleClick;
        }

        public MapControl MapContent => mapContent;

        private void GetWellKnownDataControl_Load(object sender, EventArgs e)
        {
            MapContent.MapUnit = GeoUnit.Meter;
            MapContent.UseOpenStreetMapAsBaseMap();

            dataLayer = new ShapefileLayer("SampleData/countries-900913.shp");
            dataLayer.Open();

            MemoryLayer highlightLayer = new MemoryLayer { Name = "HighlightLayer" };
            highlightLayer.Styles.Add(new FillStyle(GeoColor.FromHtml("#55FAB04D"), GeoColors.White, 4));
            MapContent.AddDynamicLayers("HighlightOverlay", highlightLayer);

            MapContent.ZoomTo(new GeoBound(2171997.6512, 8356849.2669, 3515687.9933, 11097616.86));
        }

        private void MapContent_MapSingleClick(object sender, MapMouseEventArgs e)
        {
            Feature identifiedFeature = IdentifyHelper.Identify(dataLayer, e.WorldCoordinate, MapContent.CurrentScale, MapContent.MapUnit).FirstOrDefault();
            if (identifiedFeature != null)
            {
                MemoryLayer highlightLayer = MapContent.FindLayer<MemoryLayer>("HighlightLayer");

                highlightLayer.Features.Clear();
                highlightLayer.Features.Add(identifiedFeature);

                wktTextBox.Text = identifiedFeature.ToWkt();
                wkbTextBox.Text = Convert.ToBase64String(identifiedFeature.ToWkb());

                MapContent.Refresh("HighlightOverlay");
            }
        }

        private void GetWellKnownDataControl_SizeChanged(object sender, EventArgs e)
        {
            wkbPanel.Height = wktPanel.Height = Height / 2;
            wktTextBox.Height = wktPanel.Height - 30;
            wkbTextBox.Height = wkbPanel.Height - 30;
        }
    }
}

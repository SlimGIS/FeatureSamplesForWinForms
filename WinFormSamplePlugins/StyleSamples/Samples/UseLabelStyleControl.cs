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
using SlimGis.MapKit.Symbologies;
using SlimGis.MapKit.Geometries;

namespace SlimGis.Samples
{
    public partial class UseLabelStyleControl : UserControl
    {
        private MapControl mapContent;

        public UseLabelStyleControl()
        {
            InitializeComponent();
            mapContent = new MapControl();
        }

        public MapControl MapContent => mapContent;

        private void UseLabelStyleControl_Load(object sender, EventArgs e)
        {
            MapContent.MapUnit = GeoUnit.Meter;
            MapContent.UseOpenStreetMapAsBaseMap();

            ShapefileLayer areaLayer = new ShapefileLayer("SampleData/countries-900913.shp");
            var feature = areaLayer.Source.GetFeatureById("1", RequireColumnsType.All);

            areaLayer.Styles.Add(new FillStyle(GeoColor.FromHtml("#55FAB04D"), GeoColors.White, 1));

            LabelStyle labelStyle = new LabelStyle("CNTRY_NAME", new GeoFont { FontSize = 8 }, GeoColors.Black, GeoColors.White, 2);
            labelStyle.Margin = 100;
            areaLayer.Styles.Add(labelStyle);
            MapContent.AddStaticLayers("AreaOverlay", areaLayer);

            MapContent.ZoomTo(areaLayer.GetBound());
        }
    }
}

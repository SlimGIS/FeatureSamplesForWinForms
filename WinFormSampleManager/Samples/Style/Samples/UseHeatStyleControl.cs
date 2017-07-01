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
using SlimGis.MapKit.Controls;

namespace SlimGis.Samples
{
    public partial class UseHeatStyleControl : UserControl
    {
        private static readonly string columnName = "MED_AGE";
        private MapControl mapContent;

        public UseHeatStyleControl()
        {
            InitializeComponent();
            mapContent = new MapControl();
            heatPointSizeComboBox.SelectedIndex = 0;
            colorPaletteTypeComboBox.SelectedIndex = 0;
        }

        public MapControl MapContent => mapContent;

        private void UseHeatStyleControl_Load(object sender, EventArgs e)
        {
            MapContent.MapUnit = GeoUnit.Meter;
            MapContent.UseOpenStreetMapAsBaseMap();

            ShapefileLayer pointLayer = new ShapefileLayer("SampleData/cities-900913.shp");
            HeatStyle heatStyle = new HeatStyle();
            heatStyle.DataColumn = columnName;
            heatStyle.MaxIntensity = 37.7;
            heatStyle.MinIntensity = 30;
            heatStyle.Alpha = 150;
            heatStyle.Radius = (2 - heatPointSizeComboBox.SelectedIndex) * 30 + 20;
            pointLayer.Styles.Add(heatStyle);
            MapContent.AddStaticLayers("PointOverlay", pointLayer);

            MapContent.ZoomTo(pointLayer.GetBound());
        }

        private void heatPointSizeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshMap();
        }

        private void colorPaletteTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshMap();
        }

        private void RefreshMap()
        {
            ShapefileLayer pointLayer = MapContent.FindLayer<ShapefileLayer>("cities-900913");
            if (pointLayer == null) return;
            HeatStyle heatStyle = (HeatStyle)pointLayer.Styles[0];
            heatStyle.Radius = (2 - heatPointSizeComboBox.SelectedIndex) * 30 + 20;
            heatStyle.ColorPaletteType = (ColorPaletteType)Enum.Parse(typeof(ColorPaletteType), (string)colorPaletteTypeComboBox.SelectedItem);

            MapContent.Refresh(RefreshType.Redraw);
        }
    }
}

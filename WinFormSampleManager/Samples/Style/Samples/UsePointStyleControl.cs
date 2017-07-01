using SlimGis.MapKit.Geometries;
using SlimGis.MapKit.Layers;
using SlimGis.MapKit.Symbologies;
using SlimGis.MapKit.WinForms;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SlimGis.Samples
{
    public partial class UsePointStyleControl : UserControl
    {
        private MapControl mapContent;

        public UsePointStyleControl()
        {
            InitializeComponent();
            mapContent = new MapControl();

            var symbolTypes = Enum.GetValues(typeof(SymbolType)).Cast<SymbolType>();
            symbolTypeComboBox.Items.AddRange(symbolTypes.Select(t => t.ToString()).ToArray());
            symbolTypeComboBox.SelectedIndex = 0;

            symbolSizeComboBox.Items.AddRange(new object[] { 20f, 30f, 40f });
            symbolSizeComboBox.SelectedIndex = 1;
        }

        public MapControl MapContent => mapContent;

        private void UsePointStyleControl_Load(object sender, EventArgs e)
        {
            MapContent.MapUnit = GeoUnit.Meter;
            MapContent.UseOpenStreetMapAsBaseMap();

            ShapefileLayer pointLayer = new ShapefileLayer("SampleData/cities-900913.shp");
            pointLayer.UseRandomStyle(120);
            SyncSymbolSettings(pointLayer);

            MapContent.AddStaticLayers("PointOverlay", pointLayer);
            MapContent.ZoomTo(pointLayer.GetBound());
        }

        private void ReandomStyleButton_Click(object sender, EventArgs e)
        {
            ShapefileLayer pointLayer = MapContent.FindLayer<ShapefileLayer>("cities-900913");
            pointLayer.UseRandomStyle(120);
            SyncSymbolSettings(pointLayer);
        }

        private void SettingComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShapefileLayer pointLayer = MapContent.FindLayer<ShapefileLayer>("cities-900913");
            if (pointLayer == null) return;

            SyncSymbolSettings(pointLayer);
        }

        private void SyncSymbolSettings(ShapefileLayer pointLayer)
        {
            SymbolStyle symbolStyle = (SymbolStyle)pointLayer.Styles[0];
            symbolStyle.SymbolType = (SymbolType)Enum.Parse(typeof(SymbolType), (string)symbolTypeComboBox.SelectedItem);
            symbolStyle.Size = (float)symbolSizeComboBox.SelectedItem;
            symbolStyle.Margin = 40;

            MapContent.Refresh("PointOverlay");
        }

    }
}

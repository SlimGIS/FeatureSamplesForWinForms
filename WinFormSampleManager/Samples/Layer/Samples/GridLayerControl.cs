using SlimGis.MapKit.Geometries;
using SlimGis.MapKit.Layers;
using SlimGis.MapKit.Symbologies;
using SlimGis.MapKit.WinForms;
using System;
using System.Linq;
using System.Windows.Forms;

namespace SlimGis.Samples
{
    public partial class GridLayerControl : UserControl
    {
        private MapControl mapContent;

        public GridLayerControl()
        {
            InitializeComponent();
            mapContent = new MapControl();
        }

        public MapControl MapContent => mapContent;

        private void GridLayerControl_Load(object sender, EventArgs e)
        {
            MapContent.MapUnit = GeoUnit.Meter;
            MapContent.UseOpenStreetMapAsBaseMap();

            GridLayer gridLayer = new GridLayer("SampleData/gridfile-900913.grd");
            GridFileSource gridSource = (GridFileSource)gridLayer.Source;
            var cellValues = gridSource.GetDistinctCellValues();
            cellValues.Sort();

            ClassBreakStyle style = ClassBreakStyle.Create("CellValue", cellValues.Last(), cellValues.First(), 8, DimensionType.Area, GeoColors.Red, GeoColors.Transparent);
            style.Margin = 25;
            gridLayer.Styles.Add(style);

            LayerOverlay layerOverlay = new LayerOverlay();
            layerOverlay.Layers.Add(gridLayer);
            MapContent.Overlays.Add(layerOverlay);

            MapContent.ZoomTo(gridLayer.GetBound());
        }
    }
}

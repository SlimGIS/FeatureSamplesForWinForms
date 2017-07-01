using SlimGis.MapKit.Geometries;
using SlimGis.MapKit.Layers;
using SlimGis.MapKit.Symbologies;
using SlimGis.MapKit.WinForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace SlimGis.Samples
{
    public partial class SpatialQueryControl : UserControl
    {
        private MapControl mapContent;

        public SpatialQueryControl()
        {
            InitializeComponent();
            mapContent = new MapControl();
            queryOptionComboBox.SelectedIndex = 0;
        }

        public MapControl MapContent => mapContent;

        private void SpatialQueryControl_Load(object sender, EventArgs e)
        {
            MapContent.MapUnit = GeoUnit.Meter;
            MapContent.UseOpenStreetMapAsBaseMap();

            ShapefileLayer sectionLayer = new ShapefileLayer("SampleData/sections-900913.shp");
            sectionLayer.Styles.Add(new FillStyle(GeoColors.Transparent, GeoColor.FromHtml("#99FAB04D"), 1));
            MapContent.AddStaticLayers("SectionOverlay", sectionLayer);

            GeoBound sectionBound = sectionLayer.GetBound();
            GeoBound queryArea = (GeoBound)sectionBound.Clone();
            queryArea.ScaleDown(60);

            MemoryLayer queryAreaLayer = new MemoryLayer { Name = "QueryAreaLayer" };
            queryAreaLayer.Styles.Add(new FillStyle(GeoColors.Transparent, GeoColor.FromHtml("#9900BCD4"), 4));
            queryAreaLayer.Features.Add(new Feature(queryArea));
            MapContent.AddStaticLayers("SectionOverlay", queryAreaLayer);

            MemoryLayer highlightLayer = new MemoryLayer { Name = "HighlightLayer" };
            highlightLayer.Styles.Add(new FillStyle(GeoColor.FromHtml("#66FFFF00"), GeoColors.White));
            MapContent.AddDynamicLayers("HighlightOverlay", highlightLayer);

            MapContent.ZoomTo(sectionLayer.GetBound());
        }

        private void SpatialQueryButton_Click(object sender, EventArgs e)
        {
            ShapefileLayer sectionLayer = MapContent.FindLayer<ShapefileLayer>("sections-900913");
            MemoryLayer highlightLayer = MapContent.FindLayer<MemoryLayer>("HighlightLayer");
            MemoryLayer queryAreaLayer = MapContent.FindLayer<MemoryLayer>("QueryAreaLayer");
            Geometry queryArea = queryAreaLayer.Features.First().Geometry;
            IEnumerable<Feature> resultFeatures = sectionLayer.Source.SpatialQuery(queryArea, (SpatialQueryMode)Enum.Parse(typeof(SpatialQueryMode), (string)queryOptionComboBox.SelectedItem));
            highlightLayer.Features.Clear();
            foreach (var feature in resultFeatures)
            {
                highlightLayer.Features.Add(feature);
            }

            MapContent.Refresh("HighlightOverlay");
        }
    }
}

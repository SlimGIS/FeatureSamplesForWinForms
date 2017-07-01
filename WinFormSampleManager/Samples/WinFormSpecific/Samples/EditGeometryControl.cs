using SlimGis.MapKit.Geometries;
using SlimGis.MapKit.WinForms;
using System;
using System.Windows.Forms;

namespace SlimGis.Samples
{
    public partial class EditGeometryControl : UserControl
    {
        private MapControl mapContent;

        public EditGeometryControl()
        {
            InitializeComponent();
            mapContent = new MapControl();
        }

        public MapControl MapContent => mapContent;

        private void EditGeometryControl_Load(object sender, EventArgs e)
        {
            MapContent.MapUnit = GeoUnit.Meter;
            MapContent.UseOpenStreetMapAsBaseMap();

            GeoBound bound = (GeoBound)MapContent.MaxBound.Clone();
            bound.ScaleDown(60);
            MapContent.Behaviors.EditBehavior.EditingFeatures.Add(new Feature(bound));

            MapContent.ZoomToFullBound();
        }

        private void SettingCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            MapContent.Behaviors.EditBehavior.CanReshape = reshapeCheckBox.Checked;
            MapContent.Behaviors.EditBehavior.CanResize = resizeCheckBox.Checked;
            MapContent.Behaviors.EditBehavior.CanRotation = rotateCheckBox.Checked;
            MapContent.Behaviors.EditBehavior.CanTranslate = translateCheckBox.Checked;
            MapContent.Behaviors.EditBehavior.Refresh();
        }
    }
}

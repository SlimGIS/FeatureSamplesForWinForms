using SlimGis.MapKit.Controls;
using SlimGis.MapKit.Geometries;
using SlimGis.MapKit.WinForms;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace SlimGis.Samples
{
    public partial class DrawGeometryControl : UserControl
    {
        private MapControl mapContent;

        public DrawGeometryControl()
        {
            InitializeComponent();
            mapContent = new MapControl();
            var trackModes = Enum.GetValues(typeof(TrackMode)).Cast<TrackMode>();
            trackModeComboBox.Items.AddRange(trackModes.Select(t => t.ToString()).ToArray());
            trackModeComboBox.SelectedIndex = (int)MapContent.Behaviors.TrackBehavior.TrackMode;
        }

        public MapControl MapContent => mapContent;

        private void DrawGeometryControl_Load(object sender, EventArgs e)
        {
            MapContent.MapUnit = GeoUnit.Meter;
            MapContent.UseOpenStreetMapAsBaseMap();
            MapContent.ZoomToFullBound();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            MapContent.Behaviors.TrackBehavior.Clear();
            MapContent.Behaviors.TrackBehavior.Refresh();
        }

        private void trackModeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            TrackMode trackMode = (TrackMode)Enum.Parse(typeof(TrackMode), trackModeComboBox.Text);
            MapContent.Behaviors.TrackBehavior.TrackMode = trackMode;
            switch (trackMode)
            {
                case TrackMode.None:
                    descriptionLabel.Text = "";
                    noteLabel.Text = "";
                    break;
                case TrackMode.Point:
                    descriptionLabel.Text = "Draw Point\r\nClick on the map to draw a point.";
                    break;
                case TrackMode.Line:
                    descriptionLabel.Text = "Draw Line\r\nClick on the map to start drawing line. While moving mouse, we could see a line connects between the previous clicked position to the mouse position. When the mouse moves to the target location, click the mouse again to set the second vertex for the line. Then do the same thing like we just did.To complete the drawing operation, double click on the map, the line drawing ends up at the double click location.\r\n\r\nCancel drawing:\r\nPress &quot;ESC&quot; key on the map will cancel the vertex you just drawn. Keep press &quot;ESC&quot; will remove the last vertext till remove the entire geometry you have drawn.";
                    noteLabel.Text = "NOTE: line must end up with at least two vertices.";
                    break;
                case TrackMode.Polygon:
                    descriptionLabel.Text = "Draw Polygon\r\nClick on the map to start drawing polygon. While moving mouse, a dash line connects the previous vertex and the mouse position. Continue clicking to add more vertices. Double click on the map to complete drawing.\r\n\r\nDraw a hole\r\nA hole is an inner ring in the polygon. Press &quot;ALT&quot; key and hold; then the rest steps are the same as drawing another polygon.\r\n\r\nCancel drawing\r\nPress &quot;ESC&quot; key on the map will cancel the vertex you just drawn. Keep press &quot;ESC&quot; will remove the last vertext till remove the entire geometry you have drawn.";
                    noteLabel.Text = "NOTE: polygon must end up with at least three vertices.";
                    break;
                default:
                    break;
            }
        }
    }
}

using SlimGis.MapKit.WinForms;
using System.Windows.Forms;

namespace SlimGis.Samples
{
    public partial class BuildInToolsMapContentControl : UserControl
    {
        public BuildInToolsMapContentControl()
        {
            InitializeComponent();
        }

        public MapControl Map
        {
            get { return mapControl; }
        }

        public ScaleBar ScaleBar
        {
            get { return scaleBar; }
        }

        public ZoomBar ZoomBar
        {
            get { return zoomBar; }
        }

        public ViewportBlock ViewportBlock
        {
            get { return viewportBlock; }
        }
    }
}

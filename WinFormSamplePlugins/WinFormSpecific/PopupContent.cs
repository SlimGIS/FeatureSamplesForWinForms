using System.Drawing;
using System.Windows.Forms;

namespace SlimGis.Samples
{
    public partial class PopupContent : UserControl
    {
        public PopupContent()
        {
            InitializeComponent();
        }

        public string PoiName
        {
            get { return poiNameLabel.Text; }
            set { poiNameLabel.Text = value; }
        }

        public Image PoiIcon
        {
            get { return poiIconPictureBox.Image; }
            set { poiIconPictureBox.Image = value; }
        }

        public string PoiType
        {
            get { return poiTypeLabel.Text; }
            set { poiTypeLabel.Text = value; }
        }

        public string PoiDescription
        {
            get { return poiDescriptionLabel.Text; }
            set { poiDescriptionLabel.Text = value; }
        }
    }
}

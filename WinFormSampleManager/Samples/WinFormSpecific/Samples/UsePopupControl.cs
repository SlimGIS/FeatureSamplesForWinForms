using SlimGis.MapKit.Geometries;
using SlimGis.MapKit.WinForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SlimGis.Samples
{
    public partial class UsePopupControl : UserControl
    {
        private MapControl mapContent;

        public UsePopupControl()
        {
            InitializeComponent();
            mapContent = new MapControl();
            mapContent.MapClick += MapContent_MapClick;
        }

        public MapControl MapContent => mapContent;

        private void UsePopupControl_Load(object sender, EventArgs e)
        {
            MapContent.MapUnit = GeoUnit.Meter;
            MapContent.UseOpenStreetMapAsBaseMap();

            GeoBound currentBound = new GeoBound(1534877.2788, 5720521.3921, 1536797.864, 5721952.8921);
            MapContent.ZoomTo(currentBound);
        }

        private void MapContent_MapClick(object sender, MapMouseEventArgs e)
        {
            PopupContentForm popupContentForm = new PopupContentForm();
            popupContentForm.StartPosition = FormStartPosition.CenterParent;
            if (popupContentForm.ShowDialog() == DialogResult.OK)
            {
                PopupContent popupContent = new PopupContent();
                popupContent.Location = new Point(0, 0);
                popupContent.PoiName = popupContentForm.PoiName;
                popupContent.PoiType = popupContentForm.PoiType;
                popupContent.PoiDescription = popupContentForm.PoiDescription;
                popupContent.PoiIcon = popupContentForm.PoiIcon;

                Popup popup = new Popup();
                popup.Coordinate = e.WorldCoordinate;
                popup.Height = popupContent.Height + 40;
                popup.Width = popupContent.Width;
                popup.Controls.Add(popupContent);

                MapContent.Popups.Add(popup);
            }
        }
    }
}

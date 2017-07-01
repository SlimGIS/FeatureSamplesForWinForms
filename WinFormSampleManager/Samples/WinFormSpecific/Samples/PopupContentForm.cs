using SlimGis.Samples.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SlimGis.Samples
{
    public partial class PopupContentForm : Form
    {
        private Bitmap poiIcon;

        public PopupContentForm()
        {
            InitializeComponent();
            poiIconComboBox.SelectedIndex = 0;
            poiNameTextBox.Text = "New place";
            poiDescriptionTextBox.Text = "Demo: The museum is at the foot of the Bridge, where the first Selma march was stopped on “Bloody Sunday,” March 7, 1965, by law enforcement officers who unleashed tear gas and billy clubs on protesters.";
        }

        public Bitmap PoiIcon => poiIcon;

        public string PoiName => poiNameTextBox.Text;

        public string PoiDescription => poiDescriptionTextBox.Text;

        public string PoiType => poiIconComboBox.Text;

        private void cancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void poiIconComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (poiIconComboBox.SelectedIndex)
            {
                case 0:
                    poiIcon = Resources.Park;
                    break;
                case 1:
                    poiIcon = Resources.Bank;
                    break;
                case 2:
                default:
                    poiIcon = Resources.Sports;
                    break;
            }
        }
    }
}

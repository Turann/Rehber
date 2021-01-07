using System;
using System.Windows.Forms;
using Rehber.DESKTOP.Forms;

namespace Rehber.DESKTOP.MyUserControl
{
    public partial class MyLocationControl : UserControl
    {
        public int locationId { get; set; }
        public MyLocationControl()
        {
            InitializeComponent();
        }

        private void myLocationButton_Click(object sender, EventArgs e)
        {
            Location frm = new Location("other");
            frm.ShowDialog();

            if(frm.DialogResult==DialogResult.OK)
            {
                myLocationText.Text = frm.locationText;
                locationId = frm.locationId;
            }
            else
            {
                locationId = 0;
                locationId = frm.locationId;
            }
        }
    }
}

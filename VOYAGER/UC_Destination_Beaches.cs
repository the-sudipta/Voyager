using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VOYAGER
{
    public partial class UC_Destination_Beaches : UserControl
    {
        public UC_Destination_Beaches()
        {
            InitializeComponent();
        }

        private void panel_coxsbazar_Click(object sender, EventArgs e)
        {
            // Transport
            Tourist.DESTINATION = "CoxsBazar";
            callTransport();
        }

        private void panel_saintmartain_Click(object sender, EventArgs e)
        {
            // Transport
            Tourist.DESTINATION = "SaintMartain";
            callTransport();
        }

        private void panel_chittagong_Click(object sender, EventArgs e)
        {
            // Transport
            Tourist.DESTINATION = "Chittagong";
            callTransport();
        }

        private void panel_patuakhali_Click(object sender, EventArgs e)
        {
            // Transport
            Tourist.DESTINATION = "Patuakhali";
            callTransport();
        }

        private void callTransport()
        {
            Utility.BOOKING.textBox_price.Visible = true;
            Utility.BOOKING.label_transport_color.ForeColor = Color.White; // Setting The Transport Label Color white in the Booking Panel
            UC_Transport uct = new UC_Transport();
            Utility.UCT = uct; // Storing Transport panel object in Utility
            Utility.BOOKING.AddControlsToPanel(uct); // Adding panel to Booking Panel
        }
        

    }
}

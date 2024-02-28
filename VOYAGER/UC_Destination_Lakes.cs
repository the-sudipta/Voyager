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
    public partial class UC_Destination_Lakes : UserControl
    {
        public UC_Destination_Lakes()
        {
            InitializeComponent();
            //lockLabels();
        }

        private void panel_bandarban_Click(object sender, EventArgs e)
        {
            // Transport
            Tourist.DESTINATION = "Bandarban";
            callTransport();
        }

        private void panel_barisal_Click(object sender, EventArgs e)
        {
            // Transport
            Tourist.DESTINATION = "Barisal";
            callTransport();
        }

        private void panel_rangamati_Click(object sender, EventArgs e)
        {
            // Transport
            Tourist.DESTINATION = "Rangamati";
            callTransport();
        }

        private void panel_moulovibazar_Click(object sender, EventArgs e)
        {
            // Transport
            Tourist.DESTINATION = "Moulovibazar";
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

        private void lockLabels()
        {
            Utility.BOOKING.label_transport_color.Enabled = false;
            Utility.BOOKING.label_hotel_color.Enabled = false;
            Utility.BOOKING.label_payment_color.Enabled = false;
        }
    }
}

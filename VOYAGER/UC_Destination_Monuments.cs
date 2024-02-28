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
    public partial class UC_Destination_Monuments : UserControl
    {
        public UC_Destination_Monuments()
        {
            InitializeComponent();
        }

        private void panel_dhaka_Click(object sender, EventArgs e)
        {
            // Transport
            Tourist.DESTINATION = "Dhaka";
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

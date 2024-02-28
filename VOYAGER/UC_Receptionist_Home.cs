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
    public partial class UC_Receptionist_Home : UserControl
    {
        public UC_Receptionist_Home()
        {
            InitializeComponent();
        }

        private void panel_tours_Click(object sender, EventArgs e)
        {
            Utility.RECCEPTIONIST.Hide();
            Booking_Order_Panel booking = new Booking_Order_Panel();
            Utility.BOOKING = booking;
            booking.Show();
        }


        private void panel_destinations_Click(object sender, EventArgs e)
        {
            UC_Admin_Destination ucad = new UC_Admin_Destination();
            Utility.UCAD = ucad;
            Utility.RECCEPTIONIST.label_title.Text = "DESTINATIONS";

            Utility.UCAD.button_add.Visible = false;
            Utility.UCAD.button_update.Visible = false;
            Utility.UCAD.button_delete.Visible = false;

            Utility.RECCEPTIONIST.AddControlsToPanel(ucad);
            Utility.RECCEPTIONIST.button_logout.Text = "BACK";
        }

        private void panel_hotel_Click(object sender, EventArgs e)
        {
            UC_Admin_Hotel ucaho = new UC_Admin_Hotel();
            Utility.UCAHO = ucaho;
            Utility.RECCEPTIONIST.label_title.Text = "HOTELS";

            ucaho.button_add.Visible = false;
            ucaho.button_update.Visible = false;
            ucaho.button_delete.Visible = false;

            Utility.RECCEPTIONIST.AddControlsToPanel(ucaho);
            Utility.RECCEPTIONIST.button_logout.Text = "BACK";
        }

        private void panel_transport_Click(object sender, EventArgs e)
        {
            UC_Admin_Transport ucat = new UC_Admin_Transport();
            Utility.UCAT = ucat;
            Utility.RECCEPTIONIST.label_title.Text = "TRANSPORTS";

            ucat.button_add.Visible = false;
            ucat.button_update.Visible = false;
            ucat.button_delete.Visible = false;

            Utility.RECCEPTIONIST.AddControlsToPanel(ucat);
            Utility.RECCEPTIONIST.button_logout.Text = "BACK";

        }

        private void panel_clientList_Click(object sender, EventArgs e)
        {
            UC_Admin_Client ucac = new UC_Admin_Client();
            Utility.UCAC = ucac;
            Utility.RECCEPTIONIST.label_title.Text = "CLIENT LIST";

            Utility.RECCEPTIONIST.AddControlsToPanel(ucac);
            Utility.RECCEPTIONIST.button_logout.Text = "BACK";

        }

        private void panel_allHistory_Click(object sender, EventArgs e)
        {
            Utility.all_History_panel_Shifter = 1;
            
            UC_Admin_AllHistory ucaah = new UC_Admin_AllHistory();
            Utility.UCAAH = ucaah;
            Utility.RECCEPTIONIST.label_title.Text = "ALL HISTORY";

            Utility.RECCEPTIONIST.AddControlsToPanel(ucaah);
            Utility.RECCEPTIONIST.button_logout.Text = "BACK";
        }
    }
}

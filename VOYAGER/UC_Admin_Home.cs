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
    public partial class UC_Admin_Home : UserControl
    {
        public UC_Admin_Home()
        {
            InitializeComponent();
        }

        private void panel_earnings_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Current Total Earnings = "+Tourist.TOTAL_COST);
            //Utility.ADMIN.button_logout.Text = "BACK";
        }

        private void panel_tours_Click(object sender, EventArgs e)
        {
            UC_Admin_Tour ucato = new UC_Admin_Tour();
            Utility.UCATo = ucato;
            Utility.ADMIN.AddControlsToPanel(ucato);
            Utility.ADMIN.label_panelName.Text = "TOURS";
            Utility.ADMIN.button_logout.Text = "BACK";
        }

        private void panel_staffs_Click(object sender, EventArgs e)
        {
            UC_Admin_Staff ucas = new UC_Admin_Staff();
            Utility.UCAS = ucas;
            Utility.ADMIN.label_panelName.Text = "STAFFS";
            Utility.ADMIN.AddControlsToPanel(ucas);
            Utility.ADMIN.button_logout.Text = "BACK";
        }

        private void panel_clientList_Click(object sender, EventArgs e)
        {
            UC_Admin_Client ucac = new UC_Admin_Client();
            Utility.UCAC = ucac;
            Utility.ADMIN.label_panelName.Text = "CLIENTS";
            Utility.ADMIN.AddControlsToPanel(ucac);
            Utility.ADMIN.button_logout.Text = "BACK";
        }

        private void panel_hotel_Click(object sender, EventArgs e)
        {
            UC_Admin_Hotel ucaho = new UC_Admin_Hotel();
            Utility.UCAHO = ucaho;
            Utility.ADMIN.label_panelName.Text = "HOTEL";
            Utility.ADMIN.AddControlsToPanel(ucaho);
            Utility.ADMIN.button_logout.Text = "BACK";
        }

        private void panel_transport_Click(object sender, EventArgs e)
        {
            UC_Admin_Transport ucat = new UC_Admin_Transport();
            Utility.UCAT = ucat;
            Utility.ADMIN.label_panelName.Text = "TRANSPORTS";
            Utility.ADMIN.AddControlsToPanel(ucat);
            Utility.ADMIN.button_logout.Text = "BACK";
        }

        private void panel_destination_Click(object sender, EventArgs e)
        {
            UC_Admin_Destination ucad = new UC_Admin_Destination();
            Utility.UCAD = ucad;
            Utility.ADMIN.label_panelName.Text = "DESTINATIONS";
            Utility.ADMIN.AddControlsToPanel(ucad);
            Utility.ADMIN.button_logout.Text = "BACK";
        }

        private void panel_allHistory_Click(object sender, EventArgs e)
        {
            Utility.all_History_panel_Shifter = 0;
            UC_Admin_AllHistory ucaah = new UC_Admin_AllHistory();
            Utility.UCAAH = ucaah;
            Utility.ADMIN.AddControlsToPanel(ucaah);
            Utility.ADMIN.label_panelName.Text = "ALL HISTORY";
            Utility.ADMIN.button_logout.Text = "BACK";
        }

        
    }
}

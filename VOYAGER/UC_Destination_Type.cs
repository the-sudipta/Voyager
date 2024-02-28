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
    public partial class UC_Destination_Type : UserControl
    {
        public UC_Destination_Type()
        {
            InitializeComponent();
            //lockLabels();
        }

        private void panel_historical_Click(object sender, EventArgs e)
        {
            UC_Destination_Historical ucdhist = new UC_Destination_Historical();
            Utility.UCDHIST = ucdhist;
            Utility.BOOKING.AddControlsToPanel(ucdhist);
            Tourist.DESTINATION_TYPE = "HISTORICAL";
        }

        private void panel_hillStation_Click(object sender, EventArgs e)
        {
            UC_Destination_HillStation ucdh = new UC_Destination_HillStation();
            Utility.UCDH = ucdh;
            Utility.BOOKING.AddControlsToPanel(ucdh);
            Tourist.DESTINATION_TYPE = "HILLSTATION";
        }

        private void panel_forest_Click(object sender, EventArgs e)
        {
            UC_Destination_Forest ucdf = new UC_Destination_Forest();
            Utility.BOOKING.AddControlsToPanel(ucdf);
            Utility.UCDF = ucdf;
            Tourist.DESTINATION_TYPE = "FOREST";
        }

        private void panel_beach_Click(object sender, EventArgs e)
        {
            UC_Destination_Beaches ucdb = new UC_Destination_Beaches();
            Utility.UCDB = ucdb;
            Utility.BOOKING.AddControlsToPanel(ucdb);
            Tourist.DESTINATION_TYPE = "BEACH";
        }

        private void panel_lakes_Click(object sender, EventArgs e)
        {
            UC_Destination_Lakes ucdl = new UC_Destination_Lakes();
            Utility.UCDL = ucdl;
            Utility.BOOKING.AddControlsToPanel(ucdl);
            Tourist.DESTINATION_TYPE = "LAKES";
        }

        private void panel_monuments_Click(object sender, EventArgs e)
        {
            UC_Destination_Monuments ucdm = new UC_Destination_Monuments();
            Utility.UCDM = ucdm;
            Utility.BOOKING.AddControlsToPanel(ucdm);
            Tourist.DESTINATION_TYPE = "MONUMENTS";
        }

        private void lockLabels()
        {
            Utility.BOOKING.label_transport_color.Enabled = false;
            Utility.BOOKING.label_hotel_color.Enabled = false;
            Utility.BOOKING.label_payment_color.Enabled = false;
        }
    }
}

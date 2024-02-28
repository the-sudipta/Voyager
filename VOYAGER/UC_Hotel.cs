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
    public partial class UC_Hotel : UserControl
    {
        public UC_Hotel()
        {
            InitializeComponent();
            //lockLabels();
        }

        private void button_singleBed_Click(object sender, EventArgs e)
        {
            Tourist.HOTELROOM = "Single Bed";
            Tourist.hotelCost = Tourist.singleBedCost;
            Utility.BOOKING.textBox_price.Text = Convert.ToString((Tourist.TotalCost()));
            callPayment();
        }

        private void button_suite_Click(object sender, EventArgs e)
        {
            Tourist.HOTELROOM = "Single Suite";
            Tourist.hotelCost = Tourist.suiteBedCost;
            Utility.BOOKING.textBox_price.Text = Convert.ToString((Tourist.TotalCost()));
            callPayment();
        }

        private void button_packageSpecial_Click(object sender, EventArgs e)
        {
            Tourist.HOTELROOM = "Resort";
            Tourist.hotelCost = Tourist.resortCost;
            Utility.BOOKING.textBox_price.Text = Convert.ToString((Tourist.TotalCost()));
            callPayment();
        }

        private void callPayment()
        {
            Utility.BOOKING.label_payment_color.ForeColor = Color.White;
            UC_Payment ucp = new UC_Payment();
            Utility.UCP = ucp;
            Utility.BOOKING.AddControlsToPanel(ucp);
        }

        private void lockLabels()
        {
            Utility.BOOKING.label_payment_color.Enabled = false;
        }
    }
}

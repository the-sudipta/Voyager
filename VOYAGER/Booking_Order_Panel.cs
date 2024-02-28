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
    public partial class Booking_Order_Panel : Form
    {



        public void AddControlsToPanel(Control c) // This Will Help to add the User Controls on the specific panel (Here Named panelControls)
        {
            if(c != null)
            {
                // Set The specific panel to the position where it will show up whenever that specific button will be clicked
                panelControls.Controls.Clear(); // Clearing Previous UserConrtols
                c.Dock = DockStyle.Fill;
                c.BringToFront();
                c.Focus();
                panelControls.Controls.Add(c);
            }
            else
            {
                MessageBox.Show("Do Not Jump. Just Go Linearly");
                Console.WriteLine("Color Gray");
                Utility.BOOKING.label_hotel_color.ForeColor = Color.DarkGray;
                Utility.BOOKING.label_payment_color.ForeColor = Color.DarkGray;
                Utility.BOOKING.label_transport_color.ForeColor = Color.DarkGray;
            }
        }





        private void Booking_Order_Panel_Load(object sender, EventArgs e)// Act as InitializeComponent2();
        {
            label_destination_color.ForeColor = Color.White;
            UC_Destination_Type ucdt = new UC_Destination_Type();
            Utility.UCDT = ucdt;
            AddControlsToPanel(ucdt);

        }

        public Booking_Order_Panel()
        {
            InitializeComponent();
        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Utility.RECCEPTIONIST.Show();
        }

        
        private void roundPictureBox_search_Click(object sender, EventArgs e)
        {
            string search_Type = textBox_search.Text.ToLower();
            if (search_Type.Contains("username") || search_Type.Contains("password"))
            {
                MessageBox.Show("Sorry!! You don't have the acccess");
            }
            else
            {
                string[] searchItem = new string[3];
                searchItem = textBox_search.Text.Split(',');
                Search_Gridview sg = new Search_Gridview();
                Search_Gridview.coloumnName = searchItem[0];
                Search_Gridview.itemName = searchItem[1];
                sg.showData();
                sg.Show();
            }

            textBox_search.Text = "";
        }

        private void pictureBox_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label_destination_color_Click(object sender, EventArgs e)
        {
            if(Utility.UCDT != null)
            {
                AddControlsToPanel(Utility.UCDT);
                Utility.BOOKING.label_destination_color.ForeColor = Color.White;
                Utility.BOOKING.label_transport_color.ForeColor = Color.DarkGray;
                Utility.BOOKING.label_hotel_color.ForeColor = Color.DarkGray;
                Utility.BOOKING.label_payment_color.ForeColor = Color.DarkGray;
            }
        }

        private void label_transport_color_Click(object sender, EventArgs e)
        {
           if(Utility.UCT  != null)
           {
                AddControlsToPanel(Utility.UCT);
                Utility.BOOKING.label_transport_color.ForeColor = Color.White;
                Utility.BOOKING.label_hotel_color.ForeColor = Color.DarkGray;
                Utility.BOOKING.label_payment_color.ForeColor = Color.DarkGray;
                Utility.BOOKING.textBox_price.Text = Convert.ToString(Tourist.TotalCost());
           }
        }

        private void label_hotel_color_Click(object sender, EventArgs e)
        {
            if(Utility.UCH != null)
            {
                AddControlsToPanel(Utility.UCH);
                Utility.BOOKING.label_hotel_color.ForeColor = Color.White;
                Utility.BOOKING.label_payment_color.ForeColor = Color.DarkGray;
                Utility.BOOKING.textBox_price.Text = Convert.ToString(Tourist.TotalCost());
            }
        }

        private void label_payment_color_Click(object sender, EventArgs e)
        {
            if(Utility.UCP != null)
            {
                AddControlsToPanel(Utility.UCP);
                Utility.BOOKING.label_payment_color.ForeColor = Color.White;
                Utility.BOOKING.textBox_price.Text = Convert.ToString(Tourist.TotalCost());
            }
        }
    }
}

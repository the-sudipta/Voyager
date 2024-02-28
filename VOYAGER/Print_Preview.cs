using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VOYAGER
{
    public partial class Print_Preview : Form
    {
        public Print_Preview()
        {
            InitializeComponent();
        }

        private void Print_Preview_Load(object sender, EventArgs e)
        {
            label_invoiceNumber.Text = randomInvoiceNumberGenerator();
            label_date.Text = DateTime.Now.ToString("d/M/yyyy");
            fetchData();
        }


        private string randomInvoiceNumberGenerator()
        {
            string number = "";
            Random random = new Random();
            for(int i = 0; i < 10; i++)
            {
                number = number + Convert.ToString(random.Next(0,9));
            }
            return number;
        }

        private void fetchData()
        {
            label_name.Text = Tourist.TOURIST_NAME;
            label_phone.Text = Tourist.PHONENUMBER;
            label_email.Text = Tourist.EMAIL;
            label_nid.Text = Tourist.NID;
            label_member.Text = Tourist.MEMBERS;
            label_travel_date.Text = Tourist.TOUR_DATE;
            label_destination.Text = Tourist.DESTINATION;
            label_transport.Text = Tourist.VEHICLENAME;
            label_room.Text = Tourist.HOTELROOM;
            label_totalCost.Text = Convert.ToString(Tourist.TOTAL_COST);
        }
        
                private void print(Panel pnl)
                {
                    PrinterSettings ps = new PrinterSettings();
                    panel_print = pnl;
                    getPrintArea(pnl);
                    printPreviewDialog_panel.Document = printDocument_panel;
                    printDocument_panel.PrintPage += new PrintPageEventHandler(printDocument_panel_PrintPage);
                    printPreviewDialog_panel.ShowDialog();
                }

                private Bitmap memorying;

                private void getPrintArea(Panel pnl)
                {
                    memorying = new Bitmap(pnl.Width+0, pnl.Height);
                    pnl.DrawToBitmap(memorying, new Rectangle(0, 0, pnl.Width+0, pnl.Height));
                }

                private void printDocument_printPage(object sender, PrintPageEventArgs e)
                {
                    Rectangle pageArea = e.PageBounds;
                    e.Graphics.DrawImage(memorying, ((pageArea.Width / 2)+0) - ((this.panel_print.Width / 2)+60), this.panel_print.Location.Y);
                }
        



        


        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            this.Close();
            Utility.RECCEPTIONIST.AddControlsToPanel(Utility.UCRH);
            Utility.RECCEPTIONIST.Show();
        }

        private void printDocument_panel_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pageArea = e.PageBounds;
            e.Graphics.DrawImage(memorying, ((pageArea.Width / 2) + 0) - (this.panel_print.Width / 2), this.panel_print.Location.Y);
        }


        private void pictureBox_print_Click(object sender, EventArgs e)
        {
            this.Hide();
            print(panel_print);

            Utility.RECCEPTIONIST.AddControlsToPanel(Utility.UCRH);
            Utility.RECCEPTIONIST.Show();
        }

        
    }
}

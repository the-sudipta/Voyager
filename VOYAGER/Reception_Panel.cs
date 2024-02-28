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
    public partial class Reception_Panel : Form
    {

        private void Reception_Panel_Load(object sender, EventArgs e)
        {
            UC_Receptionist_Home ucrh = new UC_Receptionist_Home();
            Utility.UCRH = ucrh;
            AddControlsToPanel(ucrh);
            textBox_search.Width = 309;
        }

        public Reception_Panel()
        {
            InitializeComponent();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            
            if (button_logout.Text.Contains("LOG OUT"))
            {
                this.Hide();
                Login_Panel login = new Login_Panel();
                Utility.LOGIN = login;
                login.Show();
            }
            else
            {
                AddControlsToPanel(Utility.UCRH);
                button_logout.Text = "LOG OUT";
                label_title.Text = "RECEPTIONIST PANEL";
            }
        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                try
                {
                    string[] searchItem = new string[3];
                    searchItem = textBox_search.Text.Split(',');
                    Search_Gridview sg = new Search_Gridview();
                    Search_Gridview.coloumnName = searchItem[0];
                    Search_Gridview.itemName = searchItem[1];
                    sg.showData();
                    sg.Show();
                }catch (Exception ex)
                {
                    MessageBox.Show("Please write something to search first. Error = "+ex.Message);
                }
            }

            textBox_search.Text = "";
        }

        private void pictureBox_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public void AddControlsToPanel(Control c) // This Will Help to add the User Controls on the specific panel (Here Named panelControls)
        {
            if (c != null)
            {
                // Set The specific panel to the position where it will show up whenever that specific button will be clicked
                panelControls.Controls.Clear(); // Clearing Previous UserConrtols
                c.Dock = DockStyle.Fill;
                c.BringToFront();
                c.Focus();
                panelControls.Controls.Add(c);
            }
        }

        private void pictureBox_message_Click(object sender, EventArgs e)
        {
            UC_Message ucm = new UC_Message();
            Utility.UCM = ucm;
            Utility.RECCEPTIONIST.label_title.Text = "MESSAGING";
            Utility.RECCEPTIONIST.button_logout.Text = "BACK";
            AddControlsToPanel(ucm);

        }
    }
}

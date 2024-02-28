using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace VOYAGER
{
    public partial class Admin_panel : Form
    {

        

        #region Properties

        #endregion Properties


        private void Admin_panel_Load(object sender, EventArgs e) // Act as InitializeComponent2(); => User Defined Constructor
        {
            UC_Admin_Home ucah = new UC_Admin_Home();
            Utility.UCAH = ucah;
            AddControlsToPanel(ucah);
        }


        public Admin_panel()
        {
            InitializeComponent();
        }


        #region Form Methods
        private void pictureBox_close_Click(object sender, EventArgs e){Application.Exit(); } // Application Will be closed if we Press The close Button

        private void button_logout_Click(object sender, EventArgs e)
        {
            if(button_logout.Text .Contains("LOG OUT"))
            {
                this.Hide();
                Login_Panel login = new Login_Panel();
                login.Show();
            }
            else
            {
                AddControlsToPanel(Utility.UCAH);
                button_logout.Text = "LOG OUT";
                label_panelName.Text = "ADMIN PANEL";
            }
        }

        private void pictureBox_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

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
        }






        #endregion Form Methods

        private void roundPictureBox_search_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Sorry !! This Feature is PREMIUM");
            if (Utility.IS_ADMIN != true)
            {
                if (textBox_search.Text.ToLower() != "" && textBox_search.Text.ToLower() != "username" && textBox_search.Text.ToLower() != "password")
                {
                    string[] searchItem = new string[3];
                    searchItem = textBox_search.Text.Split(',');
                    Search_Gridview sg = new Search_Gridview();
                    Search_Gridview.coloumnName = searchItem[0];
                    Search_Gridview.itemName = searchItem[1];
                    sg.showData();
                    sg.Show();
                }
            }
            else if (Utility.IS_ADMIN == true)
            {
                try
                {
                    string[] searchItem = new string[3];
                    searchItem = textBox_search.Text.Split(',');
                    Search_Gridview sg = new Search_Gridview();
                    Search_Gridview.coloumnName = searchItem[0];
                    Search_Gridview.itemName = searchItem[1];
                    sg.Show();
                    sg.showData();
                }catch (Exception ex)
                {
                    MessageBox.Show("Please write something to search first. Error = "+ex.Message);
                }

            }

            textBox_search.Text = "";
        }

        private void pictureBox_message_Click(object sender, EventArgs e)
        {
            UC_Message ucm = new UC_Message();
            Utility.UCM = ucm;
            Utility.ADMIN.label_panelName.Text = "MESSAGING";
            Utility.ADMIN.button_logout.Text = "BACK";
            AddControlsToPanel(ucm);
        }
    }
}

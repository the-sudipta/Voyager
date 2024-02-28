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
    public partial class Manager_Panel : Form
    {
        public Manager_Panel()
        {
            InitializeComponent();
        }

        private void Manager_Panel_Load(object sender, EventArgs e)
        {

        }

        private void roundPictureBox_search_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry This Feature is Unavailable !!");
            textBox_search.Text = "";
        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Panel login = new Login_Panel();
            login.Show();
        }

        private void pictureBox_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

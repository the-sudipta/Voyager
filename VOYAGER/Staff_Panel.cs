﻿using System;
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
    public partial class Staff_Panel : Form
    {
        public Staff_Panel()
        {
            InitializeComponent();
        }

        private void roundPicturech1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sorry This Feature is Unavailable !!");
            textBox_search.Text = "";
        }

        private void pictureBox_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button_logout_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login_Panel login = new Login_Panel();
            Utility.LOGIN = login;
            login.Show();
        }
    }
}

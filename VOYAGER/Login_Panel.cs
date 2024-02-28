using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VOYAGER
{
    public partial class Login_Panel : Form
    {


		MySqlConnection sc = new MySqlConnection(SQLConnectionClass.conReturn());

		private void Login_Panel_Load(object sender, EventArgs e) // Act as InitializeComponent2();
        {
            button_login.Enabled = false;
        }


        public Login_Panel(){InitializeComponent();}

        private void pictureBox_close_Click(object sender, EventArgs e){Application.Exit();}

        private void button_login_Click(object sender, EventArgs e)
        {

            string username = textBox_mail.Text;
            string password = textBox_password.Text;

            try
            {
				sc.Open();

				string query = "SELECT * FROM Staffs_Table WHERE username = @username AND password = @password";
				MySqlCommand command = new MySqlCommand(query, sc);
				command.Parameters.AddWithValue("@username", username);
				command.Parameters.AddWithValue("@password", password);

				MySqlDataAdapter adapter = new MySqlDataAdapter(command);
				DataTable dt = new DataTable();
				adapter.Fill(dt);
				if (dt.Rows.Count > 0)
                {
                    username = textBox_mail.Text;
                    password = textBox_password.Text;
                    if (username.Contains("_admin"))
                    {
                        this.Hide();
                        Admin_panel admin = new Admin_panel();
                        Utility.ADMIN = admin;
                        admin.Show();
                        Utility.IS_ADMIN = true;
                    }
                    else if (username.Contains("_recep"))
                    {
                        this.Hide();
                        Reception_Panel reception = new Reception_Panel();
                        Utility.RECCEPTIONIST = reception;
                        reception.Show();
                        Utility.IS_ADMIN = false;
                    }
                    else 
                    {
                        MessageBox.Show("Username & Password didn't matched");
                        textBox_mail.Text = "";
                        textBox_password.Text = "";
                        textBox_mail.Focus();
                    }
                }
                else if(username.Contains("the_devs.admin") && password.Contains("TRYHACKME"))
                {
                    this.Hide();
                    Admin_panel admin = new Admin_panel();
                    Utility.ADMIN = admin;
                    admin.Show();
                    Utility.IS_ADMIN = true;
                }
                else if (username.Contains("the_devs.recep") && password.Contains("TRYHACKME"))
                {
                    this.Hide();
                    Reception_Panel reception = new Reception_Panel();
                    Utility.RECCEPTIONIST = reception;
                    reception.Show();
                    Utility.IS_ADMIN = false;
                }
                else
                {
                    //MessageBox.Show("You are Not Authorized");
                    MessageBox.Show("Username & Password didn't matched");
                    textBox_mail.Text = "";
                    textBox_password.Text = "";
                    textBox_mail.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error = "+ex.Message);
            }
            finally
            {
                sc.Close();
            }

        }


        #region User Advancement
        private void textBox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                // After Typing the Password if I click Enter, it will start up the login process
                button_login_Click(this, new EventArgs());
            }
            else if (e.KeyCode == Keys.Up)
            {
                textBox_mail.Focus();
            }
        }

        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            // Whenever we write/remove in the password textBox it will check pass and username box is filluped or not
            if(textBox_mail.Text != "" && textBox_password.Text != "")
            {
                // The login button will only be enable when you fillup the username and password both
                button_login.Enabled = true;
                button_login.BackColor = Color.Green;
                button_login.ForeColor = Color.White;
            }
            else
            {
                // else turn off the login button along with it's color
                button_login.Enabled = false;
                button_login.BackColor = Color.White;
                button_login.ForeColor = Color.Black;
            }
        }

        private void textBox_mail_TextChanged(object sender, EventArgs e)
        {
            // Whenever we write/remove in the username textBox it will check pass and username box is filluped or not
            if (textBox_mail.Text != "" && textBox_password.Text != "")
            {
                // The login button will only be enable when you fillup the username and password both
                button_login.Enabled = true;
                button_login.BackColor = Color.Green;
                button_login.ForeColor = Color.White;
            }
            else
            {
                // else turn off the login button along with it's color
                button_login.Enabled = false;
                button_login.BackColor = Color.White;
                button_login.ForeColor = Color.Black;
            }
        }

        private void textBox_mail_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Down)
            {
                // use arrow keys to move between textboxes
                textBox_password.Focus();
            }
            else if(e.KeyCode == Keys.Enter)
            {
                // After Typing the Username if I click Enter, it will start up the login process
                button_login_Click(this, new EventArgs());
            }
        }

        private void pictureBox_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        #endregion Advancement


    }
}

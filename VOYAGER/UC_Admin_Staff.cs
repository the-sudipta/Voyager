using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VOYAGER
{
	public partial class UC_Admin_Staff : UserControl
	{
		MySqlConnection sc = new MySqlConnection(SQLConnectionClass.conReturn());// Connection String
		string staffIndicator;
		string staffUsername;
		string staffPassword;
		string stafEarnings;

		public UC_Admin_Staff()
		{
			InitializeComponent();
			showData();
		}

		private void button_add_Click(object sender, EventArgs e)
		{
			fetchData();

			MySqlCommand sm = new MySqlCommand("INSERT INTO Staffs_Table (username,password,earnings) VALUES(@username, @password, @earnings)", sc);
			sm.Parameters.AddWithValue("@username", staffUsername);
			sm.Parameters.AddWithValue("@password", staffPassword);
			sm.Parameters.AddWithValue("@earnings", stafEarnings);

			sc.Open();
			sm.ExecuteNonQuery();
			sc.Close();
			//MessageBox.Show("Data Saved Successfully");
			showData();
			textBox_username.Text = "";
			textBox_password.Text = "";
			textBox_earnings.Text = "";
			textBox_username.Focus();
		}

		private void button_update_Click(object sender, EventArgs e)
		{
			try
			{
				string staff_Username = textBox_username.Text;
				string staff_Indicator = staffUsername;
				string staff_Password = textBox_password.Text;
				string staf_Earnings = textBox_earnings.Text;

				MySqlCommand cmd = new MySqlCommand("UPDATE Staffs_Table SET username = @username, password = @password, earnings = @earnings WHERE username = @indicator", sc);
				cmd.Parameters.AddWithValue("@username", staff_Username);
				cmd.Parameters.AddWithValue("@password", staff_Password);
				cmd.Parameters.AddWithValue("@earnings", staf_Earnings);
				cmd.Parameters.AddWithValue("@indicator", staff_Indicator);

				sc.Open();
				cmd.ExecuteNonQuery();
				sc.Close();
				//MessageBox.Show("Data Updated Successfully");
				showData();
				textBox_username.Text = "";
				textBox_password.Text = "";
				textBox_earnings.Text = "";
				textBox_username.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

		private void button_delete_Click(object sender, EventArgs e)
		{
			try
			{
				string username = textBox_username.Text;
				MySqlCommand cmd = new MySqlCommand("DELETE FROM Staffs_Table WHERE username = @username", sc);
				cmd.Parameters.AddWithValue("@username", username);

				sc.Open();
				cmd.ExecuteNonQuery();
				sc.Close();
				//MessageBox.Show("Data Removed Successfully");
				showData();
				textBox_username.Text = "";
				textBox_password.Text = "";
				textBox_earnings.Text = "";
				textBox_username.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

		private void fetchData()
		{
			staffUsername = textBox_username.Text;
			staffIndicator = staffUsername;
			staffPassword = textBox_password.Text;
			stafEarnings = textBox_earnings.Text;
		}

		private void showData()
		{
			try
			{
				MySqlCommand cmd = new MySqlCommand("SELECT username,password,earnings FROM Staffs_Table", sc);
				sc.Open();
				var reader = cmd.ExecuteReader();
				DataTable table = new DataTable();
				table.Load(reader);
				dataGridView_staff.DataSource = table;
				sc.Close();
				textBox_username.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

		private void dataGridView_staff_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			// It will make sure to show the data which is selected, in a component 
			staffUsername = dataGridView_staff.SelectedRows[0].Cells[0].Value.ToString();
			staffIndicator = staffUsername;
			staffPassword = dataGridView_staff.SelectedRows[0].Cells[1].Value.ToString();
			stafEarnings = dataGridView_staff.SelectedRows[0].Cells[2].Value.ToString();

			textBox_username.Text = staffUsername;
			textBox_password.Text = staffPassword;
			textBox_earnings.Text = stafEarnings;
		}
	}
}

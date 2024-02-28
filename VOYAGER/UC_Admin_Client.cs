using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VOYAGER
{
	public partial class UC_Admin_Client : UserControl
	{
		MySqlConnection sc = new MySqlConnection(SQLConnectionClass.conReturn());
		string clientName;
		string tour_date;

		public UC_Admin_Client()
		{
			InitializeComponent();
			showData();
		}

		private void button_add_Click(object sender, EventArgs e)
		{
			try
			{
				string name = textBox_name.Text;
				string phone = textBox_phone.Text;
				string mail = textBox_mail.Text;
				string nid = textBox_nid.Text;
				string member = textBox_member.Text;
				string date = textBox_date.Text;
				string destination = textBox_destination.Text;
				string transport = textBox_transport.Text;

				string client = textBox_name.Text;
				clientName = client;
				Console.WriteLine("Client ADD = " + client);
				MySqlCommand sm = new MySqlCommand("INSERT INTO Client_Table (name, phone, mail, nid, member, date, destination, transport) VALUES(@name, @phone, @mail, @nid, @member, @date, @destination, @transport)", sc);
				sm.Parameters.AddWithValue("@name", name);
				sm.Parameters.AddWithValue("@phone", phone);
				sm.Parameters.AddWithValue("@mail", mail);
				sm.Parameters.AddWithValue("@nid", nid);
				sm.Parameters.AddWithValue("@member", member);
				sm.Parameters.AddWithValue("@date", date);
				sm.Parameters.AddWithValue("@destination", destination);
				sm.Parameters.AddWithValue("@transport", transport);

				sc.Open();
				sm.ExecuteNonQuery();
				sc.Close();

				showData();
				clearTextBoxes();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

		private void button_update_Click(object sender, EventArgs e)
		{
			try
			{
				MySqlCommand cmd = new MySqlCommand("UPDATE Client_Table SET " +
				"name = @name, " +
				"phone = @phone," +
				"mail = @mail, " +
				"nid = @nid, " +
				"member = @member, " +
				"date = @date, " +
				"destination = @destination, " +
				"transport = @transport WHERE name = @clientName", sc);

				cmd.Parameters.AddWithValue("@name", textBox_name.Text);
				cmd.Parameters.AddWithValue("@phone", textBox_phone.Text);
				cmd.Parameters.AddWithValue("@mail", textBox_mail.Text);
				cmd.Parameters.AddWithValue("@nid", textBox_nid.Text);
				cmd.Parameters.AddWithValue("@member", textBox_member.Text);
				cmd.Parameters.AddWithValue("@date", textBox_date.Text);
				cmd.Parameters.AddWithValue("@destination", textBox_destination.Text);
				cmd.Parameters.AddWithValue("@transport", textBox_transport.Text);
				cmd.Parameters.AddWithValue("@clientName", clientName);

				sc.Open();
				cmd.ExecuteNonQuery();
				sc.Close();

				showData();
				clearTextBoxes();
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
				MySqlCommand cmd = new MySqlCommand("DELETE FROM Client_Table WHERE name = @name", sc);
				MySqlCommand cmd2 = new MySqlCommand("DELETE FROM Tour_Table WHERE tours = @date", sc);

				cmd.Parameters.AddWithValue("@name", textBox_name.Text);
				cmd2.Parameters.AddWithValue("@date", textBox_date.Text);

				sc.Open();
				cmd.ExecuteNonQuery();
				cmd2.ExecuteNonQuery();
				sc.Close();

				showData();
				clearTextBoxes();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

		private void showData()
		{
			try
			{
				MySqlCommand cmd = new MySqlCommand("SELECT name, phone, mail, nid, member, date, destination, transport FROM Client_Table", sc);
				sc.Open();
				MySqlDataReader reader = cmd.ExecuteReader();
				DataTable table = new DataTable();
				table.Load(reader);
				dataGridView_client.DataSource = table;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
			finally
			{
				sc.Close();
			}
		}

		private void clearTextBoxes()
		{
			textBox_name.Text = "";
			textBox_phone.Text = "";
			textBox_mail.Text = "";
			textBox_nid.Text = "";
			textBox_member.Text = "";
			textBox_date.Text = "";
			textBox_destination.Text = "";
			textBox_transport.Text = "";
		}

		private void dataGridView_client_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dataGridView_client.Rows[e.RowIndex];
				clientName = row.Cells["name"].Value.ToString();
				textBox_name.Text = clientName;
				textBox_phone.Text = row.Cells["phone"].Value.ToString();
				textBox_mail.Text = row.Cells["mail"].Value.ToString();
				textBox_nid.Text = row.Cells["nid"].Value.ToString();
				textBox_member.Text = row.Cells["member"].Value.ToString();
				textBox_date.Text = row.Cells["date"].Value.ToString();
				tour_date = textBox_date.Text;
				textBox_destination.Text = row.Cells["destination"].Value.ToString();
				textBox_transport.Text = row.Cells["transport"].Value.ToString();
			}
		}
	}
}

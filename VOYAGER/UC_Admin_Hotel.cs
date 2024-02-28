using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VOYAGER
{
	public partial class UC_Admin_Hotel : UserControl
	{
		MySqlConnection sc = new MySqlConnection(SQLConnectionClass.conReturn());// Connection String
		string hotelName;

		public UC_Admin_Hotel()
		{
			InitializeComponent();
			showData();
		}

		private void button_add_Click(object sender, EventArgs e)
		{
			string hotel = textBox_hotel.Text;
			hotelName = hotel;
			Console.WriteLine("Destination = " + hotel);
			MySqlCommand sm = new MySqlCommand("INSERT INTO Hotel_Table (hotel) VALUES(@hotel)", sc);
			sm.Parameters.AddWithValue("@hotel", hotel);
			sc.Open();
			sm.ExecuteNonQuery();
			sc.Close();
			//MessageBox.Show("Data Saved Successfully");
			showData();
			textBox_hotel.Text = "";
			textBox_hotel.Focus();
		}

		private void button_update_Click(object sender, EventArgs e)
		{
			MySqlCommand cmd = new MySqlCommand("UPDATE Hotel_Table SET hotel = @newHotel WHERE hotel= @hotelName", sc);
			cmd.Parameters.AddWithValue("@newHotel", textBox_hotel.Text);
			cmd.Parameters.AddWithValue("@hotelName", hotelName);
			sc.Open();
			cmd.ExecuteNonQuery();
			sc.Close();
			//MessageBox.Show("Data Updated Successfully");
			showData();
			textBox_hotel.Text = "";
			textBox_hotel.Focus();
		}

		private void button_delete_Click(object sender, EventArgs e)
		{
			string hotel = textBox_hotel.Text;
			MySqlCommand cmd = new MySqlCommand("DELETE FROM Hotel_Table WHERE hotel= @hotel", sc);
			cmd.Parameters.AddWithValue("@hotel", hotel);
			sc.Open();
			cmd.ExecuteNonQuery();
			sc.Close();
			//MessageBox.Show("Data Removed Successfully");
			showData();
			textBox_hotel.Text = "";
			textBox_hotel.Focus();
		}

		private void showData()
		{
			MySqlCommand cmd = new MySqlCommand("SELECT hotel FROM Hotel_Table", sc);
			sc.Open();
			var reader = cmd.ExecuteReader();
			DataTable table = new DataTable();
			table.Load(reader);
			dataGridView_hotel.DataSource = table;
			sc.Close();
			textBox_hotel.Focus();
		}

		private void dataGridView_hotel_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			//DataGridViewRow row = this.dataGridView_destination.Rows[e.RowIndex];
			hotelName = dataGridView_hotel.SelectedRows[0].Cells[0].Value.ToString();
			textBox_hotel.Text = hotelName;
		}
	}
}

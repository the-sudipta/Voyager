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
	public partial class UC_Admin_Tour : UserControl
	{
		MySqlConnection connection = new MySqlConnection(SQLConnectionClass.conReturn()); // Connection String
		string tourName;

		public UC_Admin_Tour()
		{
			InitializeComponent();
			showData();
		}

		private void button_add_Click(object sender, EventArgs e)
		{
			try
			{
				string tour = textBox_tour.Text;
				tourName = tour;
				Console.WriteLine("Tour Date = " + tour);
				MySqlCommand cmd = new MySqlCommand("INSERT INTO Tour_Table (tours) VALUES(@tour)", connection);
				cmd.Parameters.AddWithValue("@tour", tour);
				connection.Open();
				cmd.ExecuteNonQuery();
				connection.Close();
				showData();
				textBox_tour.Text = "";
				textBox_tour.Focus();
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
				MySqlCommand cmd = new MySqlCommand("UPDATE Tour_Table SET tours = @tour WHERE tours=@tourName", connection);
				cmd.Parameters.AddWithValue("@tour", textBox_tour.Text);
				cmd.Parameters.AddWithValue("@tourName", tourName);
				connection.Open();
				cmd.ExecuteNonQuery();
				connection.Close();
				showData();
				textBox_tour.Text = "";
				textBox_tour.Focus();
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
				string tour = textBox_tour.Text;
				MySqlCommand cmd = new MySqlCommand("DELETE FROM Tour_Table WHERE tours= @tour", connection);
				cmd.Parameters.AddWithValue("@tour", tour);
				connection.Open();
				cmd.ExecuteNonQuery();
				connection.Close();
				showData();
				textBox_tour.Text = "";
				textBox_tour.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

		private void dataGridView_tour_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = dataGridView_tour.Rows[e.RowIndex];
				tourName = row.Cells["tours"].Value.ToString();
				textBox_tour.Text = tourName;
			}
		}

		private void showData()
		{
			try
			{
				MySqlCommand cmd = new MySqlCommand("SELECT tours FROM Tour_Table", connection);
				connection.Open();
				var reader = cmd.ExecuteReader();
				DataTable table = new DataTable();
				table.Load(reader);
				dataGridView_tour.DataSource = table;
				connection.Close();
				textBox_tour.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}
	}
}

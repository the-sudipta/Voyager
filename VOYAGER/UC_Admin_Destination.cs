using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VOYAGER
{
	public partial class UC_Admin_Destination : UserControl
	{
		private MySqlConnection connection = new MySqlConnection(SQLConnectionClass.conReturn());
		private string selectedDestination;

		public UC_Admin_Destination()
		{
			InitializeComponent();
			showData();
		}

		private void button_add_Click(object sender, EventArgs e)
		{
			string destination = textBox_destination.Text.Trim();
			if (!string.IsNullOrEmpty(destination))
			{
				try
				{
					MySqlCommand command = new MySqlCommand("INSERT INTO Destination_Table (destination) VALUES(@Destination)", connection);
					command.Parameters.AddWithValue("@Destination", destination);
					connection.Open();
					command.ExecuteNonQuery();
					connection.Close();
					MessageBox.Show("Destination added successfully.");
					showData();
					textBox_destination.Clear();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message);
				}
			}
			else
			{
				MessageBox.Show("Please enter a destination.");
			}
		}

		private void button_delete_Click(object sender, EventArgs e)
		{
			string destination = textBox_destination.Text.Trim();
			if (!string.IsNullOrEmpty(destination))
			{
				try
				{
					MySqlCommand command = new MySqlCommand("DELETE FROM Destination_Table WHERE destination = @Destination", connection);
					command.Parameters.AddWithValue("@Destination", destination);
					connection.Open();
					command.ExecuteNonQuery();
					connection.Close();
					MessageBox.Show("Destination removed successfully.");
					showData();
					textBox_destination.Clear();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message);
				}
			}
			else
			{
				MessageBox.Show("Please select a destination to delete.");
			}
		}

		private void UC_Admin_Destination_Load(object sender, EventArgs e)
		{
			showData();
		}

		private void showData()
		{
			try
			{
				MySqlCommand command = new MySqlCommand("SELECT destination FROM Destination_Table", connection);
				connection.Open();
				MySqlDataReader reader = command.ExecuteReader();
				DataTable table = new DataTable();
				table.Load(reader);
				dataGridView_destination.DataSource = table;
				connection.Close();
				textBox_destination.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

		private void dataGridView_destination_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				selectedDestination = dataGridView_destination.Rows[e.RowIndex].Cells[0].Value.ToString();
				textBox_destination.Text = selectedDestination;
			}
		}

		private void button_update_Click(object sender, EventArgs e)
		{
			string newDestination = textBox_destination.Text.Trim();
			if (!string.IsNullOrEmpty(selectedDestination) && !string.IsNullOrEmpty(newDestination))
			{
				try
				{
					MySqlCommand command = new MySqlCommand("UPDATE Destination_Table SET destination = @NewDestination WHERE destination = @SelectedDestination", connection);
					command.Parameters.AddWithValue("@NewDestination", newDestination);
					command.Parameters.AddWithValue("@SelectedDestination", selectedDestination);
					connection.Open();
					command.ExecuteNonQuery();
					connection.Close();
					MessageBox.Show("Destination updated successfully.");
					showData();
					textBox_destination.Clear();
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message);
				}
			}
			else
			{
				MessageBox.Show("Please select a destination and enter a new destination value.");
			}
		}
	}
}

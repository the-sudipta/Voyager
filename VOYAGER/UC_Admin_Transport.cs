using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VOYAGER
{
	public partial class UC_Admin_Transport : UserControl
	{

		MySqlConnection sc = new MySqlConnection(SQLConnectionClass.conReturn()); // Connection String
		string trasportType;
		string transportName;

		public UC_Admin_Transport()
		{
			InitializeComponent();
			radioButton_air.Checked = true;
			trasportType = "air";
			showData("air");
		}

		private void radioButton_air_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton_air.Checked == true)
			{
				trasportType = "air";
				showData("air");
			}
		}

		private void radioButton_bus_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton_bus.Checked == true)
			{
				trasportType = "bus";
				showData("bus");
			}
		}

		private void radioButton_train_CheckedChanged(object sender, EventArgs e)
		{
			if (radioButton_train.Checked == true)
			{
				trasportType = "train";
				showData("train");
			}
		}

		private void button_add_Click(object sender, EventArgs e)
		{
			try
			{
				string transport = textBox_transport.Text;
				transportName = transport;
				Console.WriteLine("Destination = " + transport);

				MySqlCommand sm = new MySqlCommand();
				sm.Connection = sc;

				if (trasportType == "air")
				{
					sm.CommandText = "INSERT INTO Air_Table (air) VALUES(@transport)";
				}
				else if (trasportType == "bus")
				{
					sm.CommandText = "INSERT INTO Bus_Table (bus) VALUES(@transport)";
				}
				else if (trasportType == "train")
				{
					sm.CommandText = "INSERT INTO Train_Table (train) VALUES(@transport)";
				}
				else
				{
					MessageBox.Show("Error in UC_Admin_Transport, Add Button");
					return;
				}

				sm.Parameters.AddWithValue("@transport", transport);

				sc.Open();
				sm.ExecuteNonQuery();
				sc.Close();
				//MessageBox.Show("Data Saved Successfully");
				showData(trasportType);
				textBox_transport.Text = "";
				textBox_transport.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error = " + ex.Message);
			}
		}

		private void button_update_Click(object sender, EventArgs e)
		{
			try
			{
				MySqlCommand cmd = new MySqlCommand();
				cmd.Connection = sc;

				if (trasportType == "air")
				{
					cmd.CommandText = "UPDATE Air_Table SET air = @transport WHERE air = @transportName";
				}
				else if (trasportType == "bus")
				{
					cmd.CommandText = "UPDATE Bus_Table SET bus = @transport WHERE bus = @transportName";
				}
				else if (trasportType == "train")
				{
					cmd.CommandText = "UPDATE Train_Table SET train = @transport WHERE train = @transportName";
				}
				else
				{
					MessageBox.Show("Error in UC_Admin_Transport, Update Button");
					return;
				}

				cmd.Parameters.AddWithValue("@transport", textBox_transport.Text);
				cmd.Parameters.AddWithValue("@transportName", transportName);

				sc.Open();
				cmd.ExecuteNonQuery();
				sc.Close();
				//MessageBox.Show("Data Updated Successfully");
				showData(trasportType);
				textBox_transport.Text = "";
				textBox_transport.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error = " + ex.Message);
			}
		}

		private void button_delete_Click(object sender, EventArgs e)
		{
			try
			{
				string transport = textBox_transport.Text;
				MySqlCommand cmd = new MySqlCommand();
				cmd.Connection = sc;

				if (trasportType == "air")
				{
					cmd.CommandText = "DELETE FROM Air_Table WHERE air = @transport";
				}
				else if (trasportType == "bus")
				{
					cmd.CommandText = "DELETE FROM Bus_Table WHERE bus = @transport";
				}
				else if (trasportType == "train")
				{
					cmd.CommandText = "DELETE FROM Train_Table WHERE train = @transport";
				}
				else
				{
					MessageBox.Show("Error in UC_Admin_Transport, Delete Button");
					return;
				}

				cmd.Parameters.AddWithValue("@transport", transport);

				sc.Open();
				cmd.ExecuteNonQuery();
				sc.Close();
				//MessageBox.Show("Data Removed Successfully");
				showData(trasportType);
				textBox_transport.Text = "";
				textBox_transport.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error = " + ex.Message);
			}
		}

		private void dataGridView_transport_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			//DataGridViewRow row = this.dataGridView_destination.Rows[e.RowIndex];
			transportName = dataGridView_transport.SelectedRows[0].Cells[0].Value.ToString();
			textBox_transport.Text = transportName;
		}


		private void showData(string type)
		{
			try
			{
				MySqlCommand cmd = new MySqlCommand();
				cmd.Connection = sc;

				if (type == "air")
				{
					cmd.CommandText = "SELECT air FROM Air_Table";
				}
				else if (type == "bus")
				{
					cmd.CommandText = "SELECT bus FROM Bus_Table";
				}
				else if (type == "train")
				{
					cmd.CommandText = "SELECT train FROM Train_Table";
				}
				else
				{
					MessageBox.Show("Table Could Not Found to Show");
					return;
				}

				sc.Open();
				var reader = cmd.ExecuteReader();
				DataTable table = new DataTable();
				table.Load(reader);
				dataGridView_transport.DataSource = table;
				sc.Close();
				textBox_transport.Focus();
			}
			catch (Exception e)
			{
				MessageBox.Show("Error = " + e.Message);
			}
		}
	}
}

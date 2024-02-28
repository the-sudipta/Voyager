using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace VOYAGER
{
	public partial class UC_Admin_AllHistory : UserControl
	{
		MySqlConnection sc = new MySqlConnection(SQLConnectionClass.conReturn()); // Connection String

		public UC_Admin_AllHistory()
		{
			InitializeComponent();
		}

		private void UC_Admin_AllHistory_Load(object sender, EventArgs e)
		{
			SQL_Query("air", "Air_Table", dataGridView_air);
			SQL_Query("bus", "Bus_Table", dataGridView_Bus);
			SQL_Query("train", "Train_Table", dataGridView_Train);
			SQL_Query("destination", "Destination_Table", dataGridView_destination);
			SQL_Query("hotel", "Hotel_Table", dataGridView_hotel);
		}

		private void SQL_Query(string columnNames, string tableName, DataGridView gridViewName)
		{
			try
			{
				MySqlCommand cmd = new MySqlCommand("SELECT " + columnNames + " FROM " + tableName, sc);
				MySqlDataAdapter adapter = new MySqlDataAdapter(cmd);
				DataTable table = new DataTable();
				adapter.Fill(table);
				gridViewName.DataSource = table;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
		}

		private void roundPicturech_next_Click(object sender, EventArgs e)
		{
			UC_Admin_AllHistory_Next ucaahn = new UC_Admin_AllHistory_Next();
			Utility.UCAAHN = ucaahn;

			if (Utility.all_History_panel_Shifter != 1)
			{
				try
				{
					Utility.ADMIN.AddControlsToPanel(ucaahn);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message);
				}
			}
			else
			{
				try
				{
					Utility.RECCEPTIONIST.AddControlsToPanel(ucaahn);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message);
				}
			}
		}
	}
}

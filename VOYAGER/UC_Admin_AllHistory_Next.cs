using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace VOYAGER
{
	public partial class UC_Admin_AllHistory_Next : UserControl
	{
		MySqlConnection sc = new MySqlConnection(SQLConnectionClass.conReturn());

		public UC_Admin_AllHistory_Next()
		{
			InitializeComponent();
		}

		private void SQL_Query(string columnNames, string tableName, DataGridView gridViewName)
		{
			try
			{
				MySqlCommand cmd = new MySqlCommand("SELECT " + columnNames + " FROM " + tableName, sc);
				sc.Open();
				MySqlDataReader reader = cmd.ExecuteReader();
				DataTable table = new DataTable();
				table.Load(reader);
				gridViewName.DataSource = table;
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

		private void roundPicturech_back_Click(object sender, EventArgs e)
		{
			if (Utility.all_History_panel_Shifter != 1)
			{
				try
				{
					Utility.ADMIN.AddControlsToPanel(Utility.UCAAH);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message);
				}
			}
			else
			{
				Utility.RECCEPTIONIST.AddControlsToPanel(Utility.UCAAH);
			}
		}

		private void UC_Admin_AllHistory_Next_Load(object sender, EventArgs e)
		{
			SQL_Query("username, password, earnings", "Staffs_Table", dataGridView_staff);
			SQL_Query("name, phone, mail, nid, member, date, destination, transport", "Client_Table", dataGridView_client);
			SQL_Query("tours", "Tour_Table", dataGridView_tour);
		}
	}
}

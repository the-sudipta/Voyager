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
	public partial class Search_Gridview : Form
	{
		public static string coloumnName = "";
		public static string itemName = "";
		MySqlConnection connection = new MySqlConnection(SQLConnectionClass.conReturn());
		MySqlCommand cmd;

		public Search_Gridview()
		{
			InitializeComponent();
		}

		public void showData()
		{
			try
			{
				coloumnName = coloumnName.ToLower();
				string query = "";
				if (coloumnName == "username" || coloumnName == "password" || coloumnName == "earnings")
				{
					query = "SELECT * FROM Staffs_Table WHERE " + coloumnName + " = @itemName";
				}
				else if (coloumnName == "name" || coloumnName == "nid")
				{
					query = "SELECT * FROM Client_Table WHERE " + coloumnName + " = @itemName";
				}
				else if (coloumnName == "air")
				{
					query = "SELECT air FROM Air_Table";
				}
				else if (coloumnName == "bus")
				{
					query = "SELECT bus FROM Bus_Table";
				}
				else if (coloumnName == "train")
				{
					query = "SELECT train FROM Train_Table";
				}
				else if (coloumnName == "destination")
				{
					query = "SELECT destination FROM Destination_Table";
				}
				else if (coloumnName == "hotel")
				{
					query = "SELECT hotel FROM Hotel_Table";
				}
				else if (coloumnName == "tours")
				{
					query = "SELECT tours FROM Tour_Table";
				}

				connection.Open();
				cmd = new MySqlCommand(query, connection);
				cmd.Parameters.AddWithValue("@itemName", itemName);
				var reader = cmd.ExecuteReader();
				DataTable table = new DataTable();
				table.Load(reader);
				dataGridView_searched_data.DataSource = table;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message);
			}
			finally
			{
				connection.Close();
			}
		}

		private void button_back_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}


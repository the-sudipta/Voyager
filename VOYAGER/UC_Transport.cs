using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VOYAGER
{
	public partial class UC_Transport : UserControl
	{
		public UC_Transport()
		{
			InitializeComponent();
			//setDefaultValueOnComboBox();
			Utility.BOOKING.label_hotel_color.ForeColor = Color.DarkGray;
			fetchData("air", "Air_Table", comboBox_air);
			fetchData("bus", "Bus_Table", comboBox_bus);
			fetchData("train", "Train_Table", comboBox_train);
		}

		private void panel_air_Click(object sender, EventArgs e)
		{
			Tourist.vehicleCost = Tourist.airCost;
			Utility.BOOKING.textBox_price.Text = Convert.ToString(Tourist.TotalCost());
			comboBoxVisibility("air");
		}

		private void panel_bus_Click(object sender, EventArgs e)
		{
			Tourist.vehicleCost = Tourist.busCost;
			Utility.BOOKING.textBox_price.Text = Convert.ToString(Tourist.TotalCost());
			comboBoxVisibility("bus");
		}

		private void panel_train_Click(object sender, EventArgs e)
		{
			Tourist.vehicleCost = Tourist.trainCost;
			Utility.BOOKING.textBox_price.Text = Convert.ToString(Tourist.TotalCost());
			comboBoxVisibility("train");
		}

		private void callHotel()
		{
			Utility.BOOKING.label_hotel_color.ForeColor = Color.White;
			UC_Hotel uch = new UC_Hotel();
			Utility.UCH = uch;
			Utility.BOOKING.AddControlsToPanel(uch);
		}

		private void comboBoxVisibility(string name)
		{
			comboBox_air.Visible = name == "air";
			comboBox_bus.Visible = name == "bus";
			comboBox_train.Visible = name == "train";
		}

		private void comboBox_air_TextChanged(object sender, EventArgs e)
		{
			Tourist.VEHICLENAME = comboBox_air.SelectedItem.ToString();
			callHotel();
		}

		private void comboBox_bus_TextChanged(object sender, EventArgs e)
		{
			Tourist.VEHICLENAME = comboBox_bus.SelectedItem.ToString();
			callHotel();
		}

		private void comboBox_train_TextChanged(object sender, EventArgs e)
		{
			Tourist.VEHICLENAME = comboBox_train.SelectedItem.ToString();
			callHotel();
		}

		private void setDefaultValueOnComboBox()
		{
			comboBox_air.SelectedIndex = 0;
			comboBox_bus.SelectedIndex = 0;
			comboBox_train.SelectedIndex = 0;
		}

		private void fetchData(string colName, string tableName, ComboBox dropDown)
		{
			MySqlConnection con = new MySqlConnection(SQLConnectionClass.conReturn());
			MySqlCommand cmd = new MySqlCommand("SELECT * FROM " + tableName, con);
			try
			{
				con.Open();
				MySqlDataReader myReader = cmd.ExecuteReader();
				dropDown.Items.Add("--Select--");
				dropDown.SelectedIndex = 0;
				while (myReader.Read())
				{
					string sname = myReader.GetString(1);
					dropDown.Items.Add(sname);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			finally
			{
				con.Close();
			}
		}
	}
}

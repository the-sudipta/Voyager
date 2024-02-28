using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VOYAGER
{
	public partial class UC_Payment : UserControl
	{
		MySqlConnection sc = new MySqlConnection(SQLConnectionClass.conReturn()); // Connection String

		public UC_Payment()
		{
			InitializeComponent();
		}

		private void collectTouristInfo()
		{
			Tourist.TOURIST_NAME = textBox_name.Text;
			Tourist.PHONENUMBER = textBox_phoneNumber.Text;
			Tourist.EMAIL = textBox_mail.Text;
			Tourist.NID = textBox_nid.Text;
			Tourist.MEMBERS = textBox_member.Text;
			Tourist.TOUR_DATE = textBox_tourDate.Text;
		}

		private void textBox_member_TextChanged(object sender, EventArgs e)
		{
			if (textBox_member.Text != "")
			{
				Tourist.MEMBERS = textBox_member.Text;
				Utility.BOOKING.textBox_price.Text = Convert.ToString(Tourist.TotalCost());
			}
		}

		private void panel_confirm_print_Click(object sender, EventArgs e)
		{
			collectTouristInfo();
			// Print Method
			// Send Data To DataBase


			try
			{
				MySqlCommand sm = new MySqlCommand("INSERT INTO Client_Table (name,phone,mail,nid,member,date,destination,transport) " +
					"VALUES(@name, @phone, @mail, @nid, @member, @date, @destination, @transport)", sc);

				sm.Parameters.AddWithValue("@name", Tourist.TOURIST_NAME);
				sm.Parameters.AddWithValue("@phone", Tourist.PHONENUMBER);
				sm.Parameters.AddWithValue("@mail", Tourist.EMAIL);
				sm.Parameters.AddWithValue("@nid", Tourist.NID);
				sm.Parameters.AddWithValue("@member", Tourist.MEMBERS);
				sm.Parameters.AddWithValue("@date", Tourist.TOUR_DATE);
				sm.Parameters.AddWithValue("@destination", Tourist.DESTINATION);
				sm.Parameters.AddWithValue("@transport", Tourist.VEHICLENAME);

				MySqlCommand sm2 = new MySqlCommand("INSERT INTO Tour_Table (tours) VALUES(@tours)", sc); // This for Tour date table
				sm2.Parameters.AddWithValue("@tours", textBox_tourDate.Text);

				sc.Open();
				sm.ExecuteNonQuery();
				sm2.ExecuteNonQuery();
				sc.Close();

				MessageBox.Show("Data Saved Successfully");
				Utility.BOOKING.textBox_price.Text = "";

				Utility.RECCEPTIONIST.Hide();
				Utility.BOOKING.Hide();
				Print_Preview pp = new Print_Preview();
				Utility.PP = pp;
				pp.Show();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error = " + ex.Message);
			}
		}
	}
}

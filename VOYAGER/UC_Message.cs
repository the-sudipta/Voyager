using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace VOYAGER
{
	public partial class UC_Message : UserControl
	{
		MySqlConnection sc = new MySqlConnection(SQLConnectionClass.conReturn()); // Connection String
		string myMessage = "";
		string message_Indicator = "";

		public UC_Message()
		{
			InitializeComponent();
			showData();
		}

		private void roundPicturech_send_Click(object sender, EventArgs e)
		{
			try
			{
				myMessage = textBox_sendMessage.Text;
				label_myMessage.Text = myMessage;

				MySqlCommand cmd = new MySqlCommand();
				cmd.Connection = sc;

				if (Utility.IS_ADMIN == true)
				{
					cmd.CommandText = "UPDATE Message_Table SET admin = @message WHERE id = "+1;
				}
				else
				{
					cmd.CommandText = "UPDATE Message_Table SET recep = @message WHERE id = "+1;
				}

				cmd.Parameters.AddWithValue("@message", myMessage);
				cmd.Parameters.AddWithValue("@indicator", message_Indicator);

				sc.Open();
				cmd.ExecuteNonQuery();
				sc.Close();

				//MessageBox.Show(Utility.IS_ADMIN ? "Data Admin Updated Successfully" : "Data Recep Updated Successfully");
				showData();

				textBox_sendMessage.Text = "";
				textBox_sendMessage.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error = " + ex.Message);
			}
		}

		private void showData()
		{
			try
			{
				MySqlCommand cmd = new MySqlCommand();
				cmd.Connection = sc;

				if (Utility.IS_ADMIN == true)
				{
					cmd.CommandText = "SELECT * FROM Message_Table";
				}
				else
				{
					cmd.CommandText = "SELECT * FROM Message_Table";
				}

				sc.Open();
				MySqlDataReader dr = cmd.ExecuteReader();
				if (dr.Read())
				{
					if (Utility.IS_ADMIN)
					{
						label_getMessage.Text = dr["recep"].ToString();
					}
					else
					{
						label_getMessage.Text = dr["admin"].ToString();
					}

					message_Indicator = dr["admin"].ToString();
				}
				sc.Close();

				textBox_sendMessage.Focus();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error = " + ex.Message);
			}
		}

		#region MessageBox User Adavncement

		private void textBox_sendMessage_Enter(object sender, EventArgs e)
		{
			if (textBox_sendMessage.Text == "Type your message here")
			{
				textBox_sendMessage.Text = "";
				textBox_sendMessage.ForeColor = System.Drawing.Color.White;
			}
		}

		private void textBox_sendMessage_Leave(object sender, EventArgs e)
		{
			if (textBox_sendMessage.Text == "")
			{
				textBox_sendMessage.Text = "Type your message here";
				textBox_sendMessage.ForeColor = System.Drawing.Color.Silver;
			}
		}

		private void textBox_sendMessage_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				roundPicturech_send_Click(this, new EventArgs());
			}
		}

		#endregion Messsage Box Beautify
	}
}

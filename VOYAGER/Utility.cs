using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VOYAGER
{
    class Utility
    {

        SqlConnection sc = new SqlConnection(SQLConnectionClass.conReturn());
        #region LOCAL DATABASE

        public static Login_Panel LOGIN;
        public static Admin_panel ADMIN;
        public static Reception_Panel RECCEPTIONIST;
        public static Booking_Order_Panel BOOKING;
        public static Manager_Panel MANAGER;
        public static Broker_Panel BROKER;
        public static Affiliates_Panel AFFILIATES;
        public static Staff_Panel STAFF;
        public static Print_Preview PP;
        public static Search_Gridview SG;

        public static UC_Destination_Type UCDT;
        public static UC_Destination_HillStation UCDH;
        public static UC_Destination_Beaches UCDB;
        public static UC_Destination_Forest UCDF;
        public static UC_Destination_Historical UCDHIST;
        public static UC_Destination_Lakes UCDL;
        public static UC_Destination_Monuments UCDM;
        public static UC_Transport UCT;
        public static UC_Hotel UCH;
        public static UC_Payment UCP;
        public static UC_Message UCM;

        public static UC_Admin_Home UCAH;
        public static UC_Admin_Destination UCAD;
        public static UC_Admin_AllHistory UCAAH;
        public static UC_Admin_AllHistory_Next UCAAHN;
        public static UC_Admin_Hotel UCAHO;
        public static UC_Admin_Transport UCAT;
        public static UC_Admin_Staff UCAS;
        public static UC_Admin_Tour UCATo;
        public static UC_Admin_Client UCAC;

        public static UC_Receptionist_Home UCRH;

        public static int all_History_panel_Shifter = 0;
        public static bool IS_ADMIN = true;
        //public static 

        ///public static string DATABASE_CONNECTION = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\Yaarian\AIUB\Voyager\VOYAGER\Voyager_DataBase.mdf;Integrated Security=True";

        // Change the connection String at the UC_Admin_Transport file also
        // Change the connection String at the UC_Admin_Staff file also
        // Change the connection String at the UC_Admin_Tour file also
        // Change the connection String at the UC_Admin_AllHistory file also
        // Change the connection String at the UC_Admin_AllHistory_next file also
        // Change the connection String at the UC_Admin_Destination file also
        // Change the connection String at the UC_Admin_Hotel file also
        // Change the connection String at the UC_Admin_Client file also
        #endregion LOCAL DATABASE

        public bool login(string username, string password)
        {
            string matchPass;
            string querry = "SELECT * WHERE Staff_Table WHERE username = '" + username + "' AND password = '" + password + "'  ";
            SqlDataAdapter sda = new SqlDataAdapter(querry, sc);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if(dt.Rows.Count > 0)
            {

            }
            return false;
        }


        public static string[] getAllData(string tableName)
        {
            string[] a = { };
            return a;
        }

        


    }
}

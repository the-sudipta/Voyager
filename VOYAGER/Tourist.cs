using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VOYAGER
{
    class Tourist
    {
        public static string DESTINATION_TYPE;
        public static string DESTINATION;
        public static string VEHICLETYPE;
        public static string VEHICLENAME;
        public static string HOTELROOM;
        public static string TOURIST_NAME;
        public static string PHONENUMBER;
        public static string NID;
        public static string EMAIL;
        public static string MEMBERS = "1";
        public static string TOUR_DATE;

        public static double airCost = 3000;
        public static double busCost = 900;
        public static double trainCost = 400;
        public static double vehicleCost = 0;

        public static double singleBedCost = 500;
        public static double suiteBedCost = 1500;
        public static double resortCost = 11000;
        public static double hotelCost = 0;

        public static double TOTAL_COST = 0;

        public static double TotalCost()
        {
            try
            {
                TOTAL_COST = (vehicleCost * (Convert.ToDouble(MEMBERS))) + hotelCost;
                return TOTAL_COST;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error = " + ex.Message);
                MessageBox.Show("Member Number Must be in Integer Format");
                Console.WriteLine("Member Number Must be in Integer Format");
                return -1;
            }
        }

    }
}

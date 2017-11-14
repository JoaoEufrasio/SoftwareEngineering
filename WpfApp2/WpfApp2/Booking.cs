using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class Booking 
    {
        /*
        // set variables for fields
        public string booking_id;
        public string patient_id;
        public string staff_id;
        public string booking_date;
        public string time;
        public string description;  
        */
        
       public static void RegisterNewBooking()
        {


            string query = "SELECT * FROM Booking (Patient_id, Staff_Id , Booking_date, Time, Description) VALUES(@tb_patient_id, @tb_doctor, @tb_date, @tb_time @tb_description";

             //connect to database
            DBConnection connection = DBConnection.getDBConnectionInstance();
            DataSet DataLogin = connection.getDataSet(query);

            //tb_patient_id.Text = ["Patient_Id"].ToString();

        /*  
    {
        DBConnection con = new DBConnection(strConnString);
        con.Open();
        str = "SELECT * FROM Booking ";
        com = new SqlCommand(str, con);
        SqlDataReader reader = com.ExecuteReader();

        reader.Read();
        tb_patient_id.Text = reader["Name"].ToString();

        reader.Close();
        con.Close();

    }*/


    }


    }
}

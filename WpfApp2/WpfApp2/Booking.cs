using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    static class Booking 
    {
        

        public static void createBooking(string id, string doctor, string date, string time, string room, string description)
        {
            //code taken from https://stackoverflow.com/questions/4503542/check-for-special-characters-in-a-string
            //makes sure the characters in text boxes are letters, digits or spaces
            
            
            //creates the query
            string sqlQuery;
            //creates the query with parameters instead of data from the user. That data will be inserted in the query later, in the back-end
            sqlQuery = @"INSERT INTO Bookings (Patient_ID, Staff_ID, Booking_Date, Time, Room, Description) VALUES (@PatientID, @DoctorID, @Date, @Time, @Room, @Description);";
            DBConnection connection = DBConnection.getDBConnectionInstance();
            connection.book(sqlQuery, id, doctor, date, time, room, description);
               
        }
        public static void viewBooking()
        {


            string query = "SELECT * FROM Bookings WHERE Patient_Id = 1";
            // (Patient_id, Staff_Id , Booking_date, Time, Room, Description) VALUES('Patient_Id', 'Doctor_Id', 'Date', 'Time', 'Room', @tb_description)
            //connect to database
            DBConnection connection = DBConnection.getDBConnectionInstance();
            DataSet DataLogin = connection.getDataSet(query);
       //     SqlDataReader reader = DataLogin.
            
            /*while (myReader.Read())
            {
                TextBoxPassword.Text = (myReader["password"].ToString());
                TextBoxRPassword.Text = (myReader["retypepassword"].ToString());
                DropDownListGender.SelectedItem.Text = (myReader["gender"].ToString());
                DropDownListMonth.Text = (myReader["birth"].ToString());
                DropDownListYear.Text = (myReader["birth"].ToString());
                TextBoxAddress.Text = (myReader["address"].ToString());
                TextBoxCity.Text = (myReader["city"].ToString());
                DropDownListCountry.SelectedItem.Text = (myReader["country"].ToString());
                TextBoxPostcode.Text = (myReader["postcode"].ToString());
                TextBoxEmail.Text = (myReader["email"].ToString());
                TextBoxCarno.Text = (myReader["carno"].ToString());
            }*/

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

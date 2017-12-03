using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public static void cancelBooking(string id)
        {
            string sqlQuery;
            //creates the query with parameters 
            sqlQuery = @"DELETE FROM Bookings where Booking_Id =@Booking_ID;";
            DBConnection connection = DBConnection.getDBConnectionInstance();
            connection.deleteBooking(sqlQuery, id);
            MessageBox.Show("Booking deleted.");
        }
        public static void viewBooking(string id, bool main)
        {
            //creates the SQL query
            string query = @"SELECT *, Patients.Patient_name, Patients.Patient_surname FROM Bookings INNER JOIN Patients ON Bookings.Patient_ID = Patients.Patient_ID WHERE Booking_Id = '" + id + "';";
            DBConnection connection = DBConnection.getDBConnectionInstance();
            DataSet bookingData = connection.getDataSet(query);
            //checks that the query returned exactly one result
            int count = bookingData.Tables[0].Rows.Count;

            if (count == 1)
            {
                Individual_bookings booking = new Individual_bookings(id, bookingData);
                booking.Show();
            }
            else
            {
                MessageBox.Show("No booking found.");
                if (main)
                {
                    main_screen frm = new main_screen();
                    frm.Show();
                }
                else
                {
                    booking_screen frm = new booking_screen();
                    frm.Show();
                }
            }      
        }      
        
        public static DataTable showBookingsGrid()
        {
            string date = DateTime.Today.ToString("MM/dd/yyyy");
            date = date.Split(' ')[0];
            string sqlQuery = @"SELECT Patients.Patient_ID, Patients.Patient_name, Patients.Patient_surname, Bookings.Booking_ID, Bookings.Booking_Date, Bookings.Time, Bookings.Room FROM Patients INNER JOIN Bookings ON Patients.Patient_ID = Bookings.Patient_ID WHERE Bookings.Booking_date = '" + date + "'";
            DBConnection connection = DBConnection.getDBConnectionInstance();
            DataSet todayBookings = connection.getDataSet(sqlQuery);
            DataTable dt = todayBookings.Tables[0];
            return dt;
        }

        public static DataTable showBookingsGridDate(string d)
        {
            string date = d; 
            date = date.Split(' ')[0];
            string sqlQuery = @"SELECT Patients.Patient_ID, Patients.Patient_name, Patients.Patient_surname, Bookings.Booking_ID, Bookings.Booking_Date, Bookings.Time, Bookings.Room FROM Patients INNER JOIN Bookings ON Patients.Patient_ID = Bookings.Patient_ID WHERE Bookings.Booking_date = '" + date + "'";
            DBConnection connection = DBConnection.getDBConnectionInstance();
            DataSet todayBookings = connection.getDataSet(sqlQuery);
            DataTable dt = todayBookings.Tables[0];
            return dt;
        }
    }
}


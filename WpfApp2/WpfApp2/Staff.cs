using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Windows.Controls;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WpfApp2
{
    static class Staff
    {
        public static void viewStaff(string id)
        {
            string query = @"SELECT * FROM Staff WHERE Staff_ID = '" + id + "';";


            //connect to database
            DBConnection connection = DBConnection.getDBConnectionInstance();
            DataSet staffData = connection.getDataSet(query);
            int count = staffData.Tables[0].Rows.Count;


            if (count == 1)
            {
                staff_individual staff = new staff_individual(id, staffData);
                staff.Show();
            }
            else
            {
                MessageBox.Show("No staff member found.");
            }
        


        }

        public static DataTable shiftsGrid()
        {
            string date = DateTime.Today.ToString("MM/dd/yyyy");
            date = date.Split(' ')[0];
            string sqlQuery = @"SELECT Staff.Staff_name AS Name, Staff.Staff_surname AS Surname, Shifts.Start_time AS 'Shift start', Shifts.End_time AS 'Shift end' FROM Shifts INNER JOIN Staff ON Shifts.Staff_Id = Staff.Staff_Id WHERE Shifts.Shift_date = '" + date + "';";
            DBConnection connection = DBConnection.getDBConnectionInstance();
            DataSet todayStaff = connection.getDataSet(sqlQuery);
            DataTable dt = todayStaff.Tables[0];
            return dt;
        }

        public static DataTable individualShiftsGrid(string id)
        {
            string date = DateTime.Today.ToString("MM/dd/yyyy");
            date = date.Split(' ')[0];
            string sqlQuery = @"SELECT Shifts.Start_time AS 'Shift start', Shifts.End_time AS 'Shift end' FROM Shifts WHERE Shifts.Staff_Id = '" + id + "' AND Shifts.Shift_date = '" + date + "';";
            string bookingsQuery = @"SELECT Time FROM Bookings WHERE Staff_Id = '" + id + "' AND Booking_Date = '" + date + "';";
            DBConnection connection = DBConnection.getDBConnectionInstance();
            DataSet todayShifts = connection.getDataSet(sqlQuery);
            DataTable dt = todayShifts.Tables[0];
            return dt;
        }

        public static DataTable individualBookingGrid(string id)
        {
            string date = DateTime.Today.ToString("MM/dd/yyyy");
            date = date.Split(' ')[0];
            string bookingsQuery = @"SELECT Time FROM Bookings WHERE Staff_Id = '" + id + "' AND Booking_Date = '" + date + "';";
            DBConnection connection = DBConnection.getDBConnectionInstance();
            DataSet todayBookings = connection.getDataSet(bookingsQuery);
            DataTable dt = todayBookings.Tables[0];
            return dt;
        }
    }
}

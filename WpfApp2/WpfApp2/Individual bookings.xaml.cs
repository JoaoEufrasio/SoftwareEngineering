using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for Individual_bookings.xaml
    /// </summary>
    public partial class Individual_bookings : Window 
      

    {
        string bookingId;
        DataSet bookingData;
        public Individual_bookings(string id, DataSet data)
        {
            InitializeComponent();
            //the constructor gets passed the ID of the patient this information belongs to and the actual dataset
            bookingId = id;
            bookingData = data;
            InitializeComponent();
            //the data from the database is put into the corresponding text boxes (or blocks)
            
            tb_patientid.Text = bookingData.Tables[0].Rows[0].Field<int>("Patient_Id").ToString();
            tb_name.Text = bookingData.Tables[0].Rows[0].Field<string>("Patient_name").Trim() + " " + bookingData.Tables[0].Rows[0].Field<string>("Patient_surname").Trim();
            tb_doctor.Text = bookingData.Tables[0].Rows[0].Field<int>("Staff_Id").ToString();
            tb_date.Text = bookingData.Tables[0].Rows[0].Field<DateTime>("Booking_Date").ToString().Split(' ')[0];
            tb_time.Text = bookingData.Tables[0].Rows[0].Field<TimeSpan>("Time").ToString();
            tb_room.Text = bookingData.Tables[0].Rows[0].Field<string>("Room");
            tb_description.Text = bookingData.Tables[0].Rows[0].Field<string>("Description");
            tb_bookingid.Text = id;
            //Booking.viewBooking();
        }

        private void bt_cancel_booking_Click(object sender, RoutedEventArgs e)
        {
            if (System.Windows.MessageBox.Show("Are you sure want to save changes", "Save Booking Changes",
       MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                Booking.cancelBooking(tb_bookingid.Text);
            }
        }
        public void ViewBookings()
        {
            string query = "SELECT * FROM Bookings WHERE Patient_Id = 1";
            // (Patient_id, Staff_Id , Booking_date, Time, Room, Description) VALUES('Patient_Id', 'Staff_Id', 'Date', 'Time', 'Room', @tb_description)
            //connect to database
            DBConnection connection = DBConnection.getDBConnectionInstance();
            DataSet DataLogin = connection.getDataSet(query);

            DataRow bookingData = DataLogin.Tables[0].Rows[0];

            tb_bookingid.Text = bookingData["Booking_Id"].ToString();
            tb_patientid.Text = bookingData["Patient_Id"].ToString();
            tb_name.Text = bookingData["Patient_name"].ToString();
            tb_date.Text = bookingData["Time"].ToString();
            tb_doctor.Text = bookingData["Staff_Id"].ToString();
            tb_room.Text = bookingData["Room"].ToString();
            tb_description.Text = bookingData["Description"].ToString();
        }

        private void tb_name_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void bt_save_changes_Click(object sender, RoutedEventArgs e)
        {
            if (System.Windows.MessageBox.Show("Are you sure want to save changes", "Save Booking Changes",
      MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                //code taken from https://stackoverflow.com/questions/4503542/check-for-special-characters-in-a-string
                //makes sure the characters in text boxes are letters, digits or spaces
                if (tb_patientid.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c))
                    && tb_doctor.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c)) && tb_date.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c))
                    && tb_time.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c)) && tb_room.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c)))
                {
                    //creates the query
                    string sqlQuery;
                    //creates the query with parameters instead of data from the user. That data will be inserted in the query later, in the back-end
                    sqlQuery = @"UPDATE Bookings SET Patient_Id = @PatientID, Staff_Id = @DoctorID, Booking_Date = @Date, Time = @Time, Room = @Room, Description = @Description WHERE Booking_Id = 7002";
                    DBConnection connection = DBConnection.getDBConnectionInstance();
                    connection.book(sqlQuery, tb_patientid.Text, tb_doctor.Text, tb_date.Text, tb_time.Text, tb_room.Text, tb_description.Text);
                    System.Windows.MessageBox.Show("Booking updated.");
                }

            }
        }

        private void tb_patient_id_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void bt_home_Click(object sender, RoutedEventArgs e)
        {
            main_screen frm = new main_screen();
            frm.Show();
        }

        private void bt_patients_Click(object sender, RoutedEventArgs e)
        {
            Patients frm = new Patients();
            frm.Show();
        }

        private void bt_staff_Click(object sender, RoutedEventArgs e)
        {
            staff_menu frm = new staff_menu();
            frm.Show();
        }

        //Name of the class your method is in dot and the name of your method 
        
    }
}

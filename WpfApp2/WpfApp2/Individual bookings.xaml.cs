using System;
using System.Collections.Generic;
using System.Linq;
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
        public Individual_bookings()
        {
            InitializeComponent();
        }

        private void bt_cancel_booking_Click(object sender, RoutedEventArgs e)
        {
            // confirmation pop up message
            System.Windows.Forms.MessageBox.Show("Are you sure want to cancel booking", "Cancel Booking",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question); 

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
                if (ID.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c))
                    && Doctor.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c)) && Date.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c))
                    && Time.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c)) && Room.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c)))
                {
                    //creates the query
                    string sqlQuery;
                    //creates the query with parameters instead of data from the user. That data will be inserted in the query later, in the back-end
                    sqlQuery = @"UPDATE Bookings SET Patient_Id = @PatientID, Staff_Id = @DoctorID, Booking_Date = @Date, Time = @Time, Room = @Room, Description = @Description WHERE Booking_Id = 7000";
                    DBConnection connection = DBConnection.getDBConnectionInstance();
                    connection.book(sqlQuery, ID.Text, Doctor.Text, Date.Text, Time.Text, Room.Text, Description.Text);
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
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for booking_screen.xaml
    /// </summary>
    public partial class booking_screen : Window
    {
        string bookingId;
        DataSet bookingData;
        public booking_screen()
        {           
            InitializeComponent();
            string date = DateTime.Today.ToString("MM/dd/yyyy");
            date = date.Split(' ')[0];
            string sqlQuery = @"SELECT Patients.Patient_ID, Patients.Patient_name, Patients.Patient_surname, Bookings.Booking_ID, Bookings.Booking_Date, Bookings.Time, Bookings.Room FROM Patients INNER JOIN Bookings ON Patients.Patient_ID = Bookings.Patient_ID WHERE Bookings.Booking_date = '" + date + "'";
            DBConnection connection = DBConnection.getDBConnectionInstance();
            DataSet todayBookings = connection.getDataSet(sqlQuery);
            DataTable dt = todayBookings.Tables[0];
            bookingsGrid.ItemsSource = dt.DefaultView;
        }

        public booking_screen(string id, DataSet data)
        {
            bookingId = id;
            bookingData = data;
            InitializeComponent();
        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
           
        }

        private void bt_home_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            main_screen frm = new main_screen();
            frm.Show();
            this.Close();
        }

        private void bt_patients_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Patients frm = new Patients();
            frm.Show();
            this.Close();
        }

        private void bt_staff_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            staff_menu frm = new staff_menu();
            frm.Show();
            this.Close();

        }

        private void bt_new_booking_Click(object sender, RoutedEventArgs e)
        {
            Booking_new frm = new Booking_new();
            frm.Show();          
        }
                
        private void bTsearch_Click(object sender, RoutedEventArgs e)
        {
            if (booking_search.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c)))
            {
                //stores what's in the Searchbox in a variable
                string id = booking_search.Text;
                //creates the SQL query
                this.Hide();
                Booking.viewBooking(id, false);
                this.Close();
            }
            else
            {
                MessageBox.Show("No booking found.");
            }
        }
    }
}

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

        private void bt_new_booking_Click(object sender, RoutedEventArgs e)
        {
            Booking_new frm = new Booking_new();
            frm.Show();
        }

        private void button_searchBooking(object sender, ContextMenuEventArgs e)
        {
            if (booking_search.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c)))
            {
                //stores what's in the Searchbox in a variable
                string id = booking_search.Text;
                //creates the SQL query
                string query = @"SELECT * FROM Bookings WHERE Booking_Id = '" + id + "';";

                DBConnection connection = DBConnection.getDBConnectionInstance();
                DataSet bookingData = connection.getDataSet(query);
                //checks that the query returned exactly one result
                int count = bookingData.Tables[0].Rows.Count;

                if (count == 1)
                {
                    booking_screen booking = new booking_screen(id, bookingData);
                    booking.Show();
                }
                else
                {
                    MessageBox.Show("No booking found.");
                }
            }
            else
            {
                MessageBox.Show("No booking found.");
            }
        }
    }
}

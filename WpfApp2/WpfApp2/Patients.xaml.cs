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
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for Patients.xaml
    /// </summary>
    public partial class Patients : Window
    {
        public Patients()
        {
            InitializeComponent();
            string date = DateTime.Today.ToString("MM/dd/yyyy");
            date = date.Split(' ')[0];
            string sqlQuery = @"SELECT Patients.Patient_ID, Patients.Patient_name, Patients.Patient_surname, Bookings.Booking_ID, Bookings.Booking_Date, Bookings.Time, Bookings.Room FROM Patients INNER JOIN Bookings ON Patients.Patient_ID = Bookings.Patient_ID WHERE Bookings.Booking_date = '" + date + "'";
            DBConnection connection = DBConnection.getDBConnectionInstance();
            DataSet todayPatients = connection.getDataSet(sqlQuery);
            DataTable dt = todayPatients.Tables[0];
            dataGrid.ItemsSource = dt.DefaultView;
        }

        private void bt_register_patient_Click(object sender, RoutedEventArgs e)
        {
            Patient_registration frm = new Patient_registration();
            this.Content = frm.Content;
        }

        private void bt_booking_Click(object sender, RoutedEventArgs e)
        {
            booking_screen frm = new booking_screen();
            this.Content = frm.Content;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (SearchBox.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c)))
            {
                //stores what's in the Searchbox in a variable
                string id = SearchBox.Text;
                //creates the SQL query
                string query = @"SELECT * FROM Patients WHERE Patient_Id = '" + id + "';";

                DBConnection connection = DBConnection.getDBConnectionInstance();
                DataSet patientData = connection.getDataSet(query);
                //checks that the query returned exactly one result
                int count = patientData.Tables[0].Rows.Count;

                if (count == 1)
                {
                    individual_patient patient = new individual_patient(id, patientData);
                    patient.Show();
                }
                else
                {
                    MessageBox.Show("No patient found.");
                }
            }
            else
            {
                MessageBox.Show("No patient found.");
            }
        }

        private void bt_home_Click(object sender, RoutedEventArgs e)
        {
            main_screen frm = new main_screen();
            this.Content = frm.Content;
        }

        private void bt_staff_Click(object sender, RoutedEventArgs e)
        {
            staff_menu frm = new staff_menu();
            this.Content = frm.Content;
        }
    }
}

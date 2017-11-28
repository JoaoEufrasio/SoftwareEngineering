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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class staff_individual : Window
    {
        string staffId;
        DataSet staffData;
        public staff_individual(string id, DataSet data)
        {
            InitializeComponent();
            //
            staffId = id;
            staffData = data;
            tb_staff_id.Text = staffId;
            tb_staff_name.Text = staffData.Tables[0].Rows[0].Field<string>("Staff_name").Trim() + " " + staffData.Tables[0].Rows[0].Field<string>("Staff_surname").Trim();
            tb_address.Text = staffData.Tables[0].Rows[0].Field<string>("Staff_street").Trim() + ", " + staffData.Tables[0].Rows[0].Field<string>("Staff_city").Trim() + ", " + staffData.Tables[0].Rows[0].Field<string>("Staff_postcode").Trim();
            tb_dob.Text = staffData.Tables[0].Rows[0].Field<DateTime>("Staff_date_of_birth").ToString().Split(' ')[0];
            tb_contact_details.Text = staffData.Tables[0].Rows[0].Field<string>("Staff_phone_number");
            tb_role.Text = staffData.Tables[0].Rows[0].Field<string>("Role");

            DataTable shifts = Staff.individualShiftsGrid(tb_staff_id.Text);
            DataTable bookings = Staff.individualBookingGrid(tb_staff_id.Text);
            dataGrid.ItemsSource = shifts.DefaultView;
            bookingsGrid.ItemsSource = bookings.DefaultView;

        }

        private void bt_bookings_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void bt_patients_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Patients frm = new Patients();
            frm.Show();
            this.Close();
        }

        private void bt_home_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            main_screen frm = new main_screen();
            frm.Show();
            this.Close();

        }

        private void btn_ookings_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            booking_screen frm = new booking_screen();
            frm.Show();
            this.Close();
        }
        public void viewStaffDetails()
        {
            string query = "SELECT * FROM Staff WHERE Staff_Id = 1";
            //connect to database
            DBConnection connection = DBConnection.getDBConnectionInstance();
            DataSet DataLogin = connection.getDataSet(query);

            DataRow viewStaff = DataLogin.Tables[0].Rows[0];



            tb_staff_id.Text = viewStaff["Staff_ID"].ToString();
            tb_staff_name.Text = viewStaff["Staff_name"].ToString();
            tb_address.Text = viewStaff["Staff_street"].ToString();
            tb_dob.Text = viewStaff["Staff_date_of_birth"].ToString();
            tb_contact_details.Text = viewStaff["Staff_phone_number"].ToString();


        }
        


    }
}

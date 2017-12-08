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
        //A
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
    }
}

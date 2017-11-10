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
            System.Windows.Forms.MessageBox.Show("Are you sure want to save changes", "Save Booking Changes",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void tb_patient_id_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}

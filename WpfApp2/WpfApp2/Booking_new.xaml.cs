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
    /// Interaction logic for Booking_new.xaml
    /// </summary>
    public partial class Booking_new : Window
    {
        public Booking_new()
        {
            InitializeComponent();
        }

        private void bt_confirm_booking_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Are you sure want to save this booking", "Save Booking",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}

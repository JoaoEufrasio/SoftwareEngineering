using System;
using System.Collections.Generic;
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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void bt_bookings_Click(object sender, RoutedEventArgs e)
        {
            booking_screen frm = new booking_screen();
            frm.Show();
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
            Patients frm = new Patients();
            frm.Show();
        }

        private void bt_home_Click(object sender, RoutedEventArgs e)
        {
           main_screen frm = new main_screen();
            frm.Show();

        }
    }
}

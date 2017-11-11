﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class staff_menu : Window
    {
        public staff_menu()
        {
            InitializeComponent();
        }

        private void btn_bookings_Click(object sender, RoutedEventArgs e)
        {
            booking_screen frm = new booking_screen();
            frm.Show();
        }

        private void btn_patients_Click(object sender, RoutedEventArgs e)
        {
            Patients frm = new Patients();
            frm.Show();

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void staff_on_duty_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void staff_name_id_shift_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void btn_home_Click(object sender, RoutedEventArgs e)
        {
            main_screen frm = new main_screen();
            frm.Show();
        }
    }
}

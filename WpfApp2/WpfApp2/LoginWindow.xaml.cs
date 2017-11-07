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

namespace Unit02
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btLogin_click(object sender, RoutedEventArgs e)
        {
            //variables for username and password input
            string user, pass;

            user = textBox.Text;
            pass = passwordBox.Password;

            //verification of empty fields
            if (textBox.Text.Length < 1 || passwordBox.Password.Length < 1)
            {
                MessageBox.Show("Credentials missing. Please enter a username and password.");
                return;
            }
            //validation of username and password combination in DB


            //open main window
            else
            {              
                MainWindow Mw = new MainWindow();
                Mw.Show();
                this.Hide();               

            }

        }
    }
}

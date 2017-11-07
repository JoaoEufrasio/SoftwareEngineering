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
using System.Data.SqlClient;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for login.xaml
    /// </summary>
    public partial class login : Window
    {
        public login()
        {
            InitializeComponent();
        }

        private void btLogin_Click(object sender, RoutedEventArgs e)
        {
            //variables for username and password input
            string user, pass;

            user = textBox.Text;
            pass = passwordBox.Password;

            //verification of empty fields
            if (textBox.Text.Length < 1 || passwordBox.Password.Length < 1)
            {
                MessageBox.Show("Credentials missing. Please enter a username and a password.");
                return;
            }
            //validation of username and password combination in DB

            try
            {

                string query = "SELECT username FROM staff WHERE username=" + user + "AND password=" + pass;


                DBConnection connection = DBConnection.getDBConnectionInstance();
                DataSet DataLogin = connection.getDataSet(query);

                int count = DataLogin.Tables[0].Rows.Count;

                //open main window
                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");
                    this.Hide();
                    main_screen ms = new main_screen();
                    ms.Show();
                }
                else
                {
                    MessageBox.Show("Invalid credentials, please enter registered username and passsword!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}


        private void btExit_click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}

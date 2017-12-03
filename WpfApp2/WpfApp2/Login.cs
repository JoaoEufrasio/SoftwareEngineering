using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp2
{
    class Login
    {

        public static void verifyLogin(string u, string p)
        {     
                string user = u;
                string pass = p;
                string query = "SELECT username FROM staff WHERE username='" + user + "'and password='" + pass + "'";

                DBConnection connection = DBConnection.getDBConnectionInstance();
                DataSet DataLogin = connection.getDataSet(query);

                int count = DataLogin.Tables[0].Rows.Count;

                //open main window
                if (count == 1)
                {
                    MessageBox.Show("Login Successful!");                   
                    main_screen ms = new main_screen();
                    ms.Show();
                }
                else
                {
                    MessageBox.Show("Invalid credentials, please enter registered username and passsword!");
                    login lg = new login();
                    lg.Show();
                }

            }
            
        }
    }


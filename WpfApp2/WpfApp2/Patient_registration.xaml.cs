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
    /// Interaction logic for Patient_registration.xaml
    /// </summary>
    public partial class Patient_registration : Window
    {
        public Patient_registration()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            string[] dateValidation = Date_of_birth.Text.Split('/');
            if (dateValidation.Length == 3)
            {
                int month;
                int day;
                int year;
                bool monthValid = Int32.TryParse(dateValidation[0], out month);
                bool dayValid = Int32.TryParse(dateValidation[1], out day);
                bool yearValid = Int32.TryParse(dateValidation[2], out year);
                if (monthValid && (month < 13) && dayValid && (day < 13) && yearValid)
                {

                    //code taken from https://stackoverflow.com/questions/4503542/check-for-special-characters-in-a-string
                    //makes sure the characters in text boxes are letters, digits or spaces
                    if (Name.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c)) && Surname.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c))
                        && Date_of_birth.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c) || c == '/') && Address_street.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c))
                        && Address_city.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c)) && Address_postcode.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c))
                        && Phone.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c)) && Phone_emergency.Text.Any(c => Char.IsLetterOrDigit(c) || Char.IsWhiteSpace(c)))
                    {
                        try
                        {
                            Patient.registerPatient(Name.Text, Surname.Text, Date_of_birth.Text, Address_street.Text, Address_city.Text, Address_postcode.Text, Phone.Text, Phone_emergency.Text, Mail.Text);
                            this.Close();
                        }
                        catch
                        {
                            MessageBox.Show("Some or all of the data fields have invalid content. Please check the data entered");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Some or all of the data fields have invalid content. Please check the data entered.");
                    }

                }
                else
                {
                    MessageBox.Show("Invalid date entered. Please check for errors and try again");
                }
            }
            else
            {
                MessageBox.Show("Invalid date entered. Please check for errors and try again");
            }
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Date_of_birth_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}

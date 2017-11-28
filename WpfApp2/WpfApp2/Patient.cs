using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Windows.Controls;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WpfApp2
{
    static class Patient
    {
        public static void searchPatient(string id, bool main)
        {
            //creates the SQL query
            string query = @"SELECT * FROM Patients WHERE Patient_Id = '" + id + "';";
            DBConnection connection = DBConnection.getDBConnectionInstance();
            DataSet patientData = connection.getDataSet(query);
            //checks that the query returned exactly one result
            int count = patientData.Tables[0].Rows.Count;

            if (count == 1)
            {
                individual_patient patient = new individual_patient(id, patientData);
                patient.Show();
            }
            else
            {
                MessageBox.Show("No patient found.");
                if (main)
                {
                    main_screen frm = new main_screen();
                    frm.Show();
                }
                else
                {
                    Patients frm = new Patients();
                    frm.Show();
                }
            }
        }

        public static void searchPatientName(string[] name, bool main)
         {
 
             //create sql statement
             DBConnection connection = DBConnection.getDBConnectionInstance();
             if (name[2].Contains('/'))
             {
                 string sqlQuery = @"SELECT * FROM Patients WHERE Patient_name = '" + name[0] + "' AND Patient_surname = '" + name[1] + "' AND Patient_date_of_birth = '" + name[2] + "';";
                 DataSet patientData = connection.getDataSet(sqlQuery);
                 //checks that the query returned exactly one result
                 int count = patientData.Tables[0].Rows.Count;
 
                 if (count == 1)
                 {
                     individual_patient patient = new individual_patient(patientData.Tables[0].Rows[0].Field<int>("Patient_Id").ToString(), patientData);
                     patient.Show();
                 }
                 else
                 {
                     MessageBox.Show("No patient found.");
                 }
             }
             else
             {
 
 
                 string query = @"SELECT * FROM Patients WHERE Patient_name = '" + name[0] + "' AND Patient_surname = '" + name[1] + "' AND Patient_postcode = '" + name[2] + "';";
                 DataSet patientDataPostcode = connection.getDataSet(query);
                 //checks that the query returned exactly one result
                 int count = patientDataPostcode.Tables[0].Rows.Count;
 
               if (count == 1)
                 {
                     individual_patient patient = new individual_patient(patientDataPostcode.Tables[0].Rows[0].Field<int>("Patient_Id").ToString(), patientDataPostcode);
                     patient.Show();
                 }
                else
                 {
                     MessageBox.Show("No patient found.");
                }
            }
             
             
             
         }

        public static DataTable patientsGrid()
        {
            string date = DateTime.Today.ToString("MM/dd/yyyy");
            date = date.Split(' ')[0];
            string sqlQuery = @"SELECT Patients.Patient_ID AS ID, Patients.Patient_name AS Name, Patients.Patient_surname AS Surname, Patients.Patient_phone_number AS Number, Staff.Staff_surname AS Doctor FROM Patients INNER JOIN Bookings ON Patients.Patient_ID = Bookings.Patient_ID INNER JOIN Staff ON Bookings.Staff_ID = Staff.Staff_ID WHERE Bookings.Booking_date = '" + date + "'";
            DBConnection connection = DBConnection.getDBConnectionInstance();
            DataSet todayPatients = connection.getDataSet(sqlQuery);
            DataTable dt = todayPatients.Tables[0];
            return dt;
        }
    }
}

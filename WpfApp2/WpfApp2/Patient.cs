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
        public static void searchPatient(string id)
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

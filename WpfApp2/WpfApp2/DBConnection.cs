using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class DBConnection
    {
        //attributes
        private static DBConnection _instance;

        private static string connectionString;

        private SqlConnection connectionToDB;

        private SqlDataAdapter dataAdapter;


        //properties
        public static string ConnectionStr
        {
            set
            {
                connectionString = value;
            }
        }

        //methods
        public static DBConnection getDBConnectionInstance()
        {
            if (_instance == null)
                _instance = new DBConnection();

            return _instance;
        }

        // Open the connection
        public void openConnection()
        {
            
            ConnectionStr = @"";
            // create the connection to the database as an instance of SqlConnection
            connectionToDB = new SqlConnection(connectionString);

            //open connection
            connectionToDB.Open();
        }

        public void closeConnection()
        {
            connectionToDB.Close();
        }


       //create a data set for a certain request
        public DataSet getDataSet(String sqlStatement)
        {
            DataSet dataSet = new DataSet();

            //open connection
            openConnection();

            //create the data adapter object
            dataAdapter = new SqlDataAdapter(sqlStatement, connectionToDB);

            //fill in the data set
            dataAdapter.Fill(dataSet);

            //close connection
            closeConnection();

            return dataSet;
        }

        //create a patient record in the database. Data from the user is inserted into the query here as parameters, rather than directly on the front-end
        public void register(string sqlQuery, string name, string surname, string date_of_birth, string street, string city, string postcode, string phone, string emergency_phone, string email)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;
            //inserts the data in the query
            command.Parameters.Add(new SqlParameter("Name", name));
            command.Parameters.Add(new SqlParameter("Surname", surname));
            command.Parameters.Add(new SqlParameter("Date_of_birth", date_of_birth));
            command.Parameters.Add(new SqlParameter("Street", street));
            command.Parameters.Add(new SqlParameter("City", city));
            command.Parameters.Add(new SqlParameter("Postcode", postcode));
            command.Parameters.Add(new SqlParameter("Phone", phone));
            command.Parameters.Add(new SqlParameter("Emergency_phone", emergency_phone));
            command.Parameters.Add(new SqlParameter("Email", email));
            //open the connection
            openConnection();
            command.Connection = connectionToDB;
            //executes the query and closes the connection
            command.ExecuteNonQuery();
            closeConnection();
        }

        //create a new booking
        public void book(string sqlQuery, string patientID, string doctorID, string date, string time, string room, string description)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;
            //inserts the data in the query
            command.Parameters.Add(new SqlParameter("PatientID", patientID));
            command.Parameters.Add(new SqlParameter("DoctorID", doctorID));
            command.Parameters.Add(new SqlParameter("Date", date));
            command.Parameters.Add(new SqlParameter("Time", time));
            command.Parameters.Add(new SqlParameter("Room", room));
            command.Parameters.Add(new SqlParameter("Description", description));
            //open the connection
            openConnection();
            command.Connection = connectionToDB;
            //executes the query and closes the connection
            command.ExecuteNonQuery();
            closeConnection();
        }


        /*
        * Insert the name and age into the DB
        */
        public void insert(string sqlQuery, String name, int age)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;
            command.Parameters.Add(new SqlParameter("Name", name));
            command.Parameters.Add(new SqlParameter("Age", age));

            openConnection();
            command.Connection = connectionToDB;

            int noRows = command.ExecuteNonQuery();

            closeConnection();

            Console.WriteLine("n-" + noRows);
        }

    }
}

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
            
            ConnectionStr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=K:\SoftwareEngineering-master\WpfApp2\WpfApp2\Database1.mdf;Integrated Security=True";
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

        //create a patient record in the database
        public void register(string sqlQuery)
        {
            SqlCommand command = new SqlCommand();
            command.CommandType = CommandType.Text;
            command.CommandText = sqlQuery;
            openConnection();
            command.Connection = connectionToDB;
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

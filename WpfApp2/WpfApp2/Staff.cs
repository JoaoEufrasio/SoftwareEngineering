using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class Staff
    {
        public static void viewStaff()
        {
            string query = "SELECT * FROM Staff WHERE Staff_Id = 1";
            
            
            //connect to database
            DBConnection connection = DBConnection.getDBConnectionInstance();
            DataSet DataLogin = connection.getDataSet(query);


            //tb_staff_id.Text = ["Staff_Id"].ToString();
        }
    }
}

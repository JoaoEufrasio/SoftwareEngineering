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
    static class Staff
    {
        public static void viewStaff(string id)
        {
            string query = @"SELECT * FROM Staff WHERE Staff_ID = '" + id + "';";


            //connect to database
            DBConnection connection = DBConnection.getDBConnectionInstance();
            DataSet staffData = connection.getDataSet(query);
            int count = staffData.Tables[0].Rows.Count;


            if (count == 1)
            {
                staff_individual staff = new staff_individual(id, staffData);
                staff.Show();
            }
            else
            {
                MessageBox.Show("No staff member found.");
            }
        


}
    }
}

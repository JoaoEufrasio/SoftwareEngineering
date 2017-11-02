using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test2017
{
    public partial class Form1 : Form
    {

        /*
         * Update the GridView
         */
        private void updateGridView()
        {
            // populate the GridView
            DataSet dsPerson = DBConnection.getDBConnectionInstance().getDataSet(Constants.SelectAll);
            //get the only table in the dataset person
            DataTable table = dsPerson.Tables[0];

            //set up the data grid view
            dgvPerson.DataSource = table;


        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            updateGridView();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            //insert into the DB the name and age coming from the text boxes
            DBConnection.getDBConnectionInstance().insert(Constants.Insert,
                                                        tbName.Text,
                                                        Convert.ToInt32(tbAge.Text));

            //update the gridview (helpful to check if the new row was correctly inserted in the DB)
            updateGridView();

        }


    }
}

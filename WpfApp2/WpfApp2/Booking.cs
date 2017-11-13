using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2
{
    class Booking 
    {  
        
        public string Booking_Id { get; set; }
        public string Patient_Id { get; set; }
        public string Staff_Id { get; set; }
        public string Booking_date { get; set; }
        public string Time { get; set; }
        public string Description { get; set; }

    
        public void RegisterNewBooking()
        {

            //connect to database
             DBConnection connection = DBConnection.getDBConnectionInstance();  


        }


    }
}

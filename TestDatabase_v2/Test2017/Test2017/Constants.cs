using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2017
{
    class Constants
    {
        public static String SelectAll = "SELECT * FROM person";
        public static String SelectAllOver20 = "SELECT * FROM person WHERE Age>20";
        public static String Insert = "INSERT INTO Person (Name, Age) VALUES (@Name, @Age)";
    }
}

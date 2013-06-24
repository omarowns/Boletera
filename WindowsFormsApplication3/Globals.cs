using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletera{
    static class Globals
    {
        public static MySQLConnector connector = new MySQLConnector("localhost","root","boletera",3306,"toor");

        public static string server;
        public static string user;
        public static uint port;
        public static string password;
    }
}

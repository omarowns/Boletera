using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySQLConnector;

namespace BoleteraNS
{
    static class Globals
    {
        public static MySQLConnector.MySQLConnector connector = new MySQLConnector.MySQLConnector();
        public static string server;
        public static string user;
        public static uint port;
        public static string password;
    }
}

using System;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Entity;

namespace Boletera
{
    class MySQLConnector
    {
        //Connection StringBuilder
        private MySqlConnectionStringBuilder connData;
        //Connection object
        private MySqlConnection conn;
        //Command
        private MySqlCommand cmd;

        //Getters and Setters
        public MySqlConnectionStringBuilder ConnData { get { return connData; } }
        public MySqlConnection Conn { get { return conn; }}

        public MySQLConnector(string server = "localhost",string user="root",string database="boletera",uint port=3306,string password="sa123")
        {
            connData = new MySqlConnectionStringBuilder();
            //Datos de la conexión
            connData.Server = server;
            connData.UserID = user;
            connData.Database = database;
            connData.Port = port;
            connData.Password = password;
            Globals.server = server;
            Globals.password = password;
            Globals.port = port;
            Globals.user = user;
            
            doConnect();
        }

        private void doConnect()
        {
            //Carga los datos de la conexión
            conn = new MySqlConnection(connData.ToString());
            try
            {
                //Abre la conexión
                conn.Open();
            }catch(MySqlException ex){
                Console.WriteLine("Error en tiempo de ejecución: {0}", ex.Message);
            }
        }

        public MySqlDataReader getReader(string query)
        {
            try
            {
                MySqlDataReader rdr;
                cmd = new MySqlCommand(query,conn);
                rdr = cmd.ExecuteReader();
                return rdr;
            }catch(MySqlException ex){
                Console.WriteLine("Error: {0}",ex.Message);
                return null;
            }
        }

        public object getEscalar(string query)
        {
            try
            {
                Object obj;
                cmd = new MySqlCommand(query, conn);
                obj = cmd.ExecuteScalar();
                return obj;
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
                return null;
            }
        }

        public void update(string query)
        {
            try
            {
                cmd = new MySqlCommand(query, conn);
                cmd.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("Error: {0}", ex.Message);
            }
        }

        
      
    }
}

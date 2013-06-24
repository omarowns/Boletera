using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.Entity;
using MySql.Data.MySqlClient;

namespace Boletera
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonAccess_Click(object sender, EventArgs e)
        {
           //Verificar datos en la tabla

            string name = textBoxUser.Text; 
            string password = textBoxPassword.Text;
            string queryUser = "select nombre,password from usuario"
                    + " where nombre like '" + name + "' and password=PASSWORD('" + password + "');";
            string queryAdmin = "select nombre,password from administrador"
                    + " where nombre like '" + name + "' and password=PASSWORD('" + password + "');";

            MySqlDataReader reader = Globals.connector.getReader(queryUser);

            while (reader.Read())
            {
                goto USUARIO;     
            }
            reader.Close();
            reader = Globals.connector.getReader(queryAdmin);
            while (reader.Read())
            {
                goto ADMIN;
            }
            goto ERROR;

            //Buscar en resultados de usuarios
            ADMIN:
            MessageBox.Show("Administrador correcto");
<<<<<<< HEAD
            Globals.connector = new MySQLConnector("localhost","admin","boletera",3306,"admin");
=======
            Globals.connector = new MySQLConnector(user: "user", password: "user");
>>>>>>> e9e50e19317b606280e6d313e8163a0694d05151
            admin adm = new admin();
            this.Hide();
            adm.ShowDialog(this);
            this.Show();
            goto JUMP;

            USUARIO:
            MessageBox.Show("Usuario correcto");
<<<<<<< HEAD
            Globals.connector = new MySQLConnector("localhost","user","boletera",3306,"user");
=======
            Globals.connector = new MySQLConnector(user: "admin", password: "admin");

>>>>>>> e9e50e19317b606280e6d313e8163a0694d05151
            CobroEmision ce = new CobroEmision(name);
            this.Hide();
            ce.ShowDialog(this);
            this.Show();
            goto JUMP;

            ERROR:
            MessageBox.Show("ERROR");

            JUMP:
            reader.Close();
            textBoxUser.Text = "";
            textBoxPassword.Text = "";
        }

        private void linkAdvanced_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            OpcionesAvanzadas advancedWindow=new OpcionesAvanzadas();
            advancedWindow.ShowDialog(this);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class OpcionesAvanzadas : Form
    {
        
        public OpcionesAvanzadas()
        {
            InitializeComponent();
            this.textBoxServer.Text = Globals.server;
            this.textBoxPassword.Text = Globals.password;
            this.textBoxPort.Text = Globals.port.ToString();
            this.textBoxUser.Text = Globals.user;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.OpenForms["Login"].Show();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Globals.server = textBoxServer.Text;
            Globals.user = textBoxUser.Text;
            Globals.port = Convert.ToUInt32(textBoxPort.Text);
            Globals.password = textBoxPassword.Text;
            Globals.connector = new MySQLConnector(Globals.server , Globals.user , "boletera" , Globals.port , Globals.password);
            if (Globals.connector.Conn.State != ConnectionState.Open)
            {
                MessageBox.Show(this, "Error en la conexión a la base de datos, verifique los parámetros de conexión", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.Close();
            }
        }

        private void textBoxPort_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
                {
                    e.Handled = false;
                }
                else
                {
                    //el resto de teclas pulsadas se desactivan 
                    e.Handled = true;
                } 
        }

        private void textBoxPort_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBoxPort_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void textBoxPort_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            
        }

        private void button_TestConn_Click(object sender, EventArgs e)
        {
            Globals.connector = new MySQLConnector(Globals.server, Globals.user, "boletera", Globals.port, Globals.password);
            if (Globals.connector.Conn.State == ConnectionState.Open)
            {
                MessageBox.Show("La conexión con la base de datos ha sido exitosa");
            }
            else
            {
                MessageBox.Show(null,"Error en la conexión a la base de datos, verifique los parámetros de conexión","Error de conexión",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}

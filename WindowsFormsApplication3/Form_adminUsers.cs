using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

using MySql.Data.MySqlClient;

namespace Boletera
{
    public partial class Form_adminUsers : Form
    {
        //atributos para el manejo de usuarios
        MySqlDataAdapter dataSource;
        DataSet ds_Delete,ds_Update,ds_Turn,ds_Rol;
        String[] columnName = { "ID", "Nombre", "Turno", "Rol", "Ultimo acceso" };

        public Form_adminUsers()
        {
            InitializeComponent();
        }

        private void Form_adminUsers_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'boleteraDataSet.usuario' Puede moverla o quitarla según sea necesario.
            fillUsuarioDatagrid();
            fillDataSource();
            
            
        }

        private void fillDataSource()
        {
            dataSource = new MySqlDataAdapter("select id,nombre from usuario where usuario.password <> password('deleted_user');", Globals.connector.Conn);
            ds_Delete = new DataSet();
            ds_Update = new DataSet();
            ds_Turn = new DataSet();
            ds_Rol = new DataSet();

            dataSource.Fill(ds_Delete);
            dataSource.Fill(ds_Update);
            dataSource.Fill(ds_Turn);
            dataSource.Fill(ds_Rol);

            comboBox_BajaUsuario.DataSource = ds_Delete.Tables[0];
            comboBox_BajaUsuario.DisplayMember = "nombre";

            comboBox_UsuarioCambio.DataSource = ds_Update.Tables[0];
            comboBox_UsuarioCambio.DisplayMember = "nombre";

            comboBox_Rol.DataSource = ds_Rol.Tables[0];
            comboBox_Rol.DisplayMember = "nombre";

            comboBox_Turno.DataSource = ds_Turn.Tables[0];
            comboBox_Turno.DisplayMember = "nombre";

        }

        private void fillUsuarioDatagrid()
        {
            dataSource = new MySqlDataAdapter("SELECT id,nombre,turno,rol,ultimo_login FROM usuario WHERE usuario.password <> password('deleted_user');", Globals.connector.Conn);
            ds_Delete = new DataSet();
            dataSource.Fill(ds_Delete);

            //Cambiar el nombre de las columnas para que se visualice correctamente
            for (int i = 0; i < ds_Delete.Tables[0].Columns.Count; i++)
            {
                ds_Delete.Tables[0].Columns[i].ColumnName = columnName[i];
            }

            usuarioDataGridView.DataSource = ds_Delete.Tables[0];
        }


        private void cmd_NuevoUsuario_Click(object sender, EventArgs e)
        {
            //Invoca a la venta de nuevo usuario mandandole el DataSet
            Form_newUsercs n = new Form_newUsercs();
            n.ShowDialog(this);
            //Actualizamos origenes de datos
            fillUsuarioDatagrid();
            fillDataSource();
        }

        private void cmd_Exit_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //Baja de usuario de la base de datos

        private void comboBox_BajaUsuario_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedUserID = (int) comboBox_BajaUsuario.SelectedValue;
            string userName = (string) Globals.connector.getEscalar(String.Format("SELECT nombre from usuario WHERE id={0}", selectedUserID).ToString());
            //Construcción de la consulta
            string query = "UPDATE usuario SET password=password('deleted_user') WHERE id = " + selectedUserID;
            //Ejecución
            if (MessageBox.Show(null,"¿Está seguro que desea dar de baja al usuario " + userName +"?","Baja de usuarios",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes) 
                Globals.connector.update(query);
            //Actualizamos origenes de datos
            fillUsuarioDatagrid();
            fillDataSource();
        }

        private void comboBox_UsuarioCambio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedUserID = (int)comboBox_UsuarioCambio.SelectedValue;
            string userName = (string)Globals.connector.getEscalar(String.Format("SELECT nombre from usuario WHERE id={0}", selectedUserID).ToString());
            string newPassword = Microsoft.VisualBasic.Interaction.InputBox("Ingrese la contraseña nueva para el usuario " + userName, "Cambio de contraseña");
            if (newPassword != ""){
                //Construcción de la consulta
                string query = "UPDATE usuario SET password=password('deleted_user') WHERE id = " + selectedUserID;
                //Ejecución
                if (MessageBox.Show(null, "¿Está seguro que desea cambiar la contraseña del usuario " + userName + "?", "Confirmar cambio de contraseña", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Globals.connector.update(query);
            //Actualizamos origenes de datos
            fillUsuarioDatagrid();
            }
        }

        private void comboBox_Turno_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedUserID = (int)comboBox_Turno.SelectedValue;
            string userName = (string)Globals.connector.getEscalar(String.Format("SELECT nombre from usuario WHERE id={0}", selectedUserID).ToString());
            string newTurn = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nuevo turno para  " + userName, "Cambio de turno");
            if (newTurn != "")
            {
                //Construcción de la consulta
                string query = string.Format("UPDATE usuario SET turno = '{0}' WHERE id = {1}", newTurn, selectedUserID);
                //Ejecución
                if (MessageBox.Show(null,String.Format("¿Está seguro el turno de {0} a {1}?",userName,newTurn), "Confirmar cambio de turno", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Globals.connector.update(query);
                //Actualizamos origenes de datos
                fillUsuarioDatagrid();
            }
        }

        private void comboBox_Rol_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int selectedUserID = (int)comboBox_Rol.SelectedValue;
            string userName = (string)Globals.connector.getEscalar(String.Format("SELECT nombre from usuario WHERE id={0}", selectedUserID).ToString());
            string newRole = Microsoft.VisualBasic.Interaction.InputBox("Ingrese el nuevo rol para  " + userName, "Cambio de rol");
            if (newRole != "")
            {
                //Construcción de la consulta
                string query = string.Format("UPDATE usuario SET rol = '{0}' WHERE id = {1}?", newRole, selectedUserID);
                //Ejecución
                if (MessageBox.Show(null, String.Format("¿Está seguro el turno de {0} a {1}", userName, newRole), "Confirmar cambio de rol", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    Globals.connector.update(query);
                //Actualizamos origenes de datos
                fillUsuarioDatagrid();
            }
        }

    }
}

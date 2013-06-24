/*
 * Created by SharpDevelop.
 * User: Alejandro
 * Date: 09/06/2013
 * Time: 03:30 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic;

using MySql.Data.MySqlClient;

namespace Boletera
{
	/// <summary>
	/// Description of Form_admin_tarifas.
	/// </summary>
	/// 
	
	public partial class admin_tarifas : Form
	{
		MySQLConnector conn;
		MySqlDataAdapter aux;
		string currentUser;
		
		public admin_tarifas()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			actualizar();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		admin_tarifas(string cu,MySQLConnector con)
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			currentUser=cu;
			conn=con;
			InitializeComponent();
			actualizar();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public void actualizar(){
            conn = Globals.connector;
			aux = new MySqlDataAdapter("select tarifa.id,tarifa.convenio_id,convenio.nombre,tarifa.descripcion,tarifa.monto from boletera.convenio join boletera.tarifa where convenio.id = tarifa.convenio_id",conn.Conn);
			DataSet DS = new DataSet();
			aux.Fill(DS);
			tabla_tar.DataSource = DS.Tables[0];
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			
		}
		
		void Btn_salirClick(object sender, EventArgs e)
		{
			Dispose();
		}
		
		void ListBox1SelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void Tabla_tarRowValidated(object sender, DataGridViewCellEventArgs e)
		{
			DataTable changes = ((DataTable)tabla_tar.DataSource).GetChanges();
			
			if(changes!=null){
				aux = new MySqlDataAdapter("select * from boletera.tarifa ",conn.Conn);
				MySqlCommandBuilder mcb = new MySqlCommandBuilder(aux);
				aux.UpdateCommand = mcb.GetUpdateCommand();
				aux.Update(changes);
				((DataTable)tabla_tar.DataSource).AcceptChanges();				
			}
		}
		
		void ActualizarClick(object sender, EventArgs e)
		{
			actualizar();
		}
		
		void Label2Click(object sender, EventArgs e)
		{
			
		}
		
		void Btn_nuevoClick(object sender, EventArgs e)
		{
		}
	}
}

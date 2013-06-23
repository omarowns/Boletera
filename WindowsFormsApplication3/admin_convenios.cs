/*
 * Created by SharpDevelop.
 * User: Alejandro
 * Date: 22/06/2013
 * Time: 06:56 p.m.
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
	/// Description of convenios.
	/// </summary>
	public partial class admin_convenios : Form
	{
		MySQLConnector conn;
		MySqlDataAdapter aux;
		
		public admin_convenios()
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
		
		public void actualizar(){
			conn = new MySQLConnector();
			aux = new MySqlDataAdapter("select * from boletera.convenio",conn.Conn);
			DataSet DS = new DataSet();
			aux.Fill(DS);
			tabla_cnv.DataSource = DS.Tables[0];
		}
		
		void Act_cnvClick(object sender, EventArgs e)
		{
			actualizar();
		}
		
		void Salir_cnvClick(object sender, EventArgs e)
		{
			Dispose();
		}
		
		void Tabla_cnvRowValidated(object sender, DataGridViewCellEventArgs e)
		{
			DataTable changes = ((DataTable)tabla_cnv.DataSource).GetChanges();
			
			if(changes!=null){
				MySqlCommandBuilder mcb = new MySqlCommandBuilder(aux);
				aux.UpdateCommand = mcb.GetUpdateCommand();
				aux.Update(changes);
				((DataTable)tabla_cnv.DataSource).AcceptChanges();				
			}
		}
	}
}

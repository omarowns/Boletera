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
			aux = new MySqlDataAdapter("select * from boletera.convenio",Globals.connector.Conn);
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
                aux.Dispose();
                mcb.Dispose();
                updateTarifas();
			}
		}

        private static void updateTarifas()
        {
            double[] monto = { 0, 0 };
            System.Collections.Generic.List<string> updates = new System.Collections.Generic.List<string>();
            int c = 0;
            MySql.Data.MySqlClient.MySqlDataReader reader = Globals.connector.getReader("SELECT monto FROM tarifa LIMIT 2");
            while (reader.Read())
            {
                monto[c] = Convert.ToDouble(reader[0]);
                c++;
            }
            reader.Close();
            reader = Globals.connector.getReader("SELECT tarifa.id,tarifa.monto,convenio.id,convenio.cortesia_hr,convenio.cortesia_fija FROM tarifa JOIN convenio WHERE tarifa.convenio_id=convenio.id;");
            while (reader.Read())
            {
                int tarifa_id = Convert.ToInt32(reader[0]);
                double cortesia_hr = Convert.ToDouble(reader[3]);
                double cortesia_fija = Convert.ToDouble(reader[4]);
                if (tarifa_id % 2 == 0)
                {
                    string update = "UPDATE tarifa SET monto=" + (monto[1] - ((cortesia_fija / 100) * monto[1])) + " WHERE id=" + tarifa_id;
                    updates.Add(update);
                }
                else
                {
                    string update = "UPDATE tarifa SET monto=" + (monto[0] - ((cortesia_hr / 100) * monto[0])) + " WHERE id=" + tarifa_id;
                    updates.Add(update);
                }
            }
            reader.Close();
            foreach (string update in updates)
            {
                Globals.connector.update(update);
            }
        }
	}
}

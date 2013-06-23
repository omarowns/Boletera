using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;

namespace Boletera
{

    public partial class CobroEmision : Form
    {
        private bool sesionCerrada = false;
        private string currentUser;
        //private MySQLConnector.MySQLConnector connector;
        private int convenio_id = 1;

        public CobroEmision()
        {
            InitializeComponent();  
        }

        public CobroEmision(string user)
        {
            InitializeComponent();
            
            this.Text = "Boletera - " + user;
            currentUser = user;
            updateBoletosEmitidos();            
            Globals.connector.update("UPDATE usuario SET ultimo_login=NOW() WHERE nombre like '" + user + "'");
            
        }

        private void updateBoletosEmitidos()
        {
            object t = Globals.connector.getEscalar("SELECT COUNT(*) FROM ticket");
            boletosEmitidos.Text = Convert.ToString(t);
        }

        //public CobroEmision(string currentUser , MySQLConnector.MySQLConnector connector)
        //{
        //    // TODO: Complete member initialization
        //    InitializeComponent();
        //    this.currentUser = currentUser;
        //    this.connector = connector;
        //    updateBoletosEmitidos();
        //}

        private void CobroEmision_Load(object sender, EventArgs e)
        {
            fechaLabel.Text = DateTime.Now.ToString(@"dd/MM/yyy");
            string tarifa_name = Convert.ToString(Globals.connector.getEscalar("SELECT nombre FROM convenio WHERE id=" + convenio_id.ToString()));
            tarifaSeleccionada.Text = tarifa_name;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ConveniosTarifas cf = new ConveniosTarifas();
            cf.Convenio_ID = convenio_id;
            cf.ShowDialog(this);
            convenio_id = cf.Convenio_ID;

            MySqlDataReader rdr = Globals.connector.getReader("SELECT nombre FROM convenio WHERE id=" + convenio_id);
            string tarifa_name = "";
            while (rdr.Read())
            {
                tarifa_name = Convert.ToString(rdr[0]);
            }
            rdr.Close();
            tarifaSeleccionada.Text = tarifa_name;
        }

        private void emitirBoleto_Click(object sender, EventArgs e)
        {
            //TODO Añadir sentencia para emitir boleto e impresion del mismo. Actualizar numero de boletos
            MySqlDataReader rdr = Globals.connector.getReader("SELECT id FROM usuario WHERE nombre like '" + this.currentUser + "'");
            int user_id = 0;
            while (rdr.Read())
            {
                user_id = Convert.ToInt32(rdr[0]);
            }
            rdr.Close();

            string gettarifa = "SELECT tarifa.id FROM convenio JOIN tarifa WHERE tarifa.convenio_id=convenio.id AND convenio.id="+convenio_id;
            int tarifa_id = 0;
            object []tarif = {null,null};
            int counter = 0;
            rdr = Globals.connector.getReader(gettarifa);
            while (rdr.Read())
            {
                tarif[counter] = rdr[0];
                counter++;
            }
            rdr.Close();
            if (tarifaPorHora.Checked)
                tarifa_id = Convert.ToInt32(tarif[0]);
            else
                tarifa_id = Convert.ToInt32(tarif[1]);
            string ticket_builder = "INSERT INTO ticket(entrada_at,salida_at,monto_cobrado,usuario_id,tarifa_id) VALUES(NOW(),null,null,"+user_id+","+tarifa_id+")";
            Globals.connector.update(ticket_builder);
            updateBoletosEmitidos();
            
        }

        private void cobrarBoleto_Click(object sender, EventArgs e)
        {
            if (inputBoleto.Text.Equals(""))
            {
                MessageBox.Show("Introduzca el número de boleto");
                goto FINAL;
            }
            //TODO Tomar el numero del textbox de cobrodeboletos y buscarlo en la BD, revisar el tipo de convenio que tiene, aplicar tarifas y mostrarlo
            int id_boleto = int.Parse(inputBoleto.Text);
            string update = "UPDATE ticket SET salida_at=NOW() WHERE id="+id_boleto;
            Globals.connector.update(update);

            double monto = 0;
            int tarifaID = 0;
            MySqlDataReader rdr = Globals.connector.getReader("SELECT tarifa.monto,tarifa.id FROM ticket JOIN tarifa WHERE ticket.tarifa_id=tarifa.id AND ticket.id=" + id_boleto);
            while (rdr.Read())
            {
                monto = Convert.ToDouble(rdr[0]);
                tarifaID = Convert.ToInt32(rdr[1]);
            }
            rdr.Close();
            //Obtener horas de entrada y salida
            DateTime entrada_at = new DateTime();
            DateTime salida_at = new DateTime();
            rdr = Globals.connector.getReader("SELECT entrada_at,salida_at FROM ticket WHERE id=" + id_boleto);
            while (rdr.Read())
            {
                entrada_at = Convert.ToDateTime(rdr[0]);
                salida_at = Convert.ToDateTime(rdr[1]);
            }
            rdr.Close();
            TimeSpan span = salida_at.Subtract(entrada_at);
            double timediff = span.Hours;
            timediff += span.Minutes > 10 ? 1 : 0;
            timediff += span.Days * 24;
            double total = 0;

            if (tarifaID % 2 == 0)
            {
                //Aplica tarifa fija
                total = monto;
            }
            else
            {
                //Aplica tarifa por hora
                total = monto * timediff;
            }
            tiempoTotal.Text = span.ToString();
            importeTotal.Text = "$" + total.ToString();
            //Insertar DIALOGO MODAL con boton de COBRAR para hacer update de monto_cobrado
            MessageBox.Show("COBRADO");
            string update_monto_cobrado = "UPDATE ticket SET monto_cobrado=" + total + " WHERE id=" + id_boleto;
            Globals.connector.update(update_monto_cobrado);
            
            FINAL:
            inputBoleto.Text = "";
        }

        private void closesession_Click(object sender , EventArgs e)
        {
            sesionCerrada = true;
            closeForm();
        }
        private bool fileInUse(string file)
        {
            try
            {
                //if (!System.IO.File.Exists(file)) { return false; }
                using (System.IO.FileStream stream = new System.IO.FileStream(file , System.IO.FileMode.Open))
                {
                    return false;
                }
            }
            catch
            {
                return true;
            }
        }

        private void CobroEmision_FormClosed(object sender , FormClosedEventArgs e)
        {
            if(!sesionCerrada)
            closeForm();
        }
        void closeForm(){
            MySqlDataReader rdr = Globals.connector.getReader("SELECT id FROM usuario WHERE nombre like '" + this.currentUser + "'");
            int user_id = 0;
            while (rdr.Read())
            {
                user_id = Convert.ToInt32(rdr[0]);
            }
            rdr.Close();
            string tickets = "SELECT boletera.ticket.id, boletera.ticket.entrada_at, boletera.ticket.salida_at, boletera.ticket.monto_cobrado, boletera.usuario.nombre, boletera.usuario.turno, boletera.usuario.rol FROM boletera.ticket JOIN boletera.usuario WHERE boletera.ticket.usuario_id=" + user_id + " AND boletera.ticket.usuario_id=boletera.usuario.id AND boletera.ticket.entrada_at > boletera.usuario.ultimo_login;";
            string last_login_query = "SELECT ultimo_login FROM usuario WHERE nombre like '" + currentUser + "'";
            DateTime last_login = new DateTime();
            MySqlDataReader reader = Globals.connector.getReader(last_login_query);
            while (reader.Read())
            {
                last_login = Convert.ToDateTime(reader[0]);
            }
            reader.Close();
            string[] encabezados = { "ID TICKET" , "ENTRADA" , "SALIDA" , "MONTO COBRADO" , "USUARIO" , "TURNO" , "ROL" };
            string excel_file = Application.StartupPath + @"\" + currentUser + "_" + last_login.ToString("dMyhhmm") + ".xlsx";
            Excel.Application excel = new Excel.Application();
            Excel.Workbook workbook = excel.Workbooks.Add();
            DataTable dt = new DataTable();
            MySqlDataAdapter da = new MySqlDataAdapter(tickets , Globals.connector.Conn);
            da.Fill(dt);
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets.get_Item(1);
            DataRowCollection rows = dt.Rows;
            DataRow row;
            for (int i = 1 ; i <= rows.Count + 1 ; i++)
            {
                if (i != 1)
                    row = rows[i - 2];
                else
                    row = null;

                for (int j = 1 ; j <= 7 ; j++)
                {
                    if (i == 1)
                        worksheet.Cells[i , j] = encabezados[j - 1];
                    else
                        worksheet.Cells[i , j] = row.ItemArray[j - 1].ToString();
                }
            }
            workbook.SaveAs(excel_file);
            excel.Quit();
            this.Dispose();
        }
    }
}

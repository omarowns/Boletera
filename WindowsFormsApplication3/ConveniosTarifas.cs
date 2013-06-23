using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BoleteraNS;

namespace BoleteraUsuarioEmision
{
    public partial class ConveniosTarifas : Form
    {
        //private MySQLConnector.MySQLConnector connector;
        private ArrayList convenio_radio_button = null;
        private static int convenio_id_selected;
        public int Convenio_ID { get { return convenio_id_selected; } set { convenio_id_selected = value; } }

        public ConveniosTarifas()
        {
            InitializeComponent();
        }

        //public ConveniosTarifas(MySQLConnector.MySQLConnector connector)
        //{
        //    // TODO: Complete member initialization
        //    InitializeComponent();
        //    this.connector = connector;
        //}

        private void ConveniosTarifas_Load(object sender, EventArgs e)
        {
            //TODO Load all convenios 
            int counter = 1;
            int rdr_count = Convert.ToInt32(Globals.connector.getEscalar("SELECT COUNT(*) FROM convenio"));
            MySqlDataReader rdr = Globals.connector.getReader("SELECT nombre FROM convenio");
            convenio_radio_button = new ArrayList();
            while (rdr.Read() && rdr!=null)
            {
                RadioButton radio_button_tmp = new RadioButton();
                radio_button_tmp.Text = Convert.ToString(rdr[0]);
                radio_button_tmp.Size = new System.Drawing.Size(200, 17);
                if (counter == convenio_id_selected)
                {
                    radio_button_tmp.Checked = true;
                }
                convenio_radio_button.Add(radio_button_tmp);
                counter++;
            }
            rdr.Close();
            flow_container.FlowDirection = FlowDirection.TopDown;
            for (int i = 0; i < convenio_radio_button.Count; i++)
            {
                flow_container.Controls.Add((RadioButton)convenio_radio_button[i]);
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < convenio_radio_button.Count; i++)
            {
                RadioButton rb = (RadioButton)convenio_radio_button[i];
                if (rb.Checked)
                {
                    convenio_id_selected = i + 1;
                    break;
                }
            }
            this.Close();
        }

        private static DialogResult ShowCore(IWin32Window owner, string text, string defaultValue, string caption, out string result)
        {
            result = convenio_id_selected.ToString();
            return DialogResult.OK;
        }
    }
}

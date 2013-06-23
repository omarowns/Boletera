using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boletera
{
    public partial class Form_newUsercs : Form
    {
        //Bandera para saber si hay algún valor vacío
        private bool dataIsCorrect;

        public Form_newUsercs()
        {
            dataIsCorrect = false;
            InitializeComponent();
        }

        private void textBox_Password2_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Password2.Text != textBox_Password1.Text)
            {
                label_PassEquals.Text = "LAS CONTRASEÑAS NO COINCIDEN";
                label_PassEquals.ForeColor = System.Drawing.Color.Red;
                dataIsCorrect = false;
            }
            else
            {
                label_PassEquals.Text = "LAS CONTRASEÑAS COINCIDEN";
                label_PassEquals.ForeColor = System.Drawing.Color.Green;
                dataIsCorrect = true;
            }
        }

        private void cmd_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cmd_Aceptar_Click(object sender, EventArgs e)
        {
            //Verificamos que no estén en nulo los valores de los campos
            foreach (var comboBox in this.Controls.OfType<ComboBox>())
            {
                if (comboBox.Text.Length < 1)
                {
                    dataIsCorrect = false;
                }
            }
            foreach (var textBox in this.Controls.OfType<TextBox>())
            {
                if (textBox.Text.Length < 1)
                {
                    dataIsCorrect = false;
                }
            }
            if (dataIsCorrect)
            {
                new Usuario(textBox_Nombre.Text, comboBox_Turno.Text, comboBox_Rol.Text, textBox_Password1.Text).addToDB();
                MessageBox.Show("Se ha dado de alta el usuario " + textBox_Nombre.Text + " correctamente");
                this.Dispose();
            }
            else
            {
                MessageBox.Show("No se ha podido crear el nuevo usuario, ingrese todos los datos correctos", "Nuevo usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}

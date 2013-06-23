/*
 * Created by SharpDevelop.
 * User: Alejandro
 * Date: 08/06/2013
 * Time: 12:23 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Boletera
{
	/// <summary>
	/// Description of Forma_admin.
	/// </summary>
	public partial class admin : Form
	{
		public admin()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void Btn_salirClick(object sender, EventArgs e)
		{
			Dispose();
			//Aqui va la clase del talento de la
			//interfaz del login
		}
		
		void Btn_usrClick(object sender, EventArgs e)
		{
            Form_adminUsers admUsr = new Form_adminUsers();
            this.Hide();
            admUsr.ShowDialog(this);
            this.Show();
		}
		
		void Btn_tarClick(object sender, EventArgs e)
		{
			admin_tarifas at = new admin_tarifas();
			at.ShowDialog(this);
		}
		
		void Btn_cnvClick(object sender, EventArgs e)
		{
			admin_convenios ac = new admin_convenios();
			ac.ShowDialog(this);
		}
	}
}

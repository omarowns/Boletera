/*
 * Created by SharpDevelop.
 * User: Alejandro
 * Date: 08/06/2013
 * Time: 12:23 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Boletera
{
	partial class admin
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            this.Administrar = new System.Windows.Forms.GroupBox();
            this.btn_cnv = new System.Windows.Forms.Button();
            this.btn_tar = new System.Windows.Forms.Button();
            this.btn_usr = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Administrar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Administrar
            // 
            this.Administrar.Controls.Add(this.btn_cnv);
            this.Administrar.Controls.Add(this.btn_tar);
            this.Administrar.Controls.Add(this.btn_usr);
            this.Administrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Administrar.Location = new System.Drawing.Point(12, 91);
            this.Administrar.Name = "Administrar";
            this.Administrar.Size = new System.Drawing.Size(334, 189);
            this.Administrar.TabIndex = 0;
            this.Administrar.TabStop = false;
            this.Administrar.Text = "Administrar";
            // 
            // btn_cnv
            // 
            this.btn_cnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cnv.Location = new System.Drawing.Point(104, 130);
            this.btn_cnv.Name = "btn_cnv";
            this.btn_cnv.Size = new System.Drawing.Size(117, 45);
            this.btn_cnv.TabIndex = 2;
            this.btn_cnv.Text = "Convenios";
            this.btn_cnv.UseVisualStyleBackColor = true;
            this.btn_cnv.Click += new System.EventHandler(this.Btn_cnvClick);
            // 
            // btn_tar
            // 
            this.btn_tar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tar.Location = new System.Drawing.Point(104, 79);
            this.btn_tar.Name = "btn_tar";
            this.btn_tar.Size = new System.Drawing.Size(117, 45);
            this.btn_tar.TabIndex = 1;
            this.btn_tar.Text = "Tarifas";
            this.btn_tar.UseVisualStyleBackColor = true;
            this.btn_tar.Click += new System.EventHandler(this.Btn_tarClick);
            // 
            // btn_usr
            // 
            this.btn_usr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_usr.Location = new System.Drawing.Point(104, 28);
            this.btn_usr.Name = "btn_usr";
            this.btn_usr.Size = new System.Drawing.Size(117, 45);
            this.btn_usr.TabIndex = 0;
            this.btn_usr.Text = "Usuarios";
            this.btn_usr.UseVisualStyleBackColor = true;
            this.btn_usr.Click += new System.EventHandler(this.Btn_usrClick);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.Location = new System.Drawing.Point(230, 311);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(117, 45);
            this.btn_salir.TabIndex = 2;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.Btn_salirClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(368, 72);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(97, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administración";
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 378);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.Administrar);
            this.Name = "admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administrador";
            this.Administrar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

		}
        private System.Windows.Forms.Button btn_salir;
		private System.Windows.Forms.Button btn_usr;
		private System.Windows.Forms.Button btn_tar;
		private System.Windows.Forms.Button btn_cnv;
		private System.Windows.Forms.GroupBox Administrar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
	}
}

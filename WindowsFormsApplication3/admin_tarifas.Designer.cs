/*
 * Created by SharpDevelop.
 * User: Alejandro
 * Date: 09/06/2013
 * Time: 03:30 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Boletera
{
	partial class admin_tarifas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabla_tar = new System.Windows.Forms.DataGridView();
            this.btn_salir = new System.Windows.Forms.Button();
            this.Actualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_tar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabla_tar
            // 
            this.tabla_tar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tabla_tar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tabla_tar.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_tar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabla_tar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.NullValue = "-";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla_tar.DefaultCellStyle = dataGridViewCellStyle2;
            this.tabla_tar.Location = new System.Drawing.Point(12, 12);
            this.tabla_tar.Name = "tabla_tar";
            this.tabla_tar.Size = new System.Drawing.Size(755, 301);
            this.tabla_tar.TabIndex = 0;
            this.tabla_tar.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tabla_tarRowValidated);
            // 
            // btn_salir
            // 
            this.btn_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.Black;
            this.btn_salir.Location = new System.Drawing.Point(665, 319);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(102, 42);
            this.btn_salir.TabIndex = 8;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.Btn_salirClick);
            // 
            // Actualizar
            // 
            this.Actualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Actualizar.ForeColor = System.Drawing.Color.Black;
            this.Actualizar.Location = new System.Drawing.Point(535, 319);
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Size = new System.Drawing.Size(102, 42);
            this.Actualizar.TabIndex = 9;
            this.Actualizar.Text = "Actualizar";
            this.Actualizar.UseVisualStyleBackColor = true;
            this.Actualizar.Click += new System.EventHandler(this.ActualizarClick);
            // 
            // admin_tarifas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 373);
            this.Controls.Add(this.Actualizar);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.tabla_tar);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.Name = "admin_tarifas";
            this.Text = "Administración de tarifas";
            ((System.ComponentModel.ISupportInitialize)(this.tabla_tar)).EndInit();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button Actualizar;
		private System.Windows.Forms.Button btn_salir;
		private System.Windows.Forms.DataGridView tabla_tar;
	}
}

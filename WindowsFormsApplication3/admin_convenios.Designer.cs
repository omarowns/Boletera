/*
 * Created by SharpDevelop.
 * User: Alejandro
 * Date: 22/06/2013
 * Time: 06:56 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Boletera
{
	partial class admin_convenios
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
            this.tabla_cnv = new System.Windows.Forms.DataGridView();
            this.salir_cnv = new System.Windows.Forms.Button();
            this.act_cnv = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_cnv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabla_cnv
            // 
            this.tabla_cnv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tabla_cnv.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tabla_cnv.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.NullValue = "-";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_cnv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.tabla_cnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tabla_cnv.DefaultCellStyle = dataGridViewCellStyle2;
            this.tabla_cnv.Location = new System.Drawing.Point(13, 49);
            this.tabla_cnv.Name = "tabla_cnv";
            this.tabla_cnv.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tabla_cnv.Size = new System.Drawing.Size(585, 209);
            this.tabla_cnv.TabIndex = 0;
            this.tabla_cnv.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.Tabla_cnvRowValidated);
            // 
            // salir_cnv
            // 
            this.salir_cnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir_cnv.Location = new System.Drawing.Point(496, 283);
            this.salir_cnv.Name = "salir_cnv";
            this.salir_cnv.Size = new System.Drawing.Size(102, 42);
            this.salir_cnv.TabIndex = 1;
            this.salir_cnv.Text = "Salir";
            this.salir_cnv.UseVisualStyleBackColor = true;
            this.salir_cnv.Click += new System.EventHandler(this.Salir_cnvClick);
            // 
            // act_cnv
            // 
            this.act_cnv.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.act_cnv.Location = new System.Drawing.Point(375, 283);
            this.act_cnv.Name = "act_cnv";
            this.act_cnv.Size = new System.Drawing.Size(102, 42);
            this.act_cnv.TabIndex = 2;
            this.act_cnv.Text = "Actualizar";
            this.act_cnv.UseVisualStyleBackColor = true;
            this.act_cnv.Click += new System.EventHandler(this.Act_cnvClick);
            // 
            // admin_convenios
            // 
            this.AcceptButton = this.act_cnv;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(610, 337);
            this.Controls.Add(this.act_cnv);
            this.Controls.Add(this.salir_cnv);
            this.Controls.Add(this.tabla_cnv);
            this.Name = "admin_convenios";
            this.Text = "Administración de convenios";
            ((System.ComponentModel.ISupportInitialize)(this.tabla_cnv)).EndInit();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button act_cnv;
		private System.Windows.Forms.Button salir_cnv;
		private System.Windows.Forms.DataGridView tabla_cnv;
	}
}

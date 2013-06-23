namespace Boletera
{
    partial class Form_adminUsers
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.usuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox_Commands = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox_Rol = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Turno = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox_UsuarioCambio = new System.Windows.Forms.ComboBox();
            this.comboBox_BajaUsuario = new System.Windows.Forms.ComboBox();
            this.cmd_NuevoUsuario = new System.Windows.Forms.Button();
            this.cmd_Exit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).BeginInit();
            this.groupBox_Commands.SuspendLayout();
            this.SuspendLayout();
            // 
            // usuarioDataGridView
            // 
            this.usuarioDataGridView.AllowUserToAddRows = false;
            this.usuarioDataGridView.AllowUserToDeleteRows = false;
            this.usuarioDataGridView.AllowUserToOrderColumns = true;
            this.usuarioDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.usuarioDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.usuarioDataGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usuarioDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.usuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.NullValue = "-";
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usuarioDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.usuarioDataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.usuarioDataGridView.Location = new System.Drawing.Point(12, 12);
            this.usuarioDataGridView.Name = "usuarioDataGridView";
            this.usuarioDataGridView.ReadOnly = true;
            this.usuarioDataGridView.Size = new System.Drawing.Size(547, 403);
            this.usuarioDataGridView.TabIndex = 0;
            // 
            // groupBox_Commands
            // 
            this.groupBox_Commands.Controls.Add(this.label4);
            this.groupBox_Commands.Controls.Add(this.comboBox_Rol);
            this.groupBox_Commands.Controls.Add(this.label2);
            this.groupBox_Commands.Controls.Add(this.comboBox_Turno);
            this.groupBox_Commands.Controls.Add(this.label3);
            this.groupBox_Commands.Controls.Add(this.label1);
            this.groupBox_Commands.Controls.Add(this.comboBox_UsuarioCambio);
            this.groupBox_Commands.Controls.Add(this.comboBox_BajaUsuario);
            this.groupBox_Commands.Controls.Add(this.cmd_NuevoUsuario);
            this.groupBox_Commands.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_Commands.Location = new System.Drawing.Point(579, 12);
            this.groupBox_Commands.Name = "groupBox_Commands";
            this.groupBox_Commands.Size = new System.Drawing.Size(328, 358);
            this.groupBox_Commands.TabIndex = 1;
            this.groupBox_Commands.TabStop = false;
            this.groupBox_Commands.Text = "Manejo de usuarios";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 278);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cambiar rol:";
            // 
            // comboBox_Rol
            // 
            this.comboBox_Rol.DisplayMember = "id";
            this.comboBox_Rol.FormattingEnabled = true;
            this.comboBox_Rol.Location = new System.Drawing.Point(12, 306);
            this.comboBox_Rol.Name = "comboBox_Rol";
            this.comboBox_Rol.Size = new System.Drawing.Size(297, 28);
            this.comboBox_Rol.TabIndex = 10;
            this.comboBox_Rol.ValueMember = "id";
            this.comboBox_Rol.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Rol_SelectionChangeCommitted);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cambiar turno:";
            // 
            // comboBox_Turno
            // 
            this.comboBox_Turno.DisplayMember = "id";
            this.comboBox_Turno.FormattingEnabled = true;
            this.comboBox_Turno.Location = new System.Drawing.Point(12, 242);
            this.comboBox_Turno.Name = "comboBox_Turno";
            this.comboBox_Turno.Size = new System.Drawing.Size(297, 28);
            this.comboBox_Turno.TabIndex = 8;
            this.comboBox_Turno.ValueMember = "id";
            this.comboBox_Turno.SelectionChangeCommitted += new System.EventHandler(this.comboBox_Turno_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(272, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cambiar la contraseña de un usuario:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dar de baja un usuario:";
            // 
            // comboBox_UsuarioCambio
            // 
            this.comboBox_UsuarioCambio.DisplayMember = "id";
            this.comboBox_UsuarioCambio.FormattingEnabled = true;
            this.comboBox_UsuarioCambio.Location = new System.Drawing.Point(12, 178);
            this.comboBox_UsuarioCambio.Name = "comboBox_UsuarioCambio";
            this.comboBox_UsuarioCambio.Size = new System.Drawing.Size(297, 28);
            this.comboBox_UsuarioCambio.TabIndex = 2;
            this.comboBox_UsuarioCambio.ValueMember = "id";
            this.comboBox_UsuarioCambio.SelectionChangeCommitted += new System.EventHandler(this.comboBox_UsuarioCambio_SelectionChangeCommitted);
            // 
            // comboBox_BajaUsuario
            // 
            this.comboBox_BajaUsuario.DisplayMember = "id";
            this.comboBox_BajaUsuario.FormattingEnabled = true;
            this.comboBox_BajaUsuario.Location = new System.Drawing.Point(12, 114);
            this.comboBox_BajaUsuario.Name = "comboBox_BajaUsuario";
            this.comboBox_BajaUsuario.Size = new System.Drawing.Size(297, 28);
            this.comboBox_BajaUsuario.TabIndex = 1;
            this.comboBox_BajaUsuario.ValueMember = "id";
            this.comboBox_BajaUsuario.SelectionChangeCommitted += new System.EventHandler(this.comboBox_BajaUsuario_SelectionChangeCommitted);
            // 
            // cmd_NuevoUsuario
            // 
            this.cmd_NuevoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_NuevoUsuario.Location = new System.Drawing.Point(12, 25);
            this.cmd_NuevoUsuario.Name = "cmd_NuevoUsuario";
            this.cmd_NuevoUsuario.Size = new System.Drawing.Size(182, 41);
            this.cmd_NuevoUsuario.TabIndex = 0;
            this.cmd_NuevoUsuario.Text = "Nuevo usuario";
            this.cmd_NuevoUsuario.UseVisualStyleBackColor = true;
            this.cmd_NuevoUsuario.Click += new System.EventHandler(this.cmd_NuevoUsuario_Click);
            // 
            // cmd_Exit
            // 
            this.cmd_Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmd_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmd_Exit.Location = new System.Drawing.Point(781, 385);
            this.cmd_Exit.Name = "cmd_Exit";
            this.cmd_Exit.Size = new System.Drawing.Size(126, 45);
            this.cmd_Exit.TabIndex = 4;
            this.cmd_Exit.Text = "Salir";
            this.cmd_Exit.UseVisualStyleBackColor = true;
            this.cmd_Exit.Click += new System.EventHandler(this.cmd_Exit_Click);
            // 
            // Form_adminUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.cmd_Exit;
            this.ClientSize = new System.Drawing.Size(929, 442);
            this.Controls.Add(this.cmd_Exit);
            this.Controls.Add(this.groupBox_Commands);
            this.Controls.Add(this.usuarioDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_adminUsers";
            this.Text = "Administración de usuarios";
            this.Load += new System.EventHandler(this.Form_adminUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).EndInit();
            this.groupBox_Commands.ResumeLayout(false);
            this.groupBox_Commands.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView usuarioDataGridView;
        private System.Windows.Forms.GroupBox groupBox_Commands;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox_UsuarioCambio;
        private System.Windows.Forms.ComboBox comboBox_BajaUsuario;
        private System.Windows.Forms.Button cmd_NuevoUsuario;
        private System.Windows.Forms.Button cmd_Exit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox_Rol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Turno;

    }
}


namespace Boletera
{
    partial class Form_newUsercs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmd_Aceptar = new System.Windows.Forms.Button();
            this.cmd_Cancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Turno = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Rol = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Password2 = new System.Windows.Forms.TextBox();
            this.textBox_Password1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_PassEquals = new System.Windows.Forms.Label();
            this.textBox_Nombre = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmd_Aceptar
            // 
            this.cmd_Aceptar.Location = new System.Drawing.Point(215, 263);
            this.cmd_Aceptar.Name = "cmd_Aceptar";
            this.cmd_Aceptar.Size = new System.Drawing.Size(89, 32);
            this.cmd_Aceptar.TabIndex = 5;
            this.cmd_Aceptar.Text = "&Aceptar";
            this.cmd_Aceptar.UseVisualStyleBackColor = true;
            this.cmd_Aceptar.Click += new System.EventHandler(this.cmd_Aceptar_Click);
            // 
            // cmd_Cancelar
            // 
            this.cmd_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmd_Cancelar.Location = new System.Drawing.Point(310, 263);
            this.cmd_Cancelar.Name = "cmd_Cancelar";
            this.cmd_Cancelar.Size = new System.Drawing.Size(89, 32);
            this.cmd_Cancelar.TabIndex = 6;
            this.cmd_Cancelar.Text = "&Cancelar";
            this.cmd_Cancelar.UseVisualStyleBackColor = true;
            this.cmd_Cancelar.Click += new System.EventHandler(this.cmd_Cancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Turno:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_Turno
            // 
            this.comboBox_Turno.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_Turno.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Turno.FormattingEnabled = true;
            this.comboBox_Turno.Items.AddRange(new object[] {
            "Matutino",
            "Vespertino",
            "Nocturno",
            "Tiempo completo"});
            this.comboBox_Turno.Location = new System.Drawing.Point(91, 78);
            this.comboBox_Turno.Name = "comboBox_Turno";
            this.comboBox_Turno.Size = new System.Drawing.Size(177, 21);
            this.comboBox_Turno.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Rol:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox_Rol
            // 
            this.comboBox_Rol.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox_Rol.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_Rol.FormattingEnabled = true;
            this.comboBox_Rol.Items.AddRange(new object[] {
            "Cajero/Recepcionista",
            "Supervisor",
            "Auxiliar"});
            this.comboBox_Rol.Location = new System.Drawing.Point(91, 105);
            this.comboBox_Rol.Name = "comboBox_Rol";
            this.comboBox_Rol.Size = new System.Drawing.Size(177, 21);
            this.comboBox_Rol.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ingrese los datos del nuevo usuario:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Contraseña:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 46);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Repita la contraseña:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_Password2
            // 
            this.textBox_Password2.Location = new System.Drawing.Point(143, 46);
            this.textBox_Password2.Name = "textBox_Password2";
            this.textBox_Password2.Size = new System.Drawing.Size(211, 20);
            this.textBox_Password2.TabIndex = 5;
            this.textBox_Password2.UseSystemPasswordChar = true;
            this.textBox_Password2.TextChanged += new System.EventHandler(this.textBox_Password2_TextChanged);
            // 
            // textBox_Password1
            // 
            this.textBox_Password1.Location = new System.Drawing.Point(143, 20);
            this.textBox_Password1.Name = "textBox_Password1";
            this.textBox_Password1.Size = new System.Drawing.Size(211, 20);
            this.textBox_Password1.TabIndex = 4;
            this.textBox_Password1.UseSystemPasswordChar = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_PassEquals);
            this.panel1.Controls.Add(this.textBox_Password2);
            this.panel1.Controls.Add(this.textBox_Password1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(16, 144);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(382, 104);
            this.panel1.TabIndex = 4;
            // 
            // label_PassEquals
            // 
            this.label_PassEquals.AutoSize = true;
            this.label_PassEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_PassEquals.Location = new System.Drawing.Point(25, 73);
            this.label_PassEquals.Name = "label_PassEquals";
            this.label_PassEquals.Size = new System.Drawing.Size(11, 13);
            this.label_PassEquals.TabIndex = 14;
            this.label_PassEquals.Text = " ";
            // 
            // textBox_Nombre
            // 
            this.textBox_Nombre.Location = new System.Drawing.Point(91, 51);
            this.textBox_Nombre.Name = "textBox_Nombre";
            this.textBox_Nombre.Size = new System.Drawing.Size(177, 20);
            this.textBox_Nombre.TabIndex = 1;
            // 
            // Form_newUsercs
            // 
            this.AcceptButton = this.cmd_Aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmd_Cancelar;
            this.ClientSize = new System.Drawing.Size(411, 307);
            this.ControlBox = false;
            this.Controls.Add(this.textBox_Nombre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmd_Cancelar);
            this.Controls.Add(this.comboBox_Rol);
            this.Controls.Add(this.cmd_Aceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox_Turno);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form_newUsercs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo usuario";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmd_Aceptar;
        private System.Windows.Forms.Button cmd_Cancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Turno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_Rol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Password2;
        private System.Windows.Forms.TextBox textBox_Password1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_PassEquals;
        private System.Windows.Forms.TextBox textBox_Nombre;
    }
}
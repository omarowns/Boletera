namespace Boletera
{
    partial class CobroEmision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CobroEmision));
            this.emisionBox = new System.Windows.Forms.GroupBox();
            this.tarifaFija = new System.Windows.Forms.RadioButton();
            this.tarifaPorHora = new System.Windows.Forms.RadioButton();
            this.boletosEmitidos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.emitirBoleto = new System.Windows.Forms.Button();
            this.cobroBox = new System.Windows.Forms.GroupBox();
            this.tarifaSeleccionada = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.importeTotal = new System.Windows.Forms.Label();
            this.tiempoTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputBoleto = new System.Windows.Forms.TextBox();
            this.cobrarBoleto = new System.Windows.Forms.Button();
            this.fechaLabel = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.closesession = new System.Windows.Forms.Button();
            this.emisionBox.SuspendLayout();
            this.cobroBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // emisionBox
            // 
            this.emisionBox.Controls.Add(this.tarifaFija);
            this.emisionBox.Controls.Add(this.tarifaPorHora);
            this.emisionBox.Controls.Add(this.boletosEmitidos);
            this.emisionBox.Controls.Add(this.label1);
            this.emisionBox.Controls.Add(this.emitirBoleto);
            this.emisionBox.Location = new System.Drawing.Point(13, 13);
            this.emisionBox.Name = "emisionBox";
            this.emisionBox.Size = new System.Drawing.Size(599, 150);
            this.emisionBox.TabIndex = 0;
            this.emisionBox.TabStop = false;
            this.emisionBox.Text = "Emision";
            // 
            // tarifaFija
            // 
            this.tarifaFija.AutoSize = true;
            this.tarifaFija.Location = new System.Drawing.Point(7, 56);
            this.tarifaFija.Name = "tarifaFija";
            this.tarifaFija.Size = new System.Drawing.Size(71, 17);
            this.tarifaFija.TabIndex = 4;
            this.tarifaFija.TabStop = true;
            this.tarifaFija.Text = "Tarifa Fija";
            this.tarifaFija.UseVisualStyleBackColor = true;
            // 
            // tarifaPorHora
            // 
            this.tarifaPorHora.AutoSize = true;
            this.tarifaPorHora.Checked = true;
            this.tarifaPorHora.Location = new System.Drawing.Point(7, 32);
            this.tarifaPorHora.Name = "tarifaPorHora";
            this.tarifaPorHora.Size = new System.Drawing.Size(97, 17);
            this.tarifaPorHora.TabIndex = 3;
            this.tarifaPorHora.TabStop = true;
            this.tarifaPorHora.Text = "Tarifa Por Hora";
            this.tarifaPorHora.UseVisualStyleBackColor = true;
            // 
            // boletosEmitidos
            // 
            this.boletosEmitidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boletosEmitidos.Location = new System.Drawing.Point(317, 91);
            this.boletosEmitidos.Name = "boletosEmitidos";
            this.boletosEmitidos.ReadOnly = true;
            this.boletosEmitidos.Size = new System.Drawing.Size(163, 26);
            this.boletosEmitidos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Boletos Emitidos: ";
            // 
            // emitirBoleto
            // 
            this.emitirBoleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emitirBoleto.Location = new System.Drawing.Point(220, 19);
            this.emitirBoleto.Name = "emitirBoleto";
            this.emitirBoleto.Size = new System.Drawing.Size(200, 43);
            this.emitirBoleto.TabIndex = 0;
            this.emitirBoleto.Text = "Emitir Boleto";
            this.emitirBoleto.UseVisualStyleBackColor = true;
            this.emitirBoleto.Click += new System.EventHandler(this.emitirBoleto_Click);
            // 
            // cobroBox
            // 
            this.cobroBox.Controls.Add(this.tarifaSeleccionada);
            this.cobroBox.Controls.Add(this.label4);
            this.cobroBox.Controls.Add(this.importeTotal);
            this.cobroBox.Controls.Add(this.tiempoTotal);
            this.cobroBox.Controls.Add(this.label3);
            this.cobroBox.Controls.Add(this.label2);
            this.cobroBox.Controls.Add(this.inputBoleto);
            this.cobroBox.Controls.Add(this.cobrarBoleto);
            this.cobroBox.Location = new System.Drawing.Point(12, 169);
            this.cobroBox.Name = "cobroBox";
            this.cobroBox.Size = new System.Drawing.Size(599, 150);
            this.cobroBox.TabIndex = 1;
            this.cobroBox.TabStop = false;
            this.cobroBox.Text = "Cobro";
            // 
            // tarifaSeleccionada
            // 
            this.tarifaSeleccionada.AutoSize = true;
            this.tarifaSeleccionada.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tarifaSeleccionada.Location = new System.Drawing.Point(466, 131);
            this.tarifaSeleccionada.Name = "tarifaSeleccionada";
            this.tarifaSeleccionada.Size = new System.Drawing.Size(40, 13);
            this.tarifaSeleccionada.TabIndex = 7;
            this.tarifaSeleccionada.Text = "Tarifa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tarifa Seleccionada:";
            // 
            // importeTotal
            // 
            this.importeTotal.AutoSize = true;
            this.importeTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importeTotal.ForeColor = System.Drawing.Color.Red;
            this.importeTotal.Location = new System.Drawing.Point(408, 99);
            this.importeTotal.Name = "importeTotal";
            this.importeTotal.Size = new System.Drawing.Size(52, 16);
            this.importeTotal.TabIndex = 5;
            this.importeTotal.Text = "$00.00";
            // 
            // tiempoTotal
            // 
            this.tiempoTotal.AutoSize = true;
            this.tiempoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tiempoTotal.ForeColor = System.Drawing.Color.Red;
            this.tiempoTotal.Location = new System.Drawing.Point(408, 62);
            this.tiempoTotal.Name = "tiempoTotal";
            this.tiempoTotal.Size = new System.Drawing.Size(44, 16);
            this.tiempoTotal.TabIndex = 4;
            this.tiempoTotal.Text = "00:00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(316, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Importe Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(317, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tiempo Total:";
            // 
            // inputBoleto
            // 
            this.inputBoleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputBoleto.Location = new System.Drawing.Point(180, 19);
            this.inputBoleto.Name = "inputBoleto";
            this.inputBoleto.Size = new System.Drawing.Size(280, 29);
            this.inputBoleto.TabIndex = 1;
            // 
            // cobrarBoleto
            // 
            this.cobrarBoleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cobrarBoleto.Location = new System.Drawing.Point(180, 69);
            this.cobrarBoleto.Name = "cobrarBoleto";
            this.cobrarBoleto.Size = new System.Drawing.Size(114, 43);
            this.cobrarBoleto.TabIndex = 0;
            this.cobrarBoleto.Text = "Cobrar";
            this.cobrarBoleto.UseVisualStyleBackColor = true;
            this.cobrarBoleto.Click += new System.EventHandler(this.cobrarBoleto_Click);
            // 
            // fechaLabel
            // 
            this.fechaLabel.AutoSize = true;
            this.fechaLabel.Location = new System.Drawing.Point(12, 340);
            this.fechaLabel.Name = "fechaLabel";
            this.fechaLabel.Size = new System.Drawing.Size(0, 13);
            this.fechaLabel.TabIndex = 2;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(508, 338);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(104, 15);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Convenios/Tarifas";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // closesession
            // 
            this.closesession.Location = new System.Drawing.Point(275, 335);
            this.closesession.Name = "closesession";
            this.closesession.Size = new System.Drawing.Size(110, 34);
            this.closesession.TabIndex = 4;
            this.closesession.Text = "Cerrar Sesión";
            this.closesession.UseVisualStyleBackColor = true;
            this.closesession.Click += new System.EventHandler(this.closesession_Click);
            // 
            // CobroEmision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 391);
            this.Controls.Add(this.closesession);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.fechaLabel);
            this.Controls.Add(this.cobroBox);
            this.Controls.Add(this.emisionBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CobroEmision";
            this.Text = "Cobro y emisión de boletos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CobroEmision_FormClosed);
            this.Load += new System.EventHandler(this.CobroEmision_Load);
            this.emisionBox.ResumeLayout(false);
            this.emisionBox.PerformLayout();
            this.cobroBox.ResumeLayout(false);
            this.cobroBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox emisionBox;
        private System.Windows.Forms.GroupBox cobroBox;
        private System.Windows.Forms.Label fechaLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button emitirBoleto;
        private System.Windows.Forms.Button cobrarBoleto;
        private System.Windows.Forms.TextBox boletosEmitidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputBoleto;
        private System.Windows.Forms.Label importeTotal;
        private System.Windows.Forms.Label tiempoTotal;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label tarifaSeleccionada;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton tarifaFija;
        private System.Windows.Forms.RadioButton tarifaPorHora;
        private System.Windows.Forms.Button closesession;
    }
}
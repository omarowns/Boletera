namespace Boletera
{
    partial class ConveniosTarifas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.saveandexit = new System.Windows.Forms.Button();
            this.flow_container = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flow_container);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(253, 237);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Convenios y Tarifas";
            // 
            // saveandexit
            // 
            this.saveandexit.Location = new System.Drawing.Point(168, 255);
            this.saveandexit.Name = "saveandexit";
            this.saveandexit.Size = new System.Drawing.Size(92, 23);
            this.saveandexit.TabIndex = 1;
            this.saveandexit.Text = "Guardar";
            this.saveandexit.UseVisualStyleBackColor = true;
            this.saveandexit.Click += new System.EventHandler(this.button1_Click);
            // 
            // flow_container
            // 
            this.flow_container.AutoScroll = true;
            this.flow_container.Location = new System.Drawing.Point(7, 20);
            this.flow_container.Name = "flow_container";
            this.flow_container.Size = new System.Drawing.Size(240, 211);
            this.flow_container.TabIndex = 0;
            // 
            // ConveniosTarifas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 290);
            this.Controls.Add(this.saveandexit);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConveniosTarifas";
            this.Text = "ConveniosTarifas";
            this.Load += new System.EventHandler(this.ConveniosTarifas_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button saveandexit;
        private System.Windows.Forms.FlowLayoutPanel flow_container;
    }
}
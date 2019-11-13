namespace AppFunciones2
{
    partial class Cilindro_Ar_Vo
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
            this.btmcalcular = new System.Windows.Forms.Button();
            this.btminicio = new System.Windows.Forms.Button();
            this.btmsalir = new System.Windows.Forms.Button();
            this.txtradio = new System.Windows.Forms.TextBox();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtarea = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtvolumen = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btmcalcular
            // 
            this.btmcalcular.Location = new System.Drawing.Point(462, 43);
            this.btmcalcular.Name = "btmcalcular";
            this.btmcalcular.Size = new System.Drawing.Size(112, 34);
            this.btmcalcular.TabIndex = 0;
            this.btmcalcular.Text = "Calcular";
            this.btmcalcular.UseVisualStyleBackColor = true;
            this.btmcalcular.Click += new System.EventHandler(this.btmcalcular_Click);
            // 
            // btminicio
            // 
            this.btminicio.Location = new System.Drawing.Point(462, 95);
            this.btminicio.Name = "btminicio";
            this.btminicio.Size = new System.Drawing.Size(112, 34);
            this.btminicio.TabIndex = 1;
            this.btminicio.Text = "Nuevo";
            this.btminicio.UseVisualStyleBackColor = true;
            this.btminicio.Click += new System.EventHandler(this.btminicio_Click);
            // 
            // btmsalir
            // 
            this.btmsalir.Location = new System.Drawing.Point(462, 189);
            this.btmsalir.Name = "btmsalir";
            this.btmsalir.Size = new System.Drawing.Size(112, 34);
            this.btmsalir.TabIndex = 2;
            this.btmsalir.Text = "Salir";
            this.btmsalir.UseVisualStyleBackColor = true;
            this.btmsalir.Click += new System.EventHandler(this.btmsalir_Click);
            // 
            // txtradio
            // 
            this.txtradio.Location = new System.Drawing.Point(194, 43);
            this.txtradio.Name = "txtradio";
            this.txtradio.Size = new System.Drawing.Size(161, 20);
            this.txtradio.TabIndex = 3;
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(194, 78);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(161, 20);
            this.txtaltura.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 161);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Área de un cilindro";
            // 
            // txtarea
            // 
            this.txtarea.Location = new System.Drawing.Point(194, 161);
            this.txtarea.Name = "txtarea";
            this.txtarea.Size = new System.Drawing.Size(161, 20);
            this.txtarea.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Ingrese el Radio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Ingrese la Altura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Volumen de un cilindro";
            // 
            // txtvolumen
            // 
            this.txtvolumen.Location = new System.Drawing.Point(194, 197);
            this.txtvolumen.Name = "txtvolumen";
            this.txtvolumen.Size = new System.Drawing.Size(161, 20);
            this.txtvolumen.TabIndex = 12;
            // 
            // Cilindro_Ar_Vo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtvolumen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtarea);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.txtradio);
            this.Controls.Add(this.btmsalir);
            this.Controls.Add(this.btminicio);
            this.Controls.Add(this.btmcalcular);
            this.Name = "Cilindro_Ar_Vo";
            this.Text = "Área y volumen de un cilindro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmcalcular;
        private System.Windows.Forms.Button btminicio;
        private System.Windows.Forms.Button btmsalir;
        private System.Windows.Forms.TextBox txtradio;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtarea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtvolumen;
    }
}
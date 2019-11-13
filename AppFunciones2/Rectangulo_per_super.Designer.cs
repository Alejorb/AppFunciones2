namespace AppFunciones2
{
    partial class Rectangulo_per_super
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
            this.btmsalir = new System.Windows.Forms.Button();
            this.btmnuevo = new System.Windows.Forms.Button();
            this.btmcalcular = new System.Windows.Forms.Button();
            this.txtsuperficie = new System.Windows.Forms.TextBox();
            this.txtperimetro = new System.Windows.Forms.TextBox();
            this.txtbase = new System.Windows.Forms.TextBox();
            this.txtaltura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btmsalir
            // 
            this.btmsalir.Location = new System.Drawing.Point(486, 219);
            this.btmsalir.Name = "btmsalir";
            this.btmsalir.Size = new System.Drawing.Size(118, 39);
            this.btmsalir.TabIndex = 5;
            this.btmsalir.Text = "Salir";
            this.btmsalir.UseVisualStyleBackColor = true;
            this.btmsalir.Click += new System.EventHandler(this.btmsalir_Click);
            // 
            // btmnuevo
            // 
            this.btmnuevo.Location = new System.Drawing.Point(486, 121);
            this.btmnuevo.Name = "btmnuevo";
            this.btmnuevo.Size = new System.Drawing.Size(118, 39);
            this.btmnuevo.TabIndex = 4;
            this.btmnuevo.Text = "Nuevo";
            this.btmnuevo.UseVisualStyleBackColor = true;
            this.btmnuevo.Click += new System.EventHandler(this.btmnuevo_Click);
            // 
            // btmcalcular
            // 
            this.btmcalcular.Location = new System.Drawing.Point(486, 63);
            this.btmcalcular.Name = "btmcalcular";
            this.btmcalcular.Size = new System.Drawing.Size(118, 39);
            this.btmcalcular.TabIndex = 3;
            this.btmcalcular.Text = "Calcular";
            this.btmcalcular.UseVisualStyleBackColor = true;
            this.btmcalcular.Click += new System.EventHandler(this.btmcalcular_Click);
            // 
            // txtsuperficie
            // 
            this.txtsuperficie.Location = new System.Drawing.Point(228, 241);
            this.txtsuperficie.Name = "txtsuperficie";
            this.txtsuperficie.Size = new System.Drawing.Size(135, 20);
            this.txtsuperficie.TabIndex = 8;
            // 
            // txtperimetro
            // 
            this.txtperimetro.Location = new System.Drawing.Point(228, 199);
            this.txtperimetro.Name = "txtperimetro";
            this.txtperimetro.Size = new System.Drawing.Size(135, 20);
            this.txtperimetro.TabIndex = 7;
            // 
            // txtbase
            // 
            this.txtbase.Location = new System.Drawing.Point(228, 63);
            this.txtbase.Name = "txtbase";
            this.txtbase.Size = new System.Drawing.Size(135, 20);
            this.txtbase.TabIndex = 6;
            // 
            // txtaltura
            // 
            this.txtaltura.Location = new System.Drawing.Point(228, 107);
            this.txtaltura.Name = "txtaltura";
            this.txtaltura.Size = new System.Drawing.Size(135, 20);
            this.txtaltura.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(84, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Ingrese la base";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Ingrese la altura";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Perimetro";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Superficie";
            // 
            // Rectangulo_per_super
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtaltura);
            this.Controls.Add(this.txtsuperficie);
            this.Controls.Add(this.txtperimetro);
            this.Controls.Add(this.txtbase);
            this.Controls.Add(this.btmsalir);
            this.Controls.Add(this.btmnuevo);
            this.Controls.Add(this.btmcalcular);
            this.Name = "Rectangulo_per_super";
            this.Text = "Perimetro y superficie de un rectangulo";
            this.Load += new System.EventHandler(this.Rectangulo_per_super_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmsalir;
        private System.Windows.Forms.Button btmnuevo;
        private System.Windows.Forms.Button btmcalcular;
        private System.Windows.Forms.TextBox txtsuperficie;
        private System.Windows.Forms.TextBox txtperimetro;
        private System.Windows.Forms.TextBox txtbase;
        private System.Windows.Forms.TextBox txtaltura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
namespace AppFunciones2
{
    partial class Cuadrado_per_super
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
            this.btmnuevo = new System.Windows.Forms.Button();
            this.btmsalir = new System.Windows.Forms.Button();
            this.txtlongitud = new System.Windows.Forms.TextBox();
            this.txtperimetro = new System.Windows.Forms.TextBox();
            this.txtsuperficie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btmcalcular
            // 
            this.btmcalcular.Location = new System.Drawing.Point(438, 28);
            this.btmcalcular.Name = "btmcalcular";
            this.btmcalcular.Size = new System.Drawing.Size(118, 39);
            this.btmcalcular.TabIndex = 0;
            this.btmcalcular.Text = "Calcular";
            this.btmcalcular.UseVisualStyleBackColor = true;
            this.btmcalcular.Click += new System.EventHandler(this.btmcalcular_Click);
            // 
            // btmnuevo
            // 
            this.btmnuevo.Location = new System.Drawing.Point(438, 86);
            this.btmnuevo.Name = "btmnuevo";
            this.btmnuevo.Size = new System.Drawing.Size(118, 39);
            this.btmnuevo.TabIndex = 1;
            this.btmnuevo.Text = "Nuevo";
            this.btmnuevo.UseVisualStyleBackColor = true;
            this.btmnuevo.Click += new System.EventHandler(this.btmnuevo_Click);
            // 
            // btmsalir
            // 
            this.btmsalir.Location = new System.Drawing.Point(438, 184);
            this.btmsalir.Name = "btmsalir";
            this.btmsalir.Size = new System.Drawing.Size(118, 39);
            this.btmsalir.TabIndex = 2;
            this.btmsalir.Text = "Salir";
            this.btmsalir.UseVisualStyleBackColor = true;
            this.btmsalir.Click += new System.EventHandler(this.btmsalir_Click);
            // 
            // txtlongitud
            // 
            this.txtlongitud.Location = new System.Drawing.Point(192, 45);
            this.txtlongitud.Name = "txtlongitud";
            this.txtlongitud.Size = new System.Drawing.Size(135, 20);
            this.txtlongitud.TabIndex = 3;
            // 
            // txtperimetro
            // 
            this.txtperimetro.Location = new System.Drawing.Point(192, 161);
            this.txtperimetro.Name = "txtperimetro";
            this.txtperimetro.Size = new System.Drawing.Size(135, 20);
            this.txtperimetro.TabIndex = 4;
            // 
            // txtsuperficie
            // 
            this.txtsuperficie.Location = new System.Drawing.Point(192, 203);
            this.txtsuperficie.Name = "txtsuperficie";
            this.txtsuperficie.Size = new System.Drawing.Size(135, 20);
            this.txtsuperficie.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Ingrese la longitud";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Perimetro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Superficie";
            // 
            // Cuadrado_per_super
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtsuperficie);
            this.Controls.Add(this.txtperimetro);
            this.Controls.Add(this.txtlongitud);
            this.Controls.Add(this.btmsalir);
            this.Controls.Add(this.btmnuevo);
            this.Controls.Add(this.btmcalcular);
            this.Name = "Cuadrado_per_super";
            this.Text = "Perimetro y superficie de un cuadrado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmcalcular;
        private System.Windows.Forms.Button btmnuevo;
        private System.Windows.Forms.Button btmsalir;
        private System.Windows.Forms.TextBox txtlongitud;
        private System.Windows.Forms.TextBox txtperimetro;
        private System.Windows.Forms.TextBox txtsuperficie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
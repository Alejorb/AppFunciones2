namespace AppFunciones2
{
    partial class ConvertidorDeGrados
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
            this.btmconvertir = new System.Windows.Forms.Button();
            this.txtC = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btmsalir = new System.Windows.Forms.Button();
            this.btmnuevo = new System.Windows.Forms.Button();
            this.txtF = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btmconvertir
            // 
            this.btmconvertir.Location = new System.Drawing.Point(520, 38);
            this.btmconvertir.Name = "btmconvertir";
            this.btmconvertir.Size = new System.Drawing.Size(107, 36);
            this.btmconvertir.TabIndex = 0;
            this.btmconvertir.Text = "Convertir";
            this.btmconvertir.UseVisualStyleBackColor = true;
            this.btmconvertir.Click += new System.EventHandler(this.btmconvertir_Click);
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(244, 58);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(188, 20);
            this.txtC.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(111, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "grados Celcius °C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "grados Fahrenheit °F";
            // 
            // btmsalir
            // 
            this.btmsalir.Location = new System.Drawing.Point(520, 159);
            this.btmsalir.Name = "btmsalir";
            this.btmsalir.Size = new System.Drawing.Size(107, 36);
            this.btmsalir.TabIndex = 5;
            this.btmsalir.Text = "Salir";
            this.btmsalir.UseVisualStyleBackColor = true;
            this.btmsalir.Click += new System.EventHandler(this.btmsalir_Click);
            // 
            // btmnuevo
            // 
            this.btmnuevo.Location = new System.Drawing.Point(520, 98);
            this.btmnuevo.Name = "btmnuevo";
            this.btmnuevo.Size = new System.Drawing.Size(107, 36);
            this.btmnuevo.TabIndex = 6;
            this.btmnuevo.Text = "Nuevo";
            this.btmnuevo.UseVisualStyleBackColor = true;
            this.btmnuevo.Click += new System.EventHandler(this.btmnuevo_Click);
            // 
            // txtF
            // 
            this.txtF.Location = new System.Drawing.Point(244, 114);
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(188, 20);
            this.txtF.TabIndex = 7;
            // 
            // ConvertidorDeGrados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtF);
            this.Controls.Add(this.btmnuevo);
            this.Controls.Add(this.btmsalir);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.btmconvertir);
            this.Name = "ConvertidorDeGrados";
            this.Text = "ConvertidorDeGrados";
            this.Load += new System.EventHandler(this.ConversorDeGrados_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmconvertir;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btmsalir;
        private System.Windows.Forms.Button btmnuevo;
        private System.Windows.Forms.TextBox txtF;
    }
}
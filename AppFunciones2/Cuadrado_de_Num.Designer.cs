namespace AppFunciones2
{
    partial class Cuadrado_de_Num
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
            this.btmcuadrado = new System.Windows.Forms.Button();
            this.btnuevo = new System.Windows.Forms.Button();
            this.btmsalir = new System.Windows.Forms.Button();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txtnumCuadrado = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btmcuadrado
            // 
            this.btmcuadrado.Location = new System.Drawing.Point(424, 36);
            this.btmcuadrado.Name = "btmcuadrado";
            this.btmcuadrado.Size = new System.Drawing.Size(186, 32);
            this.btmcuadrado.TabIndex = 0;
            this.btmcuadrado.Text = "Elevar al cuadrado";
            this.btmcuadrado.UseVisualStyleBackColor = true;
            this.btmcuadrado.Click += new System.EventHandler(this.btmcuadrado_Click);
            // 
            // btnuevo
            // 
            this.btnuevo.Location = new System.Drawing.Point(424, 93);
            this.btnuevo.Name = "btnuevo";
            this.btnuevo.Size = new System.Drawing.Size(186, 32);
            this.btnuevo.TabIndex = 1;
            this.btnuevo.Text = "Nuevo";
            this.btnuevo.UseVisualStyleBackColor = true;
            this.btnuevo.Click += new System.EventHandler(this.btnuevo_Click);
            // 
            // btmsalir
            // 
            this.btmsalir.Location = new System.Drawing.Point(424, 158);
            this.btmsalir.Name = "btmsalir";
            this.btmsalir.Size = new System.Drawing.Size(186, 32);
            this.btmsalir.TabIndex = 2;
            this.btmsalir.Text = "Salir";
            this.btmsalir.UseVisualStyleBackColor = true;
            this.btmsalir.Click += new System.EventHandler(this.btmsalir_Click);
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(177, 43);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(180, 20);
            this.txtnum.TabIndex = 3;
            // 
            // txtnumCuadrado
            // 
            this.txtnumCuadrado.Location = new System.Drawing.Point(177, 105);
            this.txtnumCuadrado.Name = "txtnumCuadrado";
            this.txtnumCuadrado.Size = new System.Drawing.Size(180, 20);
            this.txtnumCuadrado.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingrese un número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Número elevado al cuadrado";
            // 
            // Cuadrado_de_Num
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtnumCuadrado);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.btmsalir);
            this.Controls.Add(this.btnuevo);
            this.Controls.Add(this.btmcuadrado);
            this.Name = "Cuadrado_de_Num";
            this.Text = "Cuadrado de un número";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmcuadrado;
        private System.Windows.Forms.Button btnuevo;
        private System.Windows.Forms.Button btmsalir;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txtnumCuadrado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
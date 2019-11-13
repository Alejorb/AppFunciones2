namespace AppFunciones2
{
    partial class Factorial
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
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txtfactorial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btmsalir
            // 
            this.btmsalir.Location = new System.Drawing.Point(477, 227);
            this.btmsalir.Name = "btmsalir";
            this.btmsalir.Size = new System.Drawing.Size(118, 39);
            this.btmsalir.TabIndex = 16;
            this.btmsalir.Text = "Salir";
            this.btmsalir.UseVisualStyleBackColor = true;
            this.btmsalir.Click += new System.EventHandler(this.btmsalir_Click);
            // 
            // btmnuevo
            // 
            this.btmnuevo.Location = new System.Drawing.Point(477, 129);
            this.btmnuevo.Name = "btmnuevo";
            this.btmnuevo.Size = new System.Drawing.Size(118, 39);
            this.btmnuevo.TabIndex = 15;
            this.btmnuevo.Text = "Nuevo";
            this.btmnuevo.UseVisualStyleBackColor = true;
            // 
            // btmcalcular
            // 
            this.btmcalcular.Location = new System.Drawing.Point(477, 71);
            this.btmcalcular.Name = "btmcalcular";
            this.btmcalcular.Size = new System.Drawing.Size(118, 39);
            this.btmcalcular.TabIndex = 14;
            this.btmcalcular.Text = "Calcular";
            this.btmcalcular.UseVisualStyleBackColor = true;
            this.btmcalcular.Click += new System.EventHandler(this.btmcalcular_Click);
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(194, 81);
            this.txtnum.MaxLength = 10;
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(188, 20);
            this.txtnum.TabIndex = 17;
            // 
            // txtfactorial
            // 
            this.txtfactorial.Location = new System.Drawing.Point(194, 139);
            this.txtfactorial.MaxLength = 10;
            this.txtfactorial.Name = "txtfactorial";
            this.txtfactorial.ReadOnly = true;
            this.txtfactorial.Size = new System.Drawing.Size(188, 20);
            this.txtfactorial.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Ingrese un número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "El factorial es: ";
            // 
            // Factorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtfactorial);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.btmsalir);
            this.Controls.Add(this.btmnuevo);
            this.Controls.Add(this.btmcalcular);
            this.Name = "Factorial";
            this.Text = "Factorial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmsalir;
        private System.Windows.Forms.Button btmnuevo;
        private System.Windows.Forms.Button btmcalcular;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txtfactorial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
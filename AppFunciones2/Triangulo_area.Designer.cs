namespace AppFunciones2
{
    partial class Triangulo_area
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btmsalir = new System.Windows.Forms.Button();
            this.btmnuevo = new System.Windows.Forms.Button();
            this.btmcalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(251, 58);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(163, 20);
            this.txtA.TabIndex = 0;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(251, 102);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(163, 20);
            this.txtB.TabIndex = 1;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(251, 149);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(163, 20);
            this.txtC.TabIndex = 2;
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(251, 243);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(163, 20);
            this.txtArea.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrse el lado A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese el lado B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ingrese el lado C";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Área del triangulo";
            // 
            // btmsalir
            // 
            this.btmsalir.Location = new System.Drawing.Point(540, 214);
            this.btmsalir.Name = "btmsalir";
            this.btmsalir.Size = new System.Drawing.Size(118, 39);
            this.btmsalir.TabIndex = 10;
            this.btmsalir.Text = "Salir";
            this.btmsalir.UseVisualStyleBackColor = true;
            this.btmsalir.Click += new System.EventHandler(this.btmsalir_Click);
            // 
            // btmnuevo
            // 
            this.btmnuevo.Location = new System.Drawing.Point(540, 116);
            this.btmnuevo.Name = "btmnuevo";
            this.btmnuevo.Size = new System.Drawing.Size(118, 39);
            this.btmnuevo.TabIndex = 9;
            this.btmnuevo.Text = "Nuevo";
            this.btmnuevo.UseVisualStyleBackColor = true;
            this.btmnuevo.Click += new System.EventHandler(this.btmnuevo_Click);
            // 
            // btmcalcular
            // 
            this.btmcalcular.Location = new System.Drawing.Point(540, 58);
            this.btmcalcular.Name = "btmcalcular";
            this.btmcalcular.Size = new System.Drawing.Size(118, 39);
            this.btmcalcular.TabIndex = 8;
            this.btmcalcular.Text = "Calcular";
            this.btmcalcular.UseVisualStyleBackColor = true;
            this.btmcalcular.Click += new System.EventHandler(this.btmcalcular_Click);
            // 
            // Triangulo_area
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btmsalir);
            this.Controls.Add(this.btmnuevo);
            this.Controls.Add(this.btmcalcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Name = "Triangulo_area";
            this.Text = "Área de un triangulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btmsalir;
        private System.Windows.Forms.Button btmnuevo;
        private System.Windows.Forms.Button btmcalcular;
    }
}
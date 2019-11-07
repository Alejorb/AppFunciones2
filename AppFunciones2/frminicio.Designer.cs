namespace AppFunciones2
{
    partial class frminicio
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
            this.btmCalcular = new System.Windows.Forms.Button();
            this.btmNuevo = new System.Windows.Forms.Button();
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtX1 = new System.Windows.Forms.TextBox();
            this.txtX2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btmSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btmCalcular
            // 
            this.btmCalcular.Location = new System.Drawing.Point(537, 65);
            this.btmCalcular.Name = "btmCalcular";
            this.btmCalcular.Size = new System.Drawing.Size(95, 24);
            this.btmCalcular.TabIndex = 0;
            this.btmCalcular.Text = "Calcular";
            this.btmCalcular.UseVisualStyleBackColor = true;
            this.btmCalcular.Click += new System.EventHandler(this.btmCalcular_Click);
            // 
            // btmNuevo
            // 
            this.btmNuevo.Location = new System.Drawing.Point(539, 112);
            this.btmNuevo.Name = "btmNuevo";
            this.btmNuevo.Size = new System.Drawing.Size(92, 22);
            this.btmNuevo.TabIndex = 1;
            this.btmNuevo.Text = "Nuevo";
            this.btmNuevo.UseVisualStyleBackColor = true;
            this.btmNuevo.Click += new System.EventHandler(this.btmNuevo_Click);
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(254, 39);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(140, 20);
            this.txtA.TabIndex = 2;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(256, 75);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(138, 20);
            this.txtB.TabIndex = 3;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(255, 114);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(138, 20);
            this.txtC.TabIndex = 4;
            // 
            // txtX1
            // 
            this.txtX1.Location = new System.Drawing.Point(255, 155);
            this.txtX1.Name = "txtX1";
            this.txtX1.ReadOnly = true;
            this.txtX1.Size = new System.Drawing.Size(135, 20);
            this.txtX1.TabIndex = 5;
            // 
            // txtX2
            // 
            this.txtX2.Location = new System.Drawing.Point(256, 203);
            this.txtX2.Name = "txtX2";
            this.txtX2.Size = new System.Drawing.Size(139, 20);
            this.txtX2.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "X2";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "X1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Ingrese el valor de C";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Ingrese el valor de B";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Ingrese el valor de A";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btmSalir
            // 
            this.btmSalir.Location = new System.Drawing.Point(545, 167);
            this.btmSalir.Name = "btmSalir";
            this.btmSalir.Size = new System.Drawing.Size(87, 23);
            this.btmSalir.TabIndex = 17;
            this.btmSalir.Text = "Salir";
            this.btmSalir.UseVisualStyleBackColor = true;
            this.btmSalir.Click += new System.EventHandler(this.btmSalir_Click);
            // 
            // frminicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btmSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtX2);
            this.Controls.Add(this.txtX1);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.btmNuevo);
            this.Controls.Add(this.btmCalcular);
            this.Name = "frminicio";
            this.Text = "Ecuaciones de segundo grado";
            this.Load += new System.EventHandler(this.frminicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmCalcular;
        private System.Windows.Forms.Button btmNuevo;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtX1;
        private System.Windows.Forms.TextBox txtX2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btmSalir;
    }
}
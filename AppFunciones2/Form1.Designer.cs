namespace AppFunciones2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textNum1 = new System.Windows.Forms.TextBox();
            this.textNum2 = new System.Windows.Forms.TextBox();
            this.textResultado = new System.Windows.Forms.TextBox();
            this.btmSumar = new System.Windows.Forms.Button();
            this.btmCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ingrese un numero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ingrese otro entero";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "resultado";
            // 
            // textNum1
            // 
            this.textNum1.Location = new System.Drawing.Point(218, 37);
            this.textNum1.Name = "textNum1";
            this.textNum1.Size = new System.Drawing.Size(106, 20);
            this.textNum1.TabIndex = 3;
            this.textNum1.TextChanged += new System.EventHandler(this.textNum1_TextChanged);
            // 
            // textNum2
            // 
            this.textNum2.Location = new System.Drawing.Point(218, 92);
            this.textNum2.Name = "textNum2";
            this.textNum2.Size = new System.Drawing.Size(106, 20);
            this.textNum2.TabIndex = 4;
            // 
            // textResultado
            // 
            this.textResultado.Location = new System.Drawing.Point(218, 169);
            this.textResultado.Name = "textResultado";
            this.textResultado.Size = new System.Drawing.Size(106, 20);
            this.textResultado.TabIndex = 5;
            this.textResultado.TextChanged += new System.EventHandler(this.textResultado_TextChanged);
            // 
            // btmSumar
            // 
            this.btmSumar.Location = new System.Drawing.Point(102, 237);
            this.btmSumar.Name = "btmSumar";
            this.btmSumar.Size = new System.Drawing.Size(88, 23);
            this.btmSumar.TabIndex = 6;
            this.btmSumar.Text = "sumar";
            this.btmSumar.UseVisualStyleBackColor = true;
            this.btmSumar.Click += new System.EventHandler(this.btmSumar_Click);
            // 
            // btmCerrar
            // 
            this.btmCerrar.Location = new System.Drawing.Point(223, 238);
            this.btmCerrar.Name = "btmCerrar";
            this.btmCerrar.Size = new System.Drawing.Size(94, 21);
            this.btmCerrar.TabIndex = 7;
            this.btmCerrar.Text = "cerrar";
            this.btmCerrar.UseVisualStyleBackColor = true;
            this.btmCerrar.Click += new System.EventHandler(this.btmCerrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btmCerrar);
            this.Controls.Add(this.btmSumar);
            this.Controls.Add(this.textResultado);
            this.Controls.Add(this.textNum2);
            this.Controls.Add(this.textNum1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textNum1;
        private System.Windows.Forms.TextBox textNum2;
        private System.Windows.Forms.TextBox textResultado;
        private System.Windows.Forms.Button btmSumar;
        private System.Windows.Forms.Button btmCerrar;
    }
}


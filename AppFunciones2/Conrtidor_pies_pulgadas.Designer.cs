namespace AppFunciones2
{
    partial class Conrtidor_pies_pulgadas
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
            this.txtPies = new System.Windows.Forms.TextBox();
            this.txtMetros = new System.Windows.Forms.TextBox();
            this.txtPulgadas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btmsalir
            // 
            this.btmsalir.Location = new System.Drawing.Point(490, 229);
            this.btmsalir.Name = "btmsalir";
            this.btmsalir.Size = new System.Drawing.Size(118, 39);
            this.btmsalir.TabIndex = 13;
            this.btmsalir.Text = "Salir";
            this.btmsalir.UseVisualStyleBackColor = true;
            this.btmsalir.Click += new System.EventHandler(this.btmsalir_Click);
            // 
            // btmnuevo
            // 
            this.btmnuevo.Location = new System.Drawing.Point(490, 131);
            this.btmnuevo.Name = "btmnuevo";
            this.btmnuevo.Size = new System.Drawing.Size(118, 39);
            this.btmnuevo.TabIndex = 12;
            this.btmnuevo.Text = "Nuevo";
            this.btmnuevo.UseVisualStyleBackColor = true;
            this.btmnuevo.Click += new System.EventHandler(this.btmnuevo_Click);
            // 
            // btmcalcular
            // 
            this.btmcalcular.Location = new System.Drawing.Point(490, 73);
            this.btmcalcular.Name = "btmcalcular";
            this.btmcalcular.Size = new System.Drawing.Size(118, 39);
            this.btmcalcular.TabIndex = 11;
            this.btmcalcular.Text = "Calcular";
            this.btmcalcular.UseVisualStyleBackColor = true;
            this.btmcalcular.Click += new System.EventHandler(this.btmcalcular_Click);
            // 
            // txtPies
            // 
            this.txtPies.Location = new System.Drawing.Point(205, 193);
            this.txtPies.MaxLength = 10;
            this.txtPies.Name = "txtPies";
            this.txtPies.ReadOnly = true;
            this.txtPies.Size = new System.Drawing.Size(188, 20);
            this.txtPies.TabIndex = 15;
            // 
            // txtMetros
            // 
            this.txtMetros.Location = new System.Drawing.Point(205, 83);
            this.txtMetros.MaxLength = 10;
            this.txtMetros.Name = "txtMetros";
            this.txtMetros.Size = new System.Drawing.Size(188, 20);
            this.txtMetros.TabIndex = 14;
            // 
            // txtPulgadas
            // 
            this.txtPulgadas.Location = new System.Drawing.Point(205, 248);
            this.txtPulgadas.MaxLength = 10;
            this.txtPulgadas.Name = "txtPulgadas";
            this.txtPulgadas.ReadOnly = true;
            this.txtPulgadas.Size = new System.Drawing.Size(188, 20);
            this.txtPulgadas.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Metros";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Metros a Pies";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Pulgadas";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(88, 30);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(56, 13);
            this.linkLabel1.TabIndex = 20;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "MEDIDAS";
            // 
            // Conrtidor_pies_pulgadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPulgadas);
            this.Controls.Add(this.txtPies);
            this.Controls.Add(this.txtMetros);
            this.Controls.Add(this.btmsalir);
            this.Controls.Add(this.btmnuevo);
            this.Controls.Add(this.btmcalcular);
            this.Name = "Conrtidor_pies_pulgadas";
            this.Text = "Conrtidor_pies_pulgadas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btmsalir;
        private System.Windows.Forms.Button btmnuevo;
        private System.Windows.Forms.Button btmcalcular;
        private System.Windows.Forms.TextBox txtPies;
        private System.Windows.Forms.TextBox txtMetros;
        private System.Windows.Forms.TextBox txtPulgadas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
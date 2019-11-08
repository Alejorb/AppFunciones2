using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFunciones2
{
    public partial class ConvertidorDeGrados : Form
    {
        public ConvertidorDeGrados()
        {
            InitializeComponent();
        }

        private void ConversorDeGrados_Load(object sender, EventArgs e)
        {

        }

        //crear un mètodo
        private double conversor(double c)
        {
            //declarar variable
            double f = 0;
            //calcular
            f = ((9 * c) / (5)) + 32;
            return f;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btmsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmnuevo_Click(object sender, EventArgs e)
        {
            //encerar cuadros de texto
            this.txtC.Text = "";
            this.txtF.Text = "";
            this.txtC.Focus();
        }

        private void btmconvertir_Click(object sender, EventArgs e)
        {
            //llamada a la funsión convertidor
            double c = 0;
            //validar si el usuario a ingresado valores
            if (this.txtC.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese el valor que desea convertir...");
                this.txtC.Focus();//ubica el cursor en el cuadro
                return;//abandonar
            }
            c = Double.Parse(this.txtC.Text);
            double f = conversor(c);
            //asigno el valor de f a tctF
            this.txtF.Text = f.ToString();
        }
    }
}

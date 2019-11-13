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
    public partial class Triangulo_area : Form
    {
        public Triangulo_area()
        {
            InitializeComponent();
        }

        private void btmsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmnuevo_Click(object sender, EventArgs e)
        {
            //encerar los cuadros de texto
            this.txtA.Text = "";
            this.txtB.Text = "";
            this.txtC.Text = "";
            this.txtArea.Text = "";
            this.txtA.Focus();
        }

        //crear método
        private double area(double a, double b, double c)
        {
            //declarar variables
            double p = 0, rc=0,ar = 0;
            //calcular
            p = (a + b + c) / 2;//semiperimetro
            //calcular el valor al que se le sacará raiz cuadrada
            rc = p * (p - a) * (p - b) * (p - c);
            ar = Math.Sqrt(rc);//rc=raiz cuadrada
            return ar;
        }
        private void btmcalcular_Click(object sender, EventArgs e)
        {
            //llamar a la función área
            double a = 0, b = 0, c = 0;
            //validar si el usuario a ingresado valores
            if (txtA.Text.Length==0)
            {
                MessageBox.Show("Ingrese todos los datos");
                this.txtA.Focus();//ubica el cursor en el cuadro
                return;//abandonar
            }
            a = Double.Parse(txtA.Text);
            b = Double.Parse(txtB.Text);
            c = Double.Parse(txtC.Text);
            double ar = area(a, b, c);
            //asigno el valor de ar a txtArea
            this.txtArea.Text = ar.ToString();
        }
    }
}

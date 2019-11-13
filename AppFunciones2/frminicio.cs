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
    public partial class frminicio : Form
    {
        public frminicio()
        {
            InitializeComponent();
        }

        private void frminicio_Load(object sender, EventArgs e)
        {
            //este evento
            //se ejecuta cada vez que se habre el formulario

            //establecer el control txtX2 de solo
            //lectura
            this.txtX2.ReadOnly = true;

        }
        //crear un mètodo
        private double calcularX1(double a, double b, double c)
        {
            //declarar variable
            double x1 = 0, d = 0;
            //calcular discriminante
            d = (b * b) - (4 * a * c);

            //verificar si a distinti de  cero
            if(a==0)
            {
                MessageBox.Show("error al dividir para cero...");
                return 0;//abandonar
            }

            //verificar raices negativas
            if(d<0)
            {
                MessageBox.Show("error, la ecuación tiene soluciones imaginarias...");
                    return 0;
            }

            x1 = (-b + Math.Sqrt(d)) / (2 * a);
            return x1;
        }
        //crear un mètodo
        private double calcularX2(double a, double b, double c)
        {
            //declarar variable
            double x2 = 0, d = 0;
            //calcular discriminante
            d = (b * b) - (4 * a * c);

            //verificar si a distinti de  cero
            if (a == 0)
            {
                MessageBox.Show("error al dividir para cero...");
                return 0;//abandonar
            }

            //verificar raices negativas
            if (d < 0)
            {
                MessageBox.Show("error, la ecuación tiene soluciones imaginarias...");
                    return 0;
            }

            x2 = (-b - Math.Sqrt(d)) / (2 * a);
            return x2;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btmCalcular_Click(object sender, EventArgs e)
        {
            //llamada a la función calcularX1
            double a, b, c;
            //validar si el usuario a ingresado valores
            if(this.txtA.Text.Length==0)
            {
                MessageBox.Show("Por favor ingrese el valor de A...");
                    this.txtA.Focus();//ubica el cursor en el cuadro
                return;//abandonar
            }
            a = Double.Parse(this.txtA.Text);
            b = Double.Parse(this.txtB.Text);
            c = Double.Parse(this.txtC.Text);
            double x1 = calcularX1(a, b, c);
            double x2 = calcularX2(a, b, c);
            //asigno el resultado de x1 en  el textbox txtX1
            this.txtX1.Text = x1.ToString();
            this.txtX2.Text = x2.ToString();
        }

        private void btmSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmNuevo_Click(object sender, EventArgs e)
        {
            //encerar cuadros de texto
            this.txtA.Text = "";
            this.txtB.Text = "";
            this.txtB.Text = "";
            this.txtC.Text = "";
            this.txtX1.Text = "";
            this.txtX2.Text = "";
            this.txtA.Focus();



        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtX1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

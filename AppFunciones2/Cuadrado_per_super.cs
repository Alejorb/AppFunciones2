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
    public partial class Cuadrado_per_super : Form
    {
        public Cuadrado_per_super()
        {
            InitializeComponent();
        }

        private void btmsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmnuevo_Click(object sender, EventArgs e)
        {
            //encerar cuadros de texto
            this.txtlongitud.Text = "";
            this.txtperimetro.Text = "";
            this.txtsuperficie.Text = "";
            this.txtlongitud.Focus();
        }

        //crear método
        private double perimetro(double l)
        {
            //declarar variable
            double p = 0;
            //calcular
            p = l * 4; 
            return p;
        }

        //crear método
        private double superficie(double l)
        {
            //declarar variable
            double s = 0;
            //calcular
            s = l * l; 
            return s;
        }
        private void btmcalcular_Click(object sender, EventArgs e)
        {
            //llamada a la funciones perimetro y superficie
            double l = 0;
            if(txtlongitud.Text.Length==0)
            {
                MessageBox.Show("Ingrese la cantidad... ");
                this.txtlongitud.Focus();//ubica el cursor en el inicio
                return;//abandonar
            }
            l = Double.Parse(txtlongitud.Text);
            double p = perimetro(l);
            double s = superficie(l);
            //asignar valor de p a txtperimetro
            this.txtperimetro.Text = p.ToString();
            //asignar valor de s a txtsuperficie
            this.txtsuperficie.Text = s.ToString();
        }
    }
}

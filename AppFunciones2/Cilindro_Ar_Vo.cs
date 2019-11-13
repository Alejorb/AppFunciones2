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
    public partial class Cilindro_Ar_Vo : Form
    {
        public Cilindro_Ar_Vo()
        {
            InitializeComponent();
        }

        private void btmsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btminicio_Click(object sender, EventArgs e)
        {
            //encerar cuadros de texto
            this.txtradio.Text = "";
            this.txtaltura.Text = "";
            this.txtarea.Text = "";
            this.txtvolumen.Text = "";
            this.txtradio.Focus();
        }
        //crear un método
        private double area (double r, double h)
        {
            //declarar variables
            double a = 0;
            //calcular
            a = (2 * Math.PI * (r * r)) + (2 * Math.PI * r * h);
            return a;
        }

        //crear un método
        private double volumen (double r, double h)
        {
            //declarar variables
            double v = 0;
            //calcular
            v = Math.PI * (r * r) * h;
            return v;
        }

        private void btmcalcular_Click(object sender, EventArgs e)
        {
            //llamar a la función cilindro
            double r = 0, h = 0;
            //validar si el usuario a ingresado valores
            if (txtradio.Text.Length == 0) 
            {
                MessageBox.Show("Ingrese todos los datos... ");
                this.txtradio.Focus();//ubica el cursor en el cuadro
                return; //abandonar
            }
            r = Double.Parse(txtradio.Text);
            h = Double.Parse(txtaltura.Text);
            double a = area(r, h);
            double v = volumen(r, h);
            //asignar valor de a a txtarea
            this.txtarea.Text = a.ToString();
            //asignar valor de v a txtvolumen
            this.txtvolumen.Text = v.ToString();
        }
    }
}

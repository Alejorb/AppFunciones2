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
    public partial class Rectangulo_per_super : Form
    {
        public Rectangulo_per_super()
        {
            InitializeComponent();
        }

        private void Rectangulo_per_super_Load(object sender, EventArgs e)
        {

        }

        //crear método
        private double perimetro(double b,double h)
        {
            //declarar variable
            double p = 0;
            //calcular
            p = (2 * b) + (2 * h);
            return p;
        }

        //crear método
        private double superficie(double b,double h)
        {
            //daclarar variable
            double s = 0;
            //calcular
            s = b * h;
            return s;
        }
        private void btmcalcular_Click(object sender, EventArgs e)
        {
            //llamar a las funciones perimetro y superficie
            double b = 0, h = 0;
            if(txtbase.Text.Length==0)
            {
                MessageBox.Show("Ingrese los datos... ");
                this.txtbase.Focus();//poner cursor en el inicio
                return; //abandonar
            }
            b = Double.Parse(this.txtbase.Text);
            h = Double.Parse(this.txtaltura.Text);
            double p = perimetro(b, h);
            double s = superficie(b, h);
            //aisgnar valor de p a txtperimetro
            this.txtperimetro.Text = p.ToString();
            //asignar valor de s a txtsuperficie
            this.txtsuperficie.Text = s.ToString();
        }

        private void btmnuevo_Click(object sender, EventArgs e)
        {
            //encerar cuadros de texto
            this.txtbase.Text = "";
            this.txtaltura.Text = "";
            this.txtperimetro.Text = "";
            this.txtsuperficie.Text = "";
            this.txtbase.Focus();
        }

        private void btmsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

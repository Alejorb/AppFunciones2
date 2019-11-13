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
    public partial class Conrtidor_pies_pulgadas : Form
    {
        public Conrtidor_pies_pulgadas()
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
            this.txtMetros.Text = "";
            this.txtPies.Text = "";
            this.txtPulgadas.Text = "";
            this.txtMetros.Focus();
        }

        //crear método
        private double pies(double m)
        {
            //declarar variable
            double p = 0;
            //calcular
            p = (m * 39.37) / 12;
            return p;
        }

        //crear método
        private double pulgadas(double m)
        {
            //declarar variable
            double pl = 0;
            //calcular
            pl = m * 39.37;
            return pl;
        }
        private void btmcalcular_Click(object sender, EventArgs e)
        {
            //llamar a las funciones pies y pulgadas
            double m = 0;
            //validar si el usuario a ingresado valores
            if (this.txtMetros.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese el valor que desea convertir... ");
                this.txtMetros.Focus();//ubica el cursor en el cuadro
                return;//abandonar
            }

            try
            {
                m = Double.Parse(this.txtMetros.Text);

                double p = pies(m);
                double pl = pulgadas(m);
                //asignar el valor de p a txtPies
                this.txtPies.Text = p.ToString();
                //asignar el valor pl a txtPulgadas
                this.txtPulgadas.Text = pl.ToString();
            }
            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message.ToString());
            }

        }
    }
}

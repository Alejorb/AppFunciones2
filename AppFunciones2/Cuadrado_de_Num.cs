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
    public partial class Cuadrado_de_Num : Form
    {
        public Cuadrado_de_Num()
        {
            InitializeComponent();
        }
        //crear un mètodo
        private double cuadrado(double num)
        {
            //declarar variable
            double ncd = 0; 
            //calcular
            ncd = num * num;
            return ncd;
        }
        private void btmcuadrado_Click(object sender, EventArgs e)
        {
            //llamada a la funsión cuadrado
            double num = 0;
            //validar si el usuario a ingresado valores
            if (this.txtnum.Text.Length == 0)
            {
                MessageBox.Show("Ingrese el valor que desea elevar al cuadrado... ");
                this.txtnum.Focus(); //ubica el cursor en el cuadro
                return; //abandonar
            }
            num = Double.Parse(this.txtnum.Text);
            double ncd = cuadrado(num);
            //asigno el calor de cd a txtnumCuadrado
            this.txtnumCuadrado.Text = ncd.ToString();
        }

        private void btmsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnuevo_Click(object sender, EventArgs e)
        {
            //encerar cuadros de texto
            this.txtnum.Text = "";
            this.txtnumCuadrado.Text = "";
            this.txtnum.Focus();

        }
    }
}

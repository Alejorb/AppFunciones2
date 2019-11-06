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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btmCerrar_Click(object sender, EventArgs e)
        {
            //cierra el formulario
            this.Close();
        }

        private void btmSumar_Click(object sender, EventArgs e)
        {
            int num1 = Int32.Parse(this.textNum1.Text.ToString());
            int num2 = Int32.Parse(this.textNum2.Text.ToString());
            int suma = fnsuma(num1, num2);

            //asigno el resultado al cuadro de texto
            this.textResultado.Text = suma.ToString();
        }
            int fnsuma(int a, int b)
            {
                return (a + b);
            }

        private void textNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textResultado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

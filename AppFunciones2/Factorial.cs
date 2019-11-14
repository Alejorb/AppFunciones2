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
    public partial class Factorial : Form
    {
        public Factorial()
        {
            InitializeComponent();
        }

        private void btmsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private long factorial(int num)
        {
            int cont=1;
            for (int i = 1;i<=num;i++)
            {
                cont = cont * i ;
            }
            return cont;
        }
            
 
        private void btmcalcular_Click(object sender, EventArgs e)
        {
            int num = 0;
            if(this.txtnum.Text.Length==0)
            {
                MessageBox.Show("Ingrese el número...");
                this.txtnum.Focus();
                return;
            }
            try
            {
                num = int.Parse(this.txtnum.Text);

                long fac = factorial(num);
                //asignar valor de fac a txtfactorial
                this.txtfactorial.Text = fac.ToString();
            }
            catch(Exception ex1)
            {
                MessageBox.Show(ex1.Message.ToString());
            }
        }

        private void btmnuevo_Click(object sender, EventArgs e)
        {
            this.txtnum.Text = "";
            this.txtfactorial.Text = "";
            this.txtnum.Focus();
        }
    }
}

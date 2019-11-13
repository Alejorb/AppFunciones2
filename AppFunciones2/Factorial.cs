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
                cont = cont * (i );
            }
            return cont;
        }
            

        private void btmcalcular_Click(object sender, EventArgs e)
        {

        }
    }
}

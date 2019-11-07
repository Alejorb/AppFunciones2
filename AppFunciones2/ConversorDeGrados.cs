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
    public partial class ConversorDeGrados : Form
    {
        public ConversorDeGrados()
        {
            InitializeComponent();
        }

        private void ConversorDeGrados_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btmsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btmnuevo_Click(object sender, EventArgs e)
        {
            //encerar cuadros de texto
            this.txtC.Text = "";
            this.txtF.Text = "";
            this.txtC.Focus();
        }

        private void btmconvertir_Click(object sender, EventArgs e)
        {

        }
    }
}

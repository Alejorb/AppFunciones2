using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFunciones2
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frminicio());
            //Application.Run(new ConvertidorDeGrados());
            //Application.Run(new Cuadrado_de_Num());
            //Application.Run(new Cilindro_Ar_Vo());
            //Application.Run(new Cuadrado_per_super());
            //Application.Run(new Rectangulo_per_super());
            //Application.Run(new Triangulo_area());
            Application.Run(new Conrtidor_pies_pulgadas());
        }
    }
}

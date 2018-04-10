using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AgendaSQL
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //inicia aplicação
            cl_vars.Iniciar();

            //apresenta o menu inicial
            Application.Run(new frmMenu());
        }
    }
}

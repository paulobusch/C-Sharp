using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace ConversãoValores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            StreamWriter arquivo = new StreamWriter(@"C:\Users\paulo\Desktop\Projetos\C#\Aplication windows\ArquivosTexto\teste.txt", true, Encoding.Default);
            
            //string
            arquivo.WriteLine("Esta frase é alfanumérica");

            //int 
            int valor = 100;
            arquivo.WriteLine(valor);

            //bool
            bool resultado = false;
            arquivo.WriteLine(resultado);

            //data
            arquivo.WriteLine(DateTime.Now);

            //cor
            Color cor = Color.Yellow;
            arquivo.WriteLine(cor);

            arquivo.Dispose();
        }
    }
}

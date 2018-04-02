using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace ArquivosTexto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            //gravar arquivo de texto
            
            StreamWriter arquivo = new StreamWriter(@"C:\Users\paulo\Desktop\Projetos\C#\Aplication windows\ArquivosTexto\teste.txt", true, Encoding.Default);
            arquivo.WriteLine(txt_mensagem.Text);
            arquivo.Dispose();//fecha e desocupa memoria

        }
    }
}

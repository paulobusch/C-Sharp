using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace ApagaPastaArquivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            string[] lista_arquivos = Directory.GetFiles(@"C:\","*.txt");
            foreach(string arquivo in lista_arquivos)
            {
                lst_arquivos.Items.Add(arquivo);
                File.Move(arquivo, @"C:\tmp\" + Path.GetFileName(arquivo));
            }
            MessageBox.Show("Terminado");
        }
    }
}

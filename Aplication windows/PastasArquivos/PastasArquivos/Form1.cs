using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace PastasArquivos
{
    public partial class Form1 : Form
    {
        string pasta_config = @"C:\config\";
        string arquivo_config = "config.dat";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            //verifica se a pasta existe
            if (!Directory.Exists(pasta_config))
            {
                Directory.CreateDirectory(pasta_config);
            }
            StreamWriter arquivo = new StreamWriter(pasta_config + arquivo_config,false,Encoding.Default);
            arquivo.WriteLine(txt_nome.Text);
            arquivo.WriteLine(data_hora.Value.ToShortDateString());

            MessageBox.Show("Configurações gravadas com sucesso.");
            arquivo.Dispose();
        }
    }
}

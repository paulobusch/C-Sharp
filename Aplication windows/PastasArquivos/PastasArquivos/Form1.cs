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
        string pasta_config;
        string arquivo_config = "config.dat";

        public Form1()
        {
            InitializeComponent();
            //cria a pasta em meus documentos
            pasta_config = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\config\";
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            GravarConfiguracoes();
            MessageBox.Show("Configurações gravadas com sucesso.");
        }

        private void btn_carregar_Click(object sender, EventArgs e)
        {
            //verifica se o arquivo existe
            if(!File.Exists(pasta_config + arquivo_config))
            {
                GravarConfiguracoes();
                //MessageBox.Show("O arquivo de configurações não existe");
                //return; //termina execução do metodo
            }
            StreamReader arquivo = new StreamReader(pasta_config + arquivo_config,Encoding.Default);
            txt_nome.Text = arquivo.ReadLine();
            data_hora.Value = DateTime.Parse(arquivo.ReadLine());
            arquivo.Dispose();
        }
        private void GravarConfiguracoes()
        {
            //verifica se a pasta existe
            if (!Directory.Exists(pasta_config))
            {
                Directory.CreateDirectory(pasta_config);
            }
            StreamWriter arquivo = new StreamWriter(pasta_config + arquivo_config, false, Encoding.Default);

            arquivo.WriteLine(txt_nome.Text);
            arquivo.WriteLine(data_hora.Value.ToShortDateString());

            arquivo.Dispose();
        }
    }
}

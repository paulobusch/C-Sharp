using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

//importações
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Vision.Motion;
using System.IO;

namespace GravaMovimentos
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection dispositivos;
        private VideoCaptureDevice fonte;
        //inicia detecção da camera
        private MotionDetector detector = new MotionDetector(new TwoFramesDifferenceDetector(), new BlobCountingObjectsProcessing());
        private FolderBrowserDialog arquivo;
        private string pasta;
        //private VideoFileWriter Escrever = new VideoFileWriter();
        private string pasta_config;
        private string arquivo_config = "config.ini";

        float indice;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);

            //lista dispositivos
            foreach (FilterInfo camera in dispositivos)
            {
                cmb_dispositivos.Items.Add(camera.Name);
            }
            if (dispositivos.Count != 0)
            {
                cmb_dispositivos.SelectedIndex = 0;
            }
            else
            {
                cmb_dispositivos.Items.Add("Não há dispositivo conectado!");
            }

            ler_arquivo();

        }

        private void ler_arquivo()
        {
            pasta_config = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\config";

            verificaPasta();
            verificaArquivo();

            leituraConfig();
        }

        private void verificaPasta()
        {
            //verifica se o diretório existe
            if (!Directory.Exists(pasta_config))
            {
                //cria o diretório
                Directory.CreateDirectory(pasta_config);
            }
        }

        private void verificaArquivo()
        {
            //verifica se o arquivos existe
            if (!File.Exists(pasta_config + @"\" + arquivo_config))
            {
                //cria o arquivo
                StreamWriter escrever = new StreamWriter(pasta_config + @"\" + arquivo_config, true, Encoding.Default);
                escrever.Dispose();
            }
        }

        private void leituraConfig()
        {
            //inicia configurações
            StreamReader ler = new StreamReader(pasta_config + @"\" + arquivo_config, Encoding.Default);

            //inclui itens na lista
            while (!ler.EndOfStream)
            {
                cmb_procurar.Items.Add(ler.ReadLine());
            }

            ler.Dispose();
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            fonte = new VideoCaptureDevice(dispositivos[cmb_dispositivos.SelectedIndex].MonikerString);
            fonte.NewFrame += new NewFrameEventHandler(Novo_Quadro);
            fonte.Start();
        }

        private void Novo_Quadro(object sender, NewFrameEventArgs eventArgs)
        {
            imagem_frame.Image = (Bitmap)eventArgs.Frame.Clone();
            //indice = detector.ProcessFrame((Bitmap)eventArgs.Frame.Clone());

            //configurar detecção de movimentos
            //indice = detector.ProcessFrame((Bitmap)imagem_frame.Image);
        }

        private void btn_parar_Click(object sender, EventArgs e)
        {
            fonte.SignalToStop();
        }

        private void btn_detectar_Click(object sender, EventArgs e)
        {
            indice = 0;

            //inicia gravação de quadros

        }

        private void btn_procurar_Click(object sender, EventArgs e)
        {
            escolherDiretorio();

            //grava config
            gravaConfig();
        }

        private void escolherDiretorio()
        {
            //abre arquivo
            arquivo = new FolderBrowserDialog();
            if (arquivo.ShowDialog() == DialogResult.OK)
            {
                //arquivo selecionado
                pasta = arquivo.SelectedPath;

                pasta += @"\videos";

                //cria pasta
                Directory.CreateDirectory(pasta);
            }
        }

        private void gravaConfig()
        {
            StreamWriter escrever = new StreamWriter(pasta_config + @"\" + arquivo_config,true,Encoding.Default);
            escrever.WriteLine(pasta);
            escrever.Dispose();
        }
    }
}

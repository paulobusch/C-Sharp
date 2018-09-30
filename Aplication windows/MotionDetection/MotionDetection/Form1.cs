using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//namespaces incluídos
using AForge.Video;
using AForge.Video.DirectShow;
//motion detection
using AForge.Vision.Motion;

namespace MotionDetection
{
    public partial class Form1 : Form
    {
        //para lista de dispositivos
        private FilterInfoCollection dispositivo;
        //para fonte de vídeo
        private VideoCaptureDevice fonte;

        //variável para detecção 
        MotionDetector detector;
        float nivelDe;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //inicia variáveis de detecção
            detector = new MotionDetector(new TwoFramesDifferenceDetector(), new BlobCountingObjectsProcessing());
            nivelDe = 0;

            //lista dispositivos disponíveis
            dispositivo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            //carrega todos os dispositivos no campo de exibição
            foreach (FilterInfo cam in dispositivo)
            {
                cmb_cameras.Items.Add(cam.Name);
            }
            cmb_cameras.SelectedIndex = 0;
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            //estabelece conexão
            fonte = new VideoCaptureDevice(dispositivo[cmb_cameras.SelectedIndex].MonikerString);
            //inicializa controle
            videoSourcePlayer.VideoSource = fonte;
            //inicia recepção de imagens
            videoSourcePlayer.Start();
        }

        private void btn_parar_Click(object sender, EventArgs e)
        {
            //para recepção de imagem
            videoSourcePlayer.SignalToStop();
        }

        private void videoSourcePlayer_NewFrame(object sender, ref Bitmap image)
        {
            nivelDe = detector.ProcessFrame(image);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txt_deteccao.Text = String.Format("{0:00.0000}", nivelDe);
        }
    }
}

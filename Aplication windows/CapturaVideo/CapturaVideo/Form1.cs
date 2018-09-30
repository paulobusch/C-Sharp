using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Video.FFMPEG;
using AForge.Video.VFW;


namespace CapturaVideo
{

    public partial class Form1 : Form
    {
        private FilterInfoCollection dispositivos;
        private VideoCaptureDevice fonte;
        private Bitmap video, redimensionada;
        //private AVIWriter AVIwriter = new AVIWriter();
        private VideoFileWriter Escrever = new VideoFileWriter();
        private bool gravando { get; set; }
        private int w = 640, h = 480;

        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            dispositivos = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            //lista dispositivos
            foreach (FilterInfo cam in dispositivos)
            {
                cmb_dispositivos.Items.Add(cam.Name);
            }
            if (cmb_dispositivos.Items.Count != 0)
            {
                cmb_dispositivos.SelectedIndex = 0;
            }
            else
            {
                cmb_dispositivos.Items.Add("Nenhum dispositivo!");
            }
            gravando = false;

        }

        private void btn_strat_Click(object sender, EventArgs e)
        {
            fonte = new VideoCaptureDevice(dispositivos[cmb_dispositivos.SelectedIndex].MonikerString);


            //fonte.VideoResolution = selectResolution(fonte);


            fonte.NewFrame += new NewFrameEventHandler(FinalVideo_NewFrame);
            fonte.Start();
        }

        private static VideoCapabilities selectResolution(VideoCaptureDevice device)
        {
            foreach (var cap in device.VideoCapabilities)
            {
                if (cap.FrameSize.Height == 1080)
                    return cap;
                if (cap.FrameSize.Width == 1920)
                    return cap;
            }
            return device.VideoCapabilities.Last();
        }
        
        private void FinalVideo_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            //MessageBox.Show(eventArgs.Frame.Width + " x " + eventArgs.Frame.Height);
            //video = new Bitmap((Bitmap)eventArgs.Frame.Clone(), new Size(w, h));
            
            //exibe quadro
            imagem_captura.Image = (Bitmap)eventArgs.Frame.Clone();

            //se estuver gravando escreve quadro
            if (gravando){
                Escrever.WriteVideoFrame(new Bitmap((Bitmap)eventArgs.Frame.Clone(), new Size(w, h)));
            }
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
           // video_tela.Wri.Save("IMG" + DateTime.Now.ToString("hhmmss") + ".jpg");
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            //para escrita
            gravando = false;

            Escrever.Close();
            Escrever.Dispose();
            fonte.SignalToStop();
        }

        private void btn_capture_Click(object sender, EventArgs e)
        {
            string pasta = @"C:\Users\Paulo Ricardo Busch\Desktop\videos\";
            Escrever.Open(pasta + "VID" + DateTime.Now.ToString("hhmmss") + ".mp4", w, h, 25, VideoCodec.MPEG4);

            video = (Bitmap)imagem_captura.Image.Clone();
            Escrever.WriteVideoFrame(new Bitmap(video, new Size(w, h)));

            //habilita escrita
            gravando = true;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (fonte.IsRunning)
            {
                fonte.SignalToStop();
                Escrever.Close();
            }
        }

        private void video_tela_NewFrame(object sender, ref Bitmap image)
        {
            //video = (Bitmap)image.Clone();
            //escreve();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Escrever.WriteVideoFrame(new Bitmap(video, new Size(w, h)));
        }

        private void escreve()
        {
            //Escrever.WriteVideoFrame(video);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Escrever.WriteVideoFrame(video_tela.GetCurrentVideoFrame());
            //video = (Bitmap)image.Frame.Clone();
            //pbVideo.Image = (Bitmap)eventArgs.Frame.Clone();
            // writer = new VideoFileWriter (); 
            //Escrever.WriteVideoFrame();

        }
    }
}

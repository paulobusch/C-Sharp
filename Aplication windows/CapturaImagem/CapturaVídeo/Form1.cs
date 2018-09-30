using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace CapturaVídeo
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection dispoditivo;
        private VideoCaptureDevice imagem;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_foto_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dispoditivo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo capturar in dispoditivo)
            {
                //lista os dispositivos disponíveis
                cmb_itens.Items.Add(capturar.Name);
            }
            //cmb_itens.SelectedIndex = 0;
        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            imagem = new VideoCaptureDevice(dispoditivo[cmb_itens.SelectedIndex].MonikerString);
            imagem.NewFrame += new NewFrameEventHandler(camera);
            imagem.Start();
        }

        void camera(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap bit = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = bit;
        }

        private void btn_parar_Click(object sender, EventArgs e)
        {
            if (imagem.IsRunning)
            {
                imagem.Stop();
            }
        }
    }
}

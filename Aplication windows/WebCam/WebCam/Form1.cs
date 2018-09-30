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

namespace WebCam
{
    public partial class Form1 : Form
    {
        private bool DeviceExist = false;
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource = null;
        
        // método para captura de quadro da webcam
        private void video_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap img = (Bitmap)eventArgs.Frame.Clone();
            pictureBox.Image = img;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_capturar_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //código do carregamento (load) do Form
            //lista os dispositivos de captura de imagem do computador/notebook
            try
            {
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                cmb_dispositivo.Items.Clear();
                if (videoDevices.Count == 0)
                    throw new ApplicationException();

                DeviceExist = true;
                foreach (FilterInfo device in videoDevices)
                {
                    cmb_dispositivo.Items.Add(device.Name);
                }
                cmb_dispositivo.SelectedIndex = 0; //make dafault to first cam
            }
            catch (ApplicationException)
            {
                DeviceExist = false;
                cmb_dispositivo.Items.Add("Nenhum dispositivo encontrado!");
            }

            if (btn_capturar.Text == "Capturar")
            {
                if (DeviceExist)
                {
                    videoSource = new VideoCaptureDevice(videoDevices[comboBox1.SelectedIndex].MonikerString);
                    videoSource.NewFrame += new NewFrameEventHandler(video_NewFrame);

                    //Encerra o sinal da camera.
                    if (!(videoSource == null))
                        if (videoSource.IsRunning)
                        {
                            videoSource.SignalToStop();
                            videoSource = null;
                        }
                    videoSource.DesiredFrameSize = new Size(160, 120);
                    videoSource.DesiredFrameRate = 10;
                    videoSource.Start();

                    btn_capturar.Text = "Gravar";
                }
                else
                {
                    MessageBox.Show("Nenhum dispositivo encontrado!");
                }
            }
            else
            {
                if (videoSource.IsRunning)
                {
                    //Encerra o sinal da camera.
                    // Note que este bloco de código se repetiu, você pode cirar um método para ele.
                    if (!(videoSource == null))
                        if (videoSource.IsRunning)
                        {
                            videoSource.SignalToStop();
                            videoSource = null;

                            // salva a imagem;
                            saveFileDialog1.Filter = "JPEG (*.jpg;*.jpeg;*jpeg;*.jfif)|*.jpg;*.jpeg;*jpeg;*.jfif";
                            DialogResult res = saveFileDialog1.ShowDialog();
                            if (res == DialogResult.OK)
                            {
                                pictureBox1.Image.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                            }
                        }
                }
            }
        }
    }
    }
}

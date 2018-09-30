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
using AForge.Video.FFMPEG;
using System.IO;
using System.Threading;

namespace CapturaVideo1
{
    public partial class Form1 : Form
    {
        private VideoCaptureDeviceForm captureDevice;
        private string path = Path.GetDirectoryName(Application.ExecutablePath) + @"\Videos\";
        private FilterInfoCollection videoDevice;
        private VideoCaptureDevice videoSource;
        private VideoFileWriter FileWriter = new VideoFileWriter();
        private Bitmap video;
        bool isRecord = false;
        float fts = 0.0f;



        private Thread workerThread = null;
        private bool stopProcess = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            video = (Bitmap)eventArgs.Frame.Clone();
            picture_box.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            videoDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            captureDevice = new VideoCaptureDeviceForm();
            if (captureDevice.ShowDialog(this) == DialogResult.OK)
            {
                videoSource = captureDevice.VideoDevice;
                videoSource = captureDevice.VideoDevice;
                videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);
                videoSource.Start();
                timer1.Enabled = true;
            }
            //videoSource.DisplayPropertyPage(IntPtr.Zero);
        }

        private void recordLiveCam()
        {
            if (!stopProcess)
            {
                while (isRecord)
                {
                    FileWriter.WriteVideoFrame(video);
                }
                FileWriter.Close();
            }
            else
            {
                workerThread.Abort();
            }
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            //try
            //{
            isRecord = true;
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            int h = captureDevice.VideoDevice.VideoResolution.FrameSize.Height;
            int w = captureDevice.VideoDevice.VideoResolution.FrameSize.Width;
            FileWriter.Open(path + "recorded at " + DateTime.Now.ToString("HH-mm-ss") + ".mp4", w, h, 25, VideoCodec.MPEG4);
            stopProcess = false;
            workerThread = new Thread(new ThreadStart(recordLiveCam));
            workerThread.Start();

            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btn_parar_gravar_Click(object sender, EventArgs e)
        {
            stopProcess = true;
            isRecord = false;
            FileWriter.Close();
            workerThread.Abort();
            video = null;
        }

        private void btn_parar_camera_Click(object sender, EventArgs e)
        {
            try
            {
                if (videoSource.IsRunning)
                {
                    videoSource.SignalToStop();
                    videoSource.Stop();
                    picture_box.Image = null;
                    picture_box.Invalidate();
                    if (FileWriter.IsOpen)
                    {
                        FileWriter.Close();
                        video = null;
                    }
                }
                else
                    return;
            }
            catch
            {
                videoSource.Stop();
                FileWriter.Close();
                video = null;
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fts = videoSource.FramesReceived;
            label1.Text = "Frame Rate : " + fts.ToString("F2") + " fps";
        }
    }
}

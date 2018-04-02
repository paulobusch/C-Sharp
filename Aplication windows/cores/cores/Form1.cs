using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cores
{
    public partial class Form1 : Form
    {
        Color cor = Color.White;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void ApresentarCor()
        {
            cor = Color.FromArgb(trackBar1.Value,trackBar2.Value,trackBar3.Value);
            caixa.BackColor = cor;
            txt_rgb.Text = trackBar1.Value + "," + trackBar2.Value + "," + trackBar3.Value;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
            ApresentarCor();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar2.Value.ToString();
            ApresentarCor();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label3.Text = trackBar3.Value.ToString();
            ApresentarCor();
        }
    }
}

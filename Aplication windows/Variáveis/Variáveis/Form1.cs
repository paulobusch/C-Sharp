using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Variáveis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_executa_Click(object sender, EventArgs e)
        {
            //criar variável - tipo
            float f = 10.5f;
            double dou = 10.5d;
            decimal dec = 10.5m;

            float n = (float) 1 / 3;
            lbl_msg.Text = n.ToString();
        }
    }
}

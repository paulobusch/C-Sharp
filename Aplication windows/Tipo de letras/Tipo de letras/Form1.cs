﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tipo_de_letras
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //fonte
            Font letras = new Font("Helvetica",14,FontStyle.Bold | FontStyle.Italic,GraphicsUnit.Pixel);
            label1.Font = letras;

            //cor da fonte
            label1.ForeColor = Color.Red;
        }
    }
}

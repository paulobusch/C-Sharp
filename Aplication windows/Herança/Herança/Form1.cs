﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Herança
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cl_carro carro1 = new cl_carro();
            cl_bicicleta bic = new cl_bicicleta();
            carro1.Acelerar();
            bic.Acelerar();
            carro1.Parar();
            bic.Parar();
        }
    }
}

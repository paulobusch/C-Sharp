﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassesMetodos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            cl_matematica calculadora = new cl_matematica();
            int v1 = 15, v2 = 3;
            lbl_texto.Text = "Soma: " + calculadora.Operacoes(v1,v2,"adição").ToString();
        }
    }
}

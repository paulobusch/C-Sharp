﻿using System;
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
            string nome = "Paulo";
            int num = nome.Length;
            lbl_msg.Text = "O nome: " + nome + " tem " + num.ToString() + " letras.";
            char caracter = 'c';
            //incrementa string na label
            lbl_msg.Text += caracter.ToString();
            bool decisao = true;
        }
    }
}

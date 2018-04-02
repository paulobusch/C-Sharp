﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace PastasArquivos
{
    public partial class Form1 : Form
    {
        string pasta_trabalho = @"C:\temp";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            //verifica se a pasta existe
            if (!Directory.Exists(pasta_trabalho))
            {
                //cria diretório
                Directory.CreateDirectory(pasta_trabalho);
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ciclos_repeticao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            /*
            for (int i=0;i<=100;i+=5)
            {
                lst_ciclos.Items.Add("Linha: " + i);
            }
            */
            int vezes = 0;
            while (vezes<=100)
            {
                lst_ciclos.Items.Add(vezes++);
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CaixaDialogo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            //MessageBox
            MessageBox.Show("Uma mensagem para exibição");

            //titulo, botões, icone
            MessageBox.Show("Mensagem",
                              "Titulo",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
           */

            //caixa com resultado
            if(MessageBox.Show("Deseja sair da aplicação?",
                            "Sair",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

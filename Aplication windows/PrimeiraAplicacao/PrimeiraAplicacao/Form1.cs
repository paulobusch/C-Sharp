﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrimeiraAplicacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_clique_Click(object sender, EventArgs e)
        {
            #region codigo com nome alterado
            
            #endregion

            #region nova regiao de codigo

            #endregion

            //altera texto do label
            lbl_texto.Text = "Olá, mundo";
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            //System.Windows.Forms.Application.Exit();
            Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Formulários
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

        private void btn_1_Click(object sender, EventArgs e)
        {
            frmUm formulario = new frmUm(txt_nome.Text);
            formulario.ShowDialog();//ShowDialog() - Prioriza janeja
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            frmDois formulario = new frmDois();
            formulario.ShowDialog();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            Application.Exit();//fecha tudo
        }
    }
}

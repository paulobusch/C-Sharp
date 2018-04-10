using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AgendaSQL
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            //apresenta versão do software
            lbl_versao.Text = cl_vars.versao;
        }

        private void btn_ver_tudo_Click(object sender, EventArgs e)
        {

        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            //pergunta se deseja sair
            if (MessageBox.Show("Deseja sair?","SAIR",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
                return;
            //sai de programa
            Application.Exit();
        }
    }
}

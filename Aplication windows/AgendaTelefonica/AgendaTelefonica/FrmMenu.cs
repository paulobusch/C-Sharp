using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AgendaTelefonica
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            //apresenta versão do programa
            lbl_versao.Text = cl_geral.versao;

            //carrega contatos
            cl_geral.ConstriListaContatos();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //abre quadro para registro
            frmInserirEditar formulario = new frmInserirEditar();
            formulario.ShowDialog();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            //sair da aplicação- pergunta
            if (MessageBox.Show("Deseja sair da aplicação?", "SAIR", MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
                return;
            Application.Exit();
        }
    }
}

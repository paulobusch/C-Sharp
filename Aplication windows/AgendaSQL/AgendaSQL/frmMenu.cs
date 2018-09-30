using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
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
            frmResultados f = new frmResultados();
            f.ShowDialog();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            //pergunta se deseja sair
            if (MessageBox.Show("Deseja sair?","SAIR",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
                return;
            //sai de programa
            Application.Exit();
        }

        private void btn_adicionar_Click(object sender, EventArgs e)
        {
            //adiciona novos registros
            frmAdicionarEditar f = new frmAdicionarEditar();
            f.ShowDialog();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            //abre quadro para iniciar a pesquisa
            frmPesquisa f = new frmPesquisa();
            f.ShowDialog();

            //executa pesquisa
            if (f.cancelado)
            {
                f.Dispose();
                return;
            }

            //exibe resultados
            frmResultados r = new frmResultados(f.texto_pesquisa);
            r.ShowDialog();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja apagar tudo?",
                "ATENÇÃO",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning) == DialogResult.No)
                return;

            //elimina todos os registros
            SqlCeConnection conexao = new SqlCeConnection("Data Source = " + cl_vars.baseDados);
            conexao.Open();

            SqlCeCommand comando = new SqlCeCommand();
            comando.CommandText = "DELETE FROM contatos";
            comando.Connection = conexao;

            comando.ExecuteNonQuery();

            conexao.Dispose();
            MessageBox.Show("Todos os contatos foram apagados com sucesso");
        }
    }
}

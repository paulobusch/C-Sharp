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
    public partial class frmResultados : Form
    {
        public frmResultados()
        {
            InitializeComponent();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmResultados_Load(object sender, EventArgs e)
        {
            constroiGrid();
        }

        private void constroiGrid()
        {
            //constri grid de registros

            //ligar a base de dados
            SqlCeConnection conexao = new SqlCeConnection("Data Source = " + cl_vars.baseDados);
            conexao.Open();

            SqlCeDataAdapter adaptador = new SqlCeDataAdapter(
                "SELECT nome AS  Nome, telefone AS Telefone FROM contatos",
                conexao
                );
            DataTable dados = new DataTable();
            adaptador.Fill(dados);
            grid_resultados.DataSource = dados;

            conexao.Close();
        }
    }
}

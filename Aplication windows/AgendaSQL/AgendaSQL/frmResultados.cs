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
        int id_contato;
        string item_pesquisa;

        public frmResultados(string item_pesquisa = "")
        {
            InitializeComponent();
            this.item_pesquisa = item_pesquisa;
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

            string query = "SELECT id_contato, nome AS  Nome, telefone AS Telefone FROM contatos order by nome asc";
            if (item_pesquisa != "")
            {
                query = "SELECT id_contato, nome AS Nome, telefone AS Telefone FROM contatos " +
                    "WHERE nome LIKE @item OR telefone LIKE @item " +
                    "order by nome asc";
            }

            SqlCeCommand comando = new SqlCeCommand();
            comando.Parameters.AddWithValue("@item","%" + item_pesquisa + "%");
            comando.CommandText = query;
            comando.Connection = conexao;

            SqlCeDataAdapter adaptador = new SqlCeDataAdapter(query, conexao);
            adaptador.SelectCommand = comando;
            DataTable dados = new DataTable();
            adaptador.Fill(dados);
            grid_resultados.DataSource = dados;

            conexao.Close();

            //apresenta o número de registros
            lbl_resultados.Text = "Resultados: " + grid_resultados.RowCount;

            //esconde colunas
            grid_resultados.Columns["id_contato"].Visible = false;

            //altera dimensões das colunas
            grid_resultados.Columns["Nome"].Width = calcLargura(60);
            grid_resultados.Columns["Telefone"].Width = calcLargura(40);

            //desabilita controles
            btn_apagar.Enabled = false;
            btn_editar.Enabled = false;
        }

        private void grid_resultados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id_contato = Convert.ToInt16(grid_resultados.Rows[e.RowIndex].Cells["id_contato"].Value);
            btn_apagar.Enabled = true;
            btn_editar.Enabled = true;
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            //apaga registro
            SqlCeConnection conexao = new SqlCeConnection("Data Source = " + cl_vars.baseDados);
            conexao.Open();

            SqlCeCommand comando = new SqlCeCommand(
                "DELETE FROM contatos WHERE id_contato = " + id_contato,
                conexao);
            comando.ExecuteNonQuery();

            //fecha interação
            comando.Dispose();
            conexao.Dispose();

            //reconstri a grid
            constroiGrid();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            //edita o registro selecionado
            frmAdicionarEditar f = new frmAdicionarEditar(id_contato);
            f.ShowDialog();

            constroiGrid();
        }

        private void btn_ver_tudo_Click(object sender, EventArgs e)
        {
            //volta a apresentar todos os registros de contatos
            item_pesquisa = "";
            constroiGrid();
        }

        private int calcLargura(int porcent)
        {
            //regra de 3 para dimensionar grid
            int larguraGrid = grid_resultados.Width - 20;
            return (larguraGrid * porcent) / 100;
        }
    }
}

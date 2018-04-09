using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace LigacaoBaseDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_conectar_Click(object sender, EventArgs e)
        {
            //ligar
            SqlCeConnection conexao = new SqlCeConnection(@"Data Source=C:\Users\paulo\Desktop\Projetos\C#\SQL Database\teste.sdf");
            conexao.Open();

            //executar consulta
            DataTable dados = new DataTable();
            SqlCeDataAdapter operario = new SqlCeDataAdapter("SELECT * FROM Filmes", conexao);
            operario.Fill(dados);

            //fechar base de dados
            conexao.Close();


            //apresentar resultados
            //DataRow linhas = dados.Rows[0];
            //linhas["Diretor"];
            foreach (DataRow linha in dados.Rows)
            {
                lst_dados.Items.Add(linha["Titulo"].ToString()
                          + " - " + linha["Diretor"].ToString()
                          + " - " + linha["Ano"].ToString());
            }
        }
    }
}

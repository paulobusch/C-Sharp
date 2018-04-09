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
            try
            {
                //buscar todos os dados da tabela
                SqlCeConnection conexao = new SqlCeConnection(@"Data Source=C:\Users\paulo\Desktop\Projetos\C#\SQL Database\" + txt_base.Text + ".sdf");
                conexao.Open();

                DataTable dados = new DataTable();
                SqlCeDataAdapter operario = new SqlCeDataAdapter("SELECT * FROM pessoas", conexao);
                operario.Fill(dados);

                conexao.Close();

                //apresenta dados
                lst_dados.Items.Clear();
                foreach (DataRow linha in dados.Rows)
                {
                    lst_dados.Items.Add(linha["nome"] + " - " +
                                        linha["morada"] + " - " +
                                        linha["telefone"]);
                }
            }
            catch
            {
                lst_dados.Items.Clear();
                MessageBox.Show("Aconteceu um erro!");
            }
        }
    }
}
    
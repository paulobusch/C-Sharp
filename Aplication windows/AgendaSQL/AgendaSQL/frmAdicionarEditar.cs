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
    public partial class frmAdicionarEditar : Form
    {
        int id_contato;
        bool editar;

        public frmAdicionarEditar(int id_contato = -1)
        {
            InitializeComponent();
            this.id_contato = id_contato;

            //define se edita ou adiciona
            editar = !(id_contato == -1);
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            SqlCeConnection conexao = new SqlCeConnection("Data Source = " + cl_vars.baseDados);
            conexao.Open();

            // grava ou edita registro existente
            #region VERIFICAÇÕES
            //verifica se os campos estão preenchidos
            if(txt_nome.Text == "" || txt_telefone.Text == "")
            {
                MessageBox.Show("Falta preencher algum campo!");
                return;
            }
            #endregion

            #region NOVO CONTATO
            if (!editar)
            {
                //buscar o id disponível
                SqlCeDataAdapter adaptador = new SqlCeDataAdapter("SELECT MAX(id_contato) AS MAX_ID FROM contatos",conexao);
                DataTable dados = new DataTable();
                adaptador.Fill(dados);

                //verifica se o valor é nulo
                if (!DBNull.Value.Equals(dados.Rows[0][0]))
                {
                    id_contato = Convert.ToInt16(dados.Rows[0][0]);
                }
                id_contato++;

                //grava o novo contato na base de dados
                SqlCeCommand comando = new SqlCeCommand();
                comando.Connection = conexao;

                //parâmetros
                comando.Parameters.AddWithValue("@id_contato",id_contato);
                comando.Parameters.AddWithValue("@nome",txt_nome.Text);
                comando.Parameters.AddWithValue("@telefone",txt_telefone.Text);
                comando.Parameters.AddWithValue("@atualizado",DateTime.Now);

                //texto da query
                comando.CommandText = "INSERT INTO contatos VALUES(" +
                    "@id_contato, @nome, @telefone, @atualizado)";

                comando.ExecuteNonQuery();

                //fecha interação
                comando.Dispose();
                conexao.Dispose();

                MessageBox.Show("Contato adicionado com sucesso!");
                //comando.CommandText = 
                //    "INSERT INTO contatos VALUES" +
                //    "(" + id_contato +
                //    ",'" + txt_nome.Text +
                //    "','" + txt_telefone.Text +
                //    "','" + DateTime.Now + 
                //    "')";
            }
            #endregion

            #region EDITAR CONTATO
            else
            {

            }
            #endregion
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            //fecha o quadro
            this.Close();
        }

        private void frmAdicionarEditar_Load(object sender, EventArgs e)
        {
            //apresenta dados do contato se necessário
            if (editar)
                ApresentaContato();
        }

        private void ApresentaContato()
        {
            //apresenta contato a ser editado

        }
    }
}

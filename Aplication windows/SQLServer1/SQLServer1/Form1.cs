using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SQLServer1
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

        private void button1_Click(object sender, EventArgs e)
        {
            //criar uma tabela na base de dados
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Server = DESKTOP-LUN8L08\MEUSERVIDOR; Database = SQL_TESTES; Trusted_connection = True";
            conexao.Open();

            MessageBox.Show(conexao.State.ToString());
            conexao.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //criar a tabela contatos
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Server = DESKTOP-LUN8L08\MEUSERVIDOR; Database = SQL_TESTES; Trusted_connection = True";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;
            comando.CommandText = "CREATE TABLE contatos(" +
                                  "id_contato     int not null primary key," +
                                  "nome           nvarchar(50)," +
                                  "telefone       nvarchar(20)," +
                                  "atualizacao    datetime" +
                                  ")";
            comando.ExecuteNonQuery();
            MessageBox.Show("Tabela contatos criada com sucesso!");
            
            conexao.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //adiciona registro
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Server = DESKTOP-LUN8L08\MEUSERVIDOR; Database = SQL_TESTES; Trusted_connection = True";
            conexao.Open();

            SqlCommand comando = new SqlCommand();
            comando.Connection = conexao;

            //Parametros
            comando.Parameters.AddWithValue("@id_contato", 0);
            comando.Parameters.AddWithValue("@nome", "Paulo Ricardo Busch");
            comando.Parameters.AddWithValue("@telefone", "(41)99785-9624");
            comando.Parameters.AddWithValue("@atualizacao", DateTime.Now);

            comando.CommandText = "INSERT INTO contatos VALUES(" +
                "@id_contato," +
                "@nome," +
                "@telefone," +
                "@atualizacao" +
                ")";
            comando.ExecuteNonQuery();

            comando.Dispose();
            conexao.Dispose();

            MessageBox.Show("Registro adicionado com sucesso!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //leitura da base de dados
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Server = DESKTOP-LUN8L08\MEUSERVIDOR; Database = SQL_TESTES; Trusted_connection = True";
            conexao.Open();

            SqlDataAdapter adaptador = new SqlDataAdapter("SELECT * FROM contatos", conexao);
            DataTable dados = new DataTable();
            adaptador.Fill(dados);

            adaptador.Dispose();
            conexao.Dispose();

            foreach (DataRow linha in dados.Rows)
            {
                MessageBox.Show(linha["nome"] + " -> " + linha["telefone"]);
            }
        }
    }
}

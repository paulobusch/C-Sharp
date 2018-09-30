using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SQLite;
using System.Windows.Forms;

namespace SQLite_01
{
    public partial class Form1 : Form
    {
        public string dados = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\dados.db; Version=3;";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //criar a base de dados
            //SQLiteConnection.CreateFile(dados);

            //estabelece conexao
            SQLiteConnection conexao = new SQLiteConnection();
            conexao.ConnectionString = @"Data Source = " + dados;
            conexao.Open();

            //criar tabela na base
            string query = "CREATE TABLE contatos(" +
                "id_contato     int," +
                "nome           varchar(50)," +
                "telefone       varchar(20)" +
                ")";
            SQLiteCommand comando = new SQLiteCommand(query,conexao);
            comando.ExecuteNonQuery();

            comando.Dispose();
            conexao.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //estabelece conexao
            SQLiteConnection conexao = new SQLiteConnection();
            conexao.ConnectionString = @"Data Source = " + dados;
            conexao.Open();

            string query = "INSERT INTO contatos VALUES(2,'Rodrigo Costa','(43)68465-9624')";
            SQLiteCommand comando = new SQLiteCommand(query,conexao);
            comando.ExecuteNonQuery();

            comando.Dispose();
            conexao.Dispose();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SQLiteConnection conexao = new SQLiteConnection(@"Data Source = " + dados);
            conexao.Open();

            string query = "SELECT nome AS Nome, telefone AS Telefone FROM contatos";
            SQLiteDataAdapter comando = new SQLiteDataAdapter(query,conexao);
            DataTable tabela = new DataTable();
            comando.Fill(tabela);

            //fecha interação
            comando.Dispose();
            conexao.Dispose();

            foreach (DataRow linha in tabela.Rows)
            {
                lst_dados.Items.Add(linha["Nome"] + " - " + linha["Telefone"]);
            }
        }
    }
}

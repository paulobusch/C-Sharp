using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlServerCe;

namespace AgendaSQL
{
    public static partial class cl_vars
    {
        public static string versao = "v.1.0.0;
        public static string pastaDados;
        public static string baseDados;

        public static void Iniciar()
        {
            //inicia aplicação
            pastaDados = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\AgendaSQL\";

            //verifica se a pasta de dados existe
            if (!Directory.Exists(pastaDados))
                Directory.CreateDirectory(pastaDados);

            //verifica se a base de dados existe
            //adiciona senha a base de dados
            baseDados = pastaDados + @"dados.sdf; Password = '95273101'";
            if (!File.Exists(pastaDados + @"dados.sdf"))
                criarBaseDados();    
        }

        public static void criarBaseDados()
        {
            //cria base de dados
            SqlCeEngine motor = new SqlCeEngine("Data Source = " + baseDados);
            motor.CreateDatabase();

            //inserir tabelas
            SqlCeConnection conexao = new SqlCeConnection();
            conexao.ConnectionString = "Data Source = " + baseDados;
            conexao.Open();

            SqlCeCommand comando = new SqlCeCommand();
            comando.CommandText = 
                "CREATE TABLE contatos(" +
                "id_contato         int not null primary key," +
                "nome               nvarchar(50)," +
                "telefone           nvarchar(20)," +
                "atualizado         datetime" +
                ")";
            comando.Connection = conexao;

            //executa query
            comando.ExecuteNonQuery();

            //finaliza interação
            comando.Dispose();
            conexao.Close();
        }
    }
}

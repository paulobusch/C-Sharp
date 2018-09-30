using System;
using System.Data.SqlClient;

namespace ConexaoBd
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection conexao = new SqlConnection(@"Data Source = DESKTOP-LUN8L08\SQLEXPRESS; Integrated Security = SSPI; Initial Catalog = BDClinica");
            conexao.Open();
            string query = "SELECT * FROM usuarios";
            SqlCommand comando = new SqlCommand(query,conexao);
            //obten dados
            SqlDataReader dados = comando.ExecuteReader();
            while (dados.Read())
            {
                Console.WriteLine("Id: {0}, Nome: {1}, Cargo: {2}, Data: {3:dd/MM/yyyy}",dados["usuario_id"], dados["nome"], dados["cargo"], dados["data"]);
            }
            Console.ReadKey();
            conexao.Close();
        }
    }
}

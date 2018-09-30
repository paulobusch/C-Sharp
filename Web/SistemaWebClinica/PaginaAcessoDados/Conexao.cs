using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PaginaAcessoDados
{
    class Conexao
    {
        #region "PADRAO SINGLETON"
        public static Conexao conexao = null;
        private Conexao() { }
        public static Conexao getIntacia()
        {
            if (conexao == null)
            {
                conexao = new Conexao();
            }
            return conexao;
        }
        #endregion

        public SqlConnection ConexaoDB()
        {
            SqlConnection conexao = new SqlConnection();
            conexao.ConnectionString = @"Data Source=DESKTOP-LUN8L08\SQLEXPRESS; Initial Catalog=DBClinica; User ID=sa; Password=95273101";
            return conexao;
        }
    }
}

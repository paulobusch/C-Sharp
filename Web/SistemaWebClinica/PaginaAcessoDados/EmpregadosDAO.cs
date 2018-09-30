using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaginaEntidades;
using System.Data.SqlClient;
using System.Data;

namespace PaginaAcessoDados
{
    public class EmpregadosDAO
    {
        #region "PADRAO SINGLETON"
        private static EmpregadosDAO daoEmpregado = null;
        EmpregadosDAO() { }
        public static EmpregadosDAO getInstancia()
        {
            if(daoEmpregado == null)
            {
                daoEmpregado = new EmpregadosDAO();
            }
            return daoEmpregado;
        }
        #endregion

        public Empregado AcessoSistema(string user, string pass)
        {
            SqlConnection conexao = null;
            SqlCommand comando = null;
            Empregado objEmpregado = null;
            SqlDataReader Leitura = null;
            try
            {
                conexao = Conexao.getIntacia().ConexaoDB();
                comando = new SqlCommand("spAcessoSistema",conexao);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@prmUser",user);
                comando.Parameters.AddWithValue("@prmPass",pass);
                //procedimento da base de dados
                //comando.CommandText = "SELECT * FROM Empleado WHERE usuario = @prmUser AND clave = prmPass";
                conexao.Open();

                Leitura = comando.ExecuteReader();
                if (Leitura.Read())
                {
                    objEmpregado = new Empregado();
                    objEmpregado.ID = Convert.ToInt32(Leitura["idEmpleado"].ToString());
                    objEmpregado.Usuario = Leitura["usuario"].ToString();
                    objEmpregado.Senha = Leitura["clave"].ToString();

                    /*
                    objEmpregado.Nome = Leitura["nombres"].ToString();
                    objEmpregado.ApPaterno = Leitura["apPaterno"].ToString();
                    objEmpregado.ApMaterno = Leitura["apMaterno"].ToString();
                    objEmpregado.NroDocumento = Leitura["nroDocumento"].ToString();
                    objEmpregado.Estado = true;
                    */
                }
            }catch(Exception e)
            {
                objEmpregado = null;
                throw e;  
            }
            finally
            {
                conexao.Close();
            }
            return objEmpregado;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PaginaEntidades;
using System.Data;
using System.Data.SqlClient;

namespace PaginaAcessoDados
{
    public class PacienteDAO
    {
        #region "PADRAO SINGLETON"
        private static PacienteDAO objEmpregado = null;
        private PacienteDAO() { }
        public static PacienteDAO getInstance()
        {
            if (objEmpregado == null)
            {
                objEmpregado = new PacienteDAO();
            }
            return objEmpregado;
        }
        #endregion

        public bool RegistrarPaciente(Paciente objPaciente)
        {
            SqlConnection conexao = null;
            SqlCommand comando = null;
            bool resposta = false;
            try
            {
                conexao = Conexao.getIntacia().ConexaoDB();
                comando = new SqlCommand("spRegistrarPaciente",conexao);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@prmNome",objPaciente.Nome);
                comando.Parameters.AddWithValue("@prmAP",objPaciente.NPaterno);
                comando.Parameters.AddWithValue("@prmAM",objPaciente.NMaterno);
                comando.Parameters.AddWithValue("@prmIdade",objPaciente.Idade);
                comando.Parameters.AddWithValue("@prmSexo",objPaciente.Sexo);
                comando.Parameters.AddWithValue("@prmNDocumento",objPaciente.NDocumento);
                comando.Parameters.AddWithValue("@prmDirecao",objPaciente.Direcao);
                comando.Parameters.AddWithValue("@prmTelefone",objPaciente.Telefone);
                comando.Parameters.AddWithValue("@prmEstado",objPaciente.Estado);

                conexao.Open();

                //retorna linhas afetadas
                int linhas = comando.ExecuteNonQuery();

                if (linhas > 0)
                    resposta = true;
                
            }catch(Exception e)
            {
                resposta = false;
                throw e;
            }
            finally
            {
                conexao.Close();
            }
            return resposta;
            
        }

        public bool ApagarPaciente(int id)
        {
            SqlConnection conexao = null;
            SqlCommand comando = null;
            bool ok = false;
            try
            {
                conexao = Conexao.getIntacia().ConexaoDB();
                comando = new SqlCommand("spApagarPaciente",conexao);
                comando.Parameters.AddWithValue("@prmIdPaciente", id);
                comando.CommandType = CommandType.StoredProcedure;

                conexao.Open();

                comando.ExecuteNonQuery();

                ok = true;
            }catch(Exception e)
            {
                ok = false;
                throw e;
            }
            finally
            {
                conexao.Close();
            }
            return ok;
        }

        public List<Paciente> listarPacientes()
        {
            List<Paciente> Lista = new List<Paciente>();
            SqlConnection conexao = null;
            SqlCommand comando = null;
            SqlDataReader Leitura = null;

            try
            {
                conexao = Conexao.getIntacia().ConexaoDB();
                comando = new SqlCommand("spListarPaciente",conexao);
                comando.CommandType = CommandType.StoredProcedure;

                conexao.Open();
                //obten dados
                Leitura = comando.ExecuteReader();

                
                //enquanto possui dados
                while (Leitura.Read())
                {
                    //criar objetos
                    Paciente objPaciente = new Paciente();
                    objPaciente.idPaciente = Convert.ToInt32(Leitura["idPaciente"].ToString());
                    objPaciente.Nome = Leitura["nombres"].ToString();
                    objPaciente.NPaterno = Leitura["apPaterno"].ToString();
                    objPaciente.NMaterno = Leitura["apMaterno"].ToString();
                    objPaciente.Idade = Convert.ToInt32(Leitura["edad"].ToString());
                    objPaciente.Sexo = Convert.ToChar(Leitura["sexo"].ToString());
                    objPaciente.NDocumento = Leitura["nroDocumento"].ToString();
                    objPaciente.Direcao = Leitura["direccion"].ToString();
                    objPaciente.Estado = true;

                    Lista.Add(objPaciente);
                }

                
                /*
                using (SqlDataReader Leitura = comando.ExecuteReader())
                {
                    //criar objetos
                    Paciente objPaciente = new Paciente();
                    objPaciente.idPaciente = Convert.ToInt32(Leitura["idPaciente"].ToString());
                    objPaciente.Nome = Leitura["nombres"].ToString();
                    objPaciente.NPaterno = Leitura["apPaterno"].ToString();
                    objPaciente.NMaterno = Leitura["apMaterno"].ToString();
                    objPaciente.Idade = Convert.ToInt32(Leitura["edad"].ToString());
                    objPaciente.Sexo = Convert.ToChar(Leitura["sexo"].ToString());
                    objPaciente.NDocumento = Leitura["nroDocumento"].ToString();
                    objPaciente.Direcao = Leitura["direccion"].ToString();
                    objPaciente.Estado = true;

                    Lista.Add(objPaciente);
                }
                */


            }catch(Exception e)
            {
                throw e;
            }
            finally
            {
                conexao.Close();
            }

            return Lista;
        }

        public bool Atualizar(Paciente objPaciente)
        {
            bool ok = false;
            SqlConnection conexao = null;
            SqlCommand comando = null;
            try
            {
                conexao = Conexao.getIntacia().ConexaoDB();
                comando = new SqlCommand("spAtualizarPaciente", conexao);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@prmidPaciente", objPaciente.idPaciente);
                comando.Parameters.AddWithValue("@prmidDirecao", objPaciente.Direcao);

                conexao.Open();

                comando.ExecuteNonQuery();

                ok = true;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                conexao.Close();
            }

            return ok;
        }
    }
}

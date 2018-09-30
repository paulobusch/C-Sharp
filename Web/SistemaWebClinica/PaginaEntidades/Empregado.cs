using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginaEntidades
{
    public class Empregado
    {
        public int ID { get; set; }
        public TipoEmpregado RTipoEmpregado { get; set; }
        public string Nome { get; set; }
        public string ApPaterno { get; set; }
        public string ApMaterno { get; set; }
        public string NroDocumento { get; set; }
        public bool Estado { get; set; }
        public string Imagem { get; set; }
        public string Usuario { get; set; }
        public string Senha { get; set; }

        public Empregado() { }

        public Empregado(int ID, TipoEmpregado RTipoEmpregado, string Nome, string ApPaterno, string ApMaterno, string NroDocumento, bool Estado, string Imagem, string Usuario, string Senha)
        {
            this.ID = ID;
            this.RTipoEmpregado = RTipoEmpregado;
            this.Nome = Nome;
            this.ApPaterno = ApPaterno;
            this.ApMaterno = ApMaterno;
            this.NroDocumento = NroDocumento;
            this.Estado = Estado;
            this.Imagem = Imagem;
            this.Usuario = Usuario;
            this.Senha = Senha;
        }
    }
}

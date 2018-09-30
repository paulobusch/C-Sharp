using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginaEntidades
{
    public class TipoEmpregado
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public bool Estado { get; set; }
        public TipoEmpregado()
        {

        }
        public TipoEmpregado(int ID, string Descricao, bool Estado)
        {
            this.ID = ID;
            this.Descricao = Descricao;
            this.Estado = Estado;
        }
    }
}

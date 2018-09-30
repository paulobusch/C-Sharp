using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginaEntidades
{
    class TipoEmpregado
    {
        public int ID { get; set; }
        public String Descricao { get; set; }
        public bool Estado { get; set; }
        public TipoEmpregado()
        {

        }
        public TipoEmpregado(int ID, String Descricao, bool Estado)
        {
            this.ID = ID;
            this.Descricao = Descricao;
            this.Estado = Estado;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaginaEntidades
{
    public class Paciente
    {
        public int idPaciente { get; set; }
        public string Nome { get; set; }
        public string NPaterno { get; set; }
        public string NMaterno { get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }
        public string NDocumento { get; set; }
        public string Direcao { get; set; }
        public string Telefone { get; set; }
        public bool Estado { get; set; }
        public string Imagem { get; set; }

        public Paciente() { }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    class pessoa
    {
        public string nome;
        public string apelido;

        public void IdentificarSe(){
            System.Windows.Forms.MessageBox.Show(ConstruirNome());
        }
        private string ConstruirNome(){
            string NomeCompleto = nome + " " + apelido;
            return NomeCompleto;
        }
    }
}

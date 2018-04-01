using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConstrutorOverloading
{
    class teste
    {
        string _nome;
        int _idade;

        public teste(string nome, int idade)
        {
            _nome = nome;
            _idade = idade;
        }

        public void Apresentar()
        {
            System.Windows.Forms.MessageBox.Show("Nome: " + _nome + " idade: " + _idade);
        }
        public void Apresentar(string separador)
        {
            System.Windows.Forms.MessageBox.Show(_nome + separador + _idade);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CamposPropriedades
{
    class teste
    {
        string _nome;
        int _idade;
        //definição de propriedade
        public string Nome { get; set; }
        public void Apresentar()
        {
            System.Windows.Forms.MessageBox.Show(Nome);
        }
    }
}

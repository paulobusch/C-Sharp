﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    class pessoa
    {
        public string nome;
        public int idade;
        public string corCabelo;
        public void Falar(){
            System.Windows.Forms.MessageBox.Show("Olá, meu nome é " + nome);
        }
    }
}

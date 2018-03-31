using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConstantesEstruturas
{
    public partial class Form1 : Form
    {
        struct estrutura_pessoa
        {
            public string nome;
            public string sobrenome;
        }
        public Form1()
        {            
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            normal objeto1 = new normal();
            Console.WriteLine("Nome: " + objeto1.Nome);
            Console.WriteLine("Nome: " + estatica.Nome);

            pessoa p1 = new pessoa();
            p1.Nome = "Paulo Ricardo";
            p1.Nome = "Busch";

            estrutura_pessoa p2 = new estrutura_pessoa() { nome = "Paulo Ricardo", sobrenome = "Busch"};
            Console.WriteLine(p2.nome + " " + p2.sobrenome);
        }
    }
}

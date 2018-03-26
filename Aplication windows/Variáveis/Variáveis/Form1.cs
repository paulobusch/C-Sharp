using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Variáveis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_executa_Click(object sender, EventArgs e)
        {
            //criar variável - tipo
            string nome = "Paulo";
            int idade = 18;
            lbl_msg.Text = "Nome: " + nome + "\nIdade: " + idade;
        }
    }
}

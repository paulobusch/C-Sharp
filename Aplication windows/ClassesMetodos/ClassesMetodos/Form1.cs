using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassesMetodos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            cl_matematica calculadora = new cl_matematica();
            int v1 = 15, v2 = 5;
            lbl_texto.Text = "Soma de " + v1 + " e " + v2 + " é " + calculadora.Adicao(v1,v2).ToString() + "\n";
            lbl_texto.Text += "Subtração de " + v1 + " e " + v2 + " é " + calculadora.Subtracao(v1,v2).ToString() + "\n";
            lbl_texto.Text += "Multiplicação de " + v1 + " e " + v2 + " é " + calculadora.Multiplicacao(v1,v2).ToString() + "\n";
            lbl_texto.Text += "Divisão de " + v1 + " e " + v2 + " é " + calculadora.Divisao(v1,v2).ToString() + "\n";
        }
    }
}

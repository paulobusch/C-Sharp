using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            int n1, n2, index = 0;
            string operacao;

            string algoritmo = txt_operacao.Text;

            //entrada: 123+567
            string sinais = "+-*/";
            foreach(char caracter in algoritmo)
            {
                foreach (char sinal in sinais)
                {
                    if(caracter == sinal)
                    {
                        //define n1 e n2
                        n1 = int.Parse(algoritmo.Substring(0, index));
                        n2 = int.Parse(algoritmo.Substring(index, algoritmo.Length));
                        MessageBox.Show(n1 + " - " + n2);
                    }
                }
                index++;
            }
        }
    }
}

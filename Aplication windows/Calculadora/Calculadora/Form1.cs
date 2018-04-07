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
            int n1, n2, resultado = 0, index = 0;
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
                        operacao = caracter.ToString();
                        n2 = int.Parse(algoritmo.Substring(index + 1));//atribui ate o fim

                        //analiza operação a ser realizada
                        switch (operacao)
                        {
                            case "+":
                                resultado = n1 + n2;
                                break;
                            case "-":
                                resultado = n1 - n2;
                                break;
                            case "*":
                                resultado = n1 * n2;
                                break;
                            case "/":
                                resultado = n1 / n2;
                                break;
                        }

                        //apresentação do resultado final
                        MessageBox.Show(algoritmo + " = " + resultado);

                        //finaliza for uma vez que terminou os calculos
                        return;
                    }
                }
                index++;
            }
            MessageBox.Show("Nenhuma operação solicitada!!");
        }
    }
}

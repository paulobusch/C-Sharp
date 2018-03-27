using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Condições
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
                
        private void btn_executar_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(txt_box.Text);
            /*
            if (valor < 5)
            {
                lbl_executar.Text = "valor < 5";
            }
            else if (valor < 10)
            {
                lbl_executar.Text = "valor < 10";
            }
            else if (valor < 15)
            {
                lbl_executar.Text = "valor < 15";
            }
            else
            {
                lbl_executar.Text = "Nenhuma das opções";
            }
            */
            switch (valor)
            {
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                    lbl_executar.Text = "Primeiro caso";
                    break;
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                    lbl_executar.Text = "Segunda opção";
                    break;
                default:
                    lbl_executar.Text = "Nenhum caso";
                    break;
            }
        }
    }
}

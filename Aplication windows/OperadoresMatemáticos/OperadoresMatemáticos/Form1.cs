using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OperadoresMatemáticos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_calcula_Click(object sender, EventArgs e)
        {
            float n1 = float.Parse(txt_parcela1.Text);
            float n2 = float.Parse(txt_parcela2.Text);
            float resultado;

            //adição (+)
            resultado = n1 + n2;

            //subtração (-)
            resultado = n1 - n2;

            //multiplicação (*)
            resultado = n1 * n2;

            //divisão (/)
            resultado = n1 / n2;

            //resto   (%)
            resultado = n1 % n2;

            lbl_resultado.Text = resultado.ToString();
        }
    }
}

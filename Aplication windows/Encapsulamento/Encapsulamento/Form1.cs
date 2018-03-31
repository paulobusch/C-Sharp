using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Encapsulamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //apresenta o preço final do produto
            cl_calculo calculadora = new cl_calculo();
            int tipo_p;
            if(rd_1.Checked){
                tipo_p = 1;
            }else if (rd_2.Checked){
                tipo_p = 2;
            }else{
                tipo_p = 3;
            }
            MessageBox.Show("Preço final = " + calculadora.CalcPreco(Convert.ToInt16(txt_preco.Text), tipo_p));
        }
    }
}

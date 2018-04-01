using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DataHora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_resultado_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(txt_dia.Text);
            int mes = int.Parse(txt_mes.Text);
            int ano = int.Parse(txt_ano.Text);

            DateTime data = new DateTime(ano,mes,dia);
            lbl_resultado.Text = "Dia da semana" + data.DayOfWeek;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Strings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            string nome = "Paulo Busch";
            string sobrenome = "Ricardo ";
            string nome_completo = nome.Insert(6,sobrenome);
            lbl_texto.Text = nome_completo;
        }
    }
}

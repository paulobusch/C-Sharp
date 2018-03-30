using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            pessoa p1 = new pessoa();
            p1.nome = "Paulo";
            p1.Falar();
            pessoa p2 = new pessoa();
            p2.nome = "Carlos";
            p2.Falar();
        }
    }
}

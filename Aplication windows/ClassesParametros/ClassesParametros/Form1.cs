using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClassesParametros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            teste objeto = new teste();
            int v = 10;
            objeto.Diminuir(ref v);
            lbl_texto.Text = v.ToString();
        }
    }
}

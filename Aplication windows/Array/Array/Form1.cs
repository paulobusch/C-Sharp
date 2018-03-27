using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Array
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            /*
            int[] valores;
            valores = new int[5];
            valores[0] = 10;
            valores[1] = 10;
            valores[2] = 10;
            valores[3] = 10;
            valores[4] = 10;
            */
            int[] valores = new int[]{10,20,30,40,50};
            lst_array.Items.Add(valores[0]);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Menus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void mn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //mn_open.Enabled = false;//-desabilita opção de menu
            mn_cmb.Items.Add("Valor1");
            mn_cmb.Items.Add("Valor2");
            mn_cmb.Items.Add("Valor3");
        }

        private void mn_open_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OPEN!");
        }

        private void mn_cmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_resultado.Text = mn_cmb.Text;
            if (mn_cmb.Text == "Valor 1")
                MessageBox.Show("Valor 1 selecionado");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mn_cmb.Items.Add("Valor 1");
            mn_cmb.Items.Add("Valor 2");
            mn_cmb.Items.Add("Valor 3");
            mn_cmb.Items.Add("Valor 4");
            mn_cmb.Items.Add("Valor 5");
        }
    }
}

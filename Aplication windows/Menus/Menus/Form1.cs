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

        }

        private void mn_open_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OPEN!");
        }
    }
}

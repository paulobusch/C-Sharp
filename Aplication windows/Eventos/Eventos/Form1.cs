using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Eventos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl_a_Click(object sender, EventArgs e)
        {
            
        }

        private void lbl_a_MouseEnter(object sender, EventArgs e)
        {
            lbl_a.BackColor = Color.Yellow;
        }

        private void lbl_a_MouseLeave(object sender, EventArgs e)
        {
            lbl_a.BackColor = Color.Transparent;
        }

        private void lbl_a_MouseDown(object sender, MouseEventArgs e)
        {
            lbl_a.BackColor = Color.Red;
        }

        private void lbl_a_MouseUp(object sender, MouseEventArgs e)
        {
            lbl_a.BackColor = Color.Yellow;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lbl_a.Text = textBox1.Text;
        }
    }
}

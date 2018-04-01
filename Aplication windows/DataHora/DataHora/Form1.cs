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
            DateTime data = new DateTime(2000,02,01);
            lbl_resultado.Text = data.DayOfYear.ToString();
        }
    }
}

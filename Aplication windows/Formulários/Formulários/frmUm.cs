using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Formulários
{
    public partial class frmUm : Form
    {
        public frmUm(string texto)
        {
            InitializeComponent();
            lbl_resultado_final.Text = texto;
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();//fecha o formulário
        }
    }
}

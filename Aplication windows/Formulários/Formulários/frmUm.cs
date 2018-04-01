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
        public frmUm()
        {
            InitializeComponent();
            lbl_resultado_final.Text = cl_geral.nome;//captura valor da classe geral
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();//fecha o formulário
        }

        private void btn_tranf_Click(object sender, EventArgs e)
        {
            lbl_recebe.Text = cl_geral.nome;
        }
    }
}

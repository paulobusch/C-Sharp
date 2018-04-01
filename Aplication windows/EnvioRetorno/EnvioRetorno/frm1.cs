using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnvioRetorno
{
    public partial class frm1 : Form
    {
        string nome = null;

        public frm1()
        {
            InitializeComponent();
        }

        private void btn_avancar_Click(object sender, EventArgs e)
        {
            //define nome
            if (lbl_texto.Text != "")
                nome = lbl_texto.Text;
            frm2 formulario = new frm2(nome);
            formulario.ShowDialog();
            if (formulario.nome != null)
                lbl_texto.Text = formulario.nome;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AgendaTelefonica
{
    public partial class frmTexto : Form
    {
        //propriedade de controle
        public bool cancelado { get; set; }
        public string texto { get; set; }

        public frmTexto()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            cancelado = true;
            this.Close();
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            if (txt_texto.Text == "")
                return;
            //define texto e fecha quadro
            texto = txt_texto.Text;
            cancelado = false;
            this.Close();
        }

        private void txt_texto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
                btn_pesquisar_Click(btn_pesquisar, EventArgs.Empty);
        }
    }
}

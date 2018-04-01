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
    public partial class frm2 : Form
    {
        public string nome { get; set; }

        public frm2(string nome)
        {
            InitializeComponent();
            txt_nome.Text = nome;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            //definir o valor a retornar
            if (txt_nome.Text == "")
                nome = null;
            else
                nome = txt_nome.Text;
            this.Close();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            //fechar o quadro e não retornar valor
            nome = null;
            this.Close();
        }
    }
}

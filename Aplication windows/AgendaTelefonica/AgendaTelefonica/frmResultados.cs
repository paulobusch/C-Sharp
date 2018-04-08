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
    public partial class frmResultados : Form
    {
        string texto;
        public frmResultados(string texto)
        {
            InitializeComponent();
            this.texto = texto.ToUpper();
        }

        private void frmResultados_Load(object sender, EventArgs e)
        {
            //chama metodo para pesquisa
            ExecutaPesquisa();
        }

        private void ExecutaPesquisa()
        {
            //realiza pesquisa e apresenta dados
            List<cl_contato> lista_resultados = new List<cl_contato>();

            foreach (cl_contato contato in cl_geral.LISTA_CONTATOS)
            {
                //instrução contains para busca
                if (contato.nome.ToUpper().Contains(texto) ||
                    contato.numero.Contains(texto))
                {
                    lista_resultados.Add(contato);
                }
            }

            //apresentar os resultados na lista
            lst_pesquisa.Items.Clear();
            foreach (cl_contato contato in lista_resultados)
            {
                lst_pesquisa.Items.Add(contato.nome + " (" + contato.numero + ")");
            }
            lbl_num_registros.Text = "Registros: " + lst_pesquisa.Items.Count;
        }
        
        private void btn_fechar_Click(object sender, EventArgs e)
        {
            //fecha o quadro
            this.Close();
        }

        private void btn_nova_pesquisa_Click(object sender, EventArgs e)
        {
            //pedir novo texto
            frmTexto f = new frmTexto();
            f.ShowDialog();

            //quando o quadro é fechado
            if (f.cancelado)
                return;

            //mostra pesquisa
            texto = f.texto.ToUpper();
            ExecutaPesquisa();
        }
    }
}

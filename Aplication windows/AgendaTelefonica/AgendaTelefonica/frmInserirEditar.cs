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
    public partial class frmInserirEditar : Form
    {
        public frmInserirEditar()
        {
            InitializeComponent();
            ConstroiLista();
        }

        private void btn_fechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConstroiLista()
        {
            //adiciona a lista os contatos
            lst_contatos.Items.Clear();
            foreach (cl_contato contato in cl_geral.LISTA_CONTATOS)
            {
                lst_contatos.Items.Add(contato.nome + " (" + contato.numero + ")");
            }

            //atualiza número de registros
            lbl_num_registros.Text = "Registros: " + lst_contatos.Items.Count;
        }

        private void btn_gravar_Click(object sender, EventArgs e)
        {
            //insere um novo registro na lista

            //verifica se campos estão preenchidos
            if (txt_nome.Text == "" || txt_num.Text == "")
            {
                MessageBox.Show("Preencha todos os campos!");
                return;
            }

            //verifica se existe registro igual
            foreach(cl_contato contato in cl_geral.LISTA_CONTATOS)
            {
                if(contato.nome == txt_nome.Text && contato.numero == txt_num.Text)
                {
                    MessageBox.Show("ERRO! Esse registro já existe.");
                    return;
                }
            }
            
            //gravar novo registro
            cl_geral.GravarNovoRegistro(txt_nome.Text, txt_num.Text);

            //atualiza lista
            ConstroiLista();

            //limpa campos
            txt_nome.Text = "";
            txt_num.Text = "";

            txt_nome.Focus();
        }
    }
}

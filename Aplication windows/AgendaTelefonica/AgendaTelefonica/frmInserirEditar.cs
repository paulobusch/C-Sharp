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

        int indice;
        bool editar = false;

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

            //impedir edição e eliminação de registro
            btn_apagar.Enabled = false;
            btn_editar.Enabled = false;
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

            //verifica chamada para edição
            if (editar)
            {
                //remove registro antigo
                //chama evento click para apagar registro
                btn_apagar_Click(btn_apagar,EventArgs.Empty);

                editar = false;
            }
        }

        private void frmInserirEditar_Load(object sender, EventArgs e)
        {

        }

        private void lst_contatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //seleciona um contato

            //verifica se indice é -1
            if (lst_contatos.SelectedIndex == -1)
                return;

            //seleciona um indice na lista
            indice = lst_contatos.SelectedIndex;
            btn_editar.Enabled = true;
            btn_apagar.Enabled = true;
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            //apaga o registro selecionado

            //elimina o item da lista
            cl_geral.LISTA_CONTATOS.RemoveAt(indice);

            //atualizar arquivo
            cl_geral.GravarArquivo();

            //reconstruir lista
            ConstroiLista();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            //chama registro na tela de edição
            cl_contato contato = new cl_contato();
            contato = cl_geral.LISTA_CONTATOS[indice];
            //mostra itens
            txt_nome.Text = contato.nome;
            txt_num.Text = contato.numero;

            //ativa chamada para edição
            editar = true;
        }
    }
}

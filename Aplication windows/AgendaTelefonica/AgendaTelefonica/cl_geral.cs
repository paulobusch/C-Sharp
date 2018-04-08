using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace AgendaTelefonica
{
    public static class cl_geral
    {
        public static string versao = "v 1.0.0";

        //lista de contatos
        public static List<cl_contato> LISTA_CONTATOS;

        //carrega lista de contatos
        public static void ConstriListaContatos()
        {
            //verificar se o arquivo existe
            string pasta_documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nome_arquivo = pasta_documentos + @"\arquivo_contatos.txt";
            //cria a lista vazia
            LISTA_CONTATOS = new List<cl_contato>();
            if (File.Exists(nome_arquivo))
            {
                StreamReader arquivo = new StreamReader(nome_arquivo, Encoding.Default);
                //carregar todos os contatos
                while (!arquivo.EndOfStream)
                {
                    //carrega nome
                    string nome = arquivo.ReadLine();
                    //carrega número
                    string numero = arquivo.ReadLine();

                    //adicionar a lista de contatos o contato carregado
                    cl_contato novo_contato = new cl_contato();
                    novo_contato.nome = nome;
                    novo_contato.numero = numero;

                    //inclui na lista
                    LISTA_CONTATOS.Add(novo_contato);
                }
                //fecha arquivo
                arquivo.Dispose();
            }
        }

        public static void GravarNovoRegistro(string _nome, string _numero)
        {
            //gravar um novo registro

            //gravar na lista
            cl_contato novo = new cl_contato();
            novo.nome = _nome;
            novo.numero = _numero;
            LISTA_CONTATOS.Add(novo);
            //LISTA_CONTATOS.Add(new cl_contato() { nome = _nome, numero = _numero});

            //atualiza o arquivo
            GravarArquivo();
        }

        public static void GravarArquivo(){
            string pasta_documentos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string nome_arquivo = pasta_documentos + @"\arquivo_contatos.txt";

            StreamWriter arquivo = new StreamWriter(nome_arquivo,false,Encoding.Default);
            //grava cada linha
            foreach (cl_contato contato in LISTA_CONTATOS) {
                arquivo.WriteLine(contato.nome);
                arquivo.WriteLine(contato.numero);
            }
            arquivo.Dispose();
        }
    }
}

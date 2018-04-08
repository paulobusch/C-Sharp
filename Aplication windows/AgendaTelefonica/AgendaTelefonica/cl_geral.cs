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
            string nome_arquivo = pasta_documentos + @"\" + @"arquivo_contatos.txt";
            if (!File.Exists(nome_arquivo))
            {
                //o arquivo deve ser criado
                //????
            }
            else
            {
                StreamReader arquivo = new StreamReader(nome_arquivo, Encoding.Default);
                LISTA_CONTATOS = new List<cl_contato>();
                //carregar todos os contatos
                while (arquivo.EndOfStream)
                {
                    //carrega nome
                    string nome = arquivo.ReadLine();
                    //carrega número
                    string numero = arquivo.ReadLine();

                    //adicionar a lista de contatos o contato carregado
                }
                //fecha arquivo
                arquivo.Dispose();
            }
        }
    }
}

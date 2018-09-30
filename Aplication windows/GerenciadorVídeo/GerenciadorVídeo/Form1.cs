using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace GerenciadorVídeo
{
    public partial class frm_principal : Form
    {
        private FileInfo[] Files;
        private int[] hM = { 0, 0, 0, 0 };//hora e minuto
        //[0],[1] -- incicio H e m
        //[2],[3] -- fim H e m
        private bool filtro { get; set; }
        private bool deletar { get; set; }
        private bool valido { get; set; }
        private int totReg { get; set; }
        private string pasta = @"";
        private string pasta_config;
        private string arquivo_config = @"config.ini";
        private string[] texto = new string[10];

        public frm_principal()
        {
            InitializeComponent();
            filtro = false;
            deletar = false;
            valido = true;
            pic_verde.Visible = false;
            pic_verm.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //retira filtro
            filtro = false;
            Atualiza();
            processaConf();    
        }

        private void processaConf()
        {
            //salva alterações
            if (pasta != texto[0])
            {
                gravaConfig();
            }

            //atualiza itens
            carregaConfiguracoes();
        }

        private void btn_apagar_Click(object sender, EventArgs e)
        {
            //pergunta ao usuário se realmente quer excluir
            if (MessageBox.Show("Deseja realmente excluir " + listView1.Items.Count + " arquivo(s)?",
                "Atenção",MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.No)
                return;
            deletar = true;
            Atualiza();
            deletar = false;
        }
        private int tamanho(int t, int p)
        {
            return (t - 25) * p / 100;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // prepara ambiente
            pasta_config = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Gerenciador de vídeos";

            carregaConfiguracoes();

            //seleciona primeiro item
            cmb_dir.Text = texto[0];

            //limpa grid
            limpaGrid();
        }
        private void carregaConfiguracoes()
        {
            pastaExiste();
            arquivoExiste();

            texto = leArquivo();

            //limpa lista de itens
            cmb_dir.Items.Clear();

            foreach (string linha in texto)
            {
                if (linha != null && linha != "")
                {
                    //acrescenta na listbox
                    cmb_dir.Items.Add(linha);
                }
            }
        }
        private void pastaExiste()
        {
            if (!Directory.Exists(pasta_config))
            {
                //cria o diretório
                Directory.CreateDirectory(pasta_config);
            }
        }
        private void arquivoExiste()
        {
            if (!File.Exists(pasta_config + @"\" + arquivo_config))
            {
                //cria arquivo
                processaEscrita(true);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_filtrar_Click(object sender, EventArgs e)
        {
            filtro = true;
            filtra();

            processaConf();
        }
        private void obtemHoraMinuto(string t, string t1)
        {
            //força valido
            valido = true;
            string msg = "Valor inválido para hora ";
            //verifica valor da string
            if (t == "")
            {
                msg += "inicio";
            }
            else
            {
                if (t1 == "")
                {
                    msg += "fim";
                }
                else
                {
                    //verifica se tamanho é menor que 3
                    if(t.Length <= 2)
                    {
                        //Atribui apenas hora
                        hM[0] = int.Parse(t);
                        hM[1] = 0;
                    }
                    else
                    {
                        textoInicio(t);
                    }
                    textoFim(t1);
                    if(valido)
                        return;
                }
            }
            valido = false;
            MessageBox.Show(msg, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void textoInicio(string t)
        {
            for (int c = 0; c < 5; c++)
            {

                //verifica divisão de hora para minuto
                if (t[c] == ':')
                {
                    //Inicio
                    hM[0] = int.Parse(t.Substring(0, c));
                    hM[1] = int.Parse(t.Substring(c + 1));

                    textoFim(txt_fim.Text);
                }
            }
        }
        private void textoFim(string t1)
        {
            //verifica se tamanho é menor que 3
            if (t1.Length <= 2)
            {
                //Atribui apenas hora
                hM[2] = int.Parse(t1);
                hM[3] = 0;

                valida();
                return;
            }
            else
            {
                for (int c = 0; c < 5; c++)
                {

                    //verifica divisão de hora para minuto
                    if (t1[c] == ':')
                    {
                        //Fim
                        hM[2] = int.Parse(t1.Substring(0, c));
                        hM[3] = int.Parse(t1.Substring(c + 1));

                        valida();

                        //finaliza busca
                        return;
                    }
                }
            }
        }
        private void valida()
        {
            //verifica se são iguais
            if (hM[0] == hM[2] && hM[1] == hM[3])
            {
                //atribui inválido == true
                valido = false;

                //reseta variável
                for (int i = 0; i < 4; i++)
                {
                    hM[i] = 0;

                }

            }
        }
        private void filtra()
        {
            obtemHoraMinuto(txt_inicio.Text, txt_fim.Text);
            if (valido != false)
            {
                filtro = true;
                Atualiza();
            }
        }
        private void Atualiza()
        {
            //pesquisa arquivos
            if (pasta == "")
            {
                MessageBox.Show("É necessário fornecer um diretório para pesquisa","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                btn_procurar.Focus();
                return;
            }else if (!Directory.Exists(pasta))
            {
                MessageBox.Show("É necessário fornecer um diretório válido para pesquisa", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btn_procurar.Focus();
                return;
            }
            DirectoryInfo d = new DirectoryInfo(pasta);
            Files = d.GetFiles("*", SearchOption.AllDirectories);
            
            //limpra grid
            limpaGrid();

            //reseta total de registros
            totReg = 0;

            //verifica se é para filtrar
            if (filtro != true)
            {
                // mostra propriedades
                foreach (FileInfo arquivo in Files)
                {
                    totReg++;
                    mostraPesquisa(arquivo);
                }
            }
            else
            {
                //percorre lista de arquivos
                int min, hor;

                //tratamento para intevalo de tempo
                if ((hM[0] == hM[2] && hM[1] > hM[3]) || hM[0] > hM[2])
                {
                    //inicio menor que fim
                    foreach (FileInfo arquivo in Files)
                    {
                        totReg++;
                        //aplica filtro na exibição
                        //filtro hora minuto inicio
                        hor = arquivo.LastWriteTime.Hour;
                        min = arquivo.LastWriteTime.Minute;

                        if(((hor == hM[0] && min >= hM[1]) || hor > hM[0]) || 
                            ((hor == hM[2] && min < hM[3]) || hor < hM[2]))
                        {
                            mostraPesquisa(arquivo);
                        }
                    }
                }
                else
                {
                    //inicio maior que fim
                    foreach (FileInfo arquivo in Files)
                    {
                        totReg++;
                        //aplica filtro na exibição
                        //filtro hora minuto inicio
                        hor = arquivo.LastWriteTime.Hour;
                        min = arquivo.LastWriteTime.Minute;

                        if ((hor == hM[0] && min >= hM[1]) || hor > hM[0])
                        {
                            if ((hor == hM[2] && min < hM[3]) || hor < hM[2])
                            {
                                mostraPesquisa(arquivo);
                            }
                        }
                    }
                }
            }

            //mostra resultados encontrados
            resultados();
        }
        private void limpaGrid()
        {
            listView1.Clear();

            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            int t = listView1.Width;
            listView1.Columns.Add("Arquivo", tamanho(t, 60), HorizontalAlignment.Left);
            listView1.Columns.Add("Hora de criação", tamanho(t, 40), HorizontalAlignment.Left);
        }
        private void mostraPesquisa(FileInfo arquivo)
        {
            //deleta se for deletar == true
            if (deletar == true)
            {
                arquivo.Delete();
            }
            else
            {
                //inclui resultado
                ListViewItem item = new ListViewItem(new[] { arquivo.Name, arquivo.LastWriteTime.TimeOfDay.ToString() });
                listView1.Items.Add(item);
            }
        }

        private void btn_procurar_Click(object sender, EventArgs e)
        {
            //cria uma caixa de diálogo
            FolderBrowserDialog procurar = new FolderBrowserDialog();

            //atualizar a partir de arquivo de configuração
            //inicia em documentos
            procurar.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

            //verifica se um diretório foi selecionado
            if (procurar.ShowDialog() == DialogResult.OK)
            {
                cmb_dir.Text = procurar.SelectedPath;

                //atualiza diretório de pesquisa
                pasta = cmb_dir.Text;

                //grava configurações no arquivo
                processaConf();

            }
            procurar.Dispose();
        }
        private void resultados()
        {
            //atualiza label
            lbl_res.Text = "Resultados: " + listView1.Items.Count + " de " + totReg;

            //atualiza pic
            pic_verm.Width = Convert.ToInt32((Convert.ToSingle(listView1.Items.Count) / totReg) * pic_verde.Width);

            //mostra pic
            pic_verm.Visible = true;
            pic_verde.Visible = true;
        }

        private void cmb_dir_TextChanged(object sender, EventArgs e)
        {
            //atualiza diretório de pesquisa
            pasta = cmb_dir.Text;
        }
        private void gravaConfig()
        {
            //tratamento para entrada vazia
            if (cmb_dir.Text == "")
                return;
            //verifica se o diretório existe
            pastaExiste();

            //verifica se arquivo existe
            arquivoExiste();

            //realiza leitura de arquivo
            texto = leArquivo();

            //verifica se há registros com o mesmo valor
            bool igual = false;
            int endRepetido = 0;
            for(int c = 0; c < 10; c++)
            {
                if (texto[c] == cmb_dir.Text)
                {
                    endRepetido = c;
                    igual = true;
                }
            }
            if (!igual)
            {
                //altera conteúdo
                //prepara para escrita
                limitaDir(pasta);
            }
            else
            {
                //altera ordem apenas
                string temp;
                temp = texto[endRepetido];

                for (int c = endRepetido; c > 0; c--)
                {
                    texto[c] = texto[c - 1];
                }
                texto[0] = temp;
            }

            //escreve vetor texto
            processaEscrita(false);

        }
        private void limitaDir(string t)
        {
            //limita a quantidade de diretórios
            //desloca linhas em arquivo
            for (int c = 8; c >= 0; c--)
            {
                //copia para outro endereço
                texto[c + 1] = texto[c];
            }
            texto[0] = t;
        }
        private string[] leArquivo()
        {
            string[] t = new string[10]; 
            //efetua leitura para posteriro gravação
            StreamReader Leitor = new StreamReader(pasta_config + @"\" + arquivo_config, Encoding.Default);

            //enquanto não chegar ao fim do arquivo
            int c = 0;
            while (!Leitor.EndOfStream)
            {
                t[c] = Leitor.ReadLine();
                c++;
            }

            //fecha arquivo
            Leitor.Dispose();
            return t;
        }
        private void processaEscrita(bool manter)
        {
            //inicia gravação no arquivo
            StreamWriter escrever = new StreamWriter(pasta_config + @"\" + arquivo_config, manter, Encoding.Default);

            foreach (string linha in texto)
            {
                escrever.WriteLine(linha);
            }

            escrever.Dispose();
        }

        private void frm_principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void cmb_dir_TextChanged_1(object sender, EventArgs e)
        {
            pasta = cmb_dir.Text;
        }
    }
}
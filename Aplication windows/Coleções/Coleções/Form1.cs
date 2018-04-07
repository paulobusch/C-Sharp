using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Coleções
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //coleção - LIST
            List<string> NOMES = new List<string>();
            NOMES.Add("Paulo");
            NOMES.Add("Antônio");
            NOMES.Add("Rodrigo");
            NOMES.Add("Carlos");
            NOMES.Add("Paulo");
            NOMES.Add("Emanuel");

            MessageBox.Show("Ultimo index de encontro: " + NOMES.LastIndexOf("Paulo"));
            foreach (string item in NOMES)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<int> listaInteiros = new List<int>() {10, 20, 30};
            foreach (int item in listaInteiros)
            {
                listBox1.Items.Add(item);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            HashSet<string> listaNomes = new HashSet<string>()
            {
                "João","Carlos","Paulo","Lucas"
            };
            if (!listaNomes.Add("Lucas"))
            {
                MessageBox.Show("Lucas já está na lista");
            }

            //iteração
            foreach (string item in listaNomes) {
                listBox1.Items.Add(item);
            }
                MessageBox.Show("Número de valores " + listaNomes.Count());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> listaValores;
            listaValores = new Dictionary<string, string>();

            listaValores.Add("b1", "João");
            listaValores.Add("b2", "Lucas");

            //iteração
            foreach (KeyValuePair<string,string> valor in listaValores)
            {
                listBox1.Items.Add(valor.Key);//lista chaves
                listBox1.Items.Add(valor.Value);//lista valores
            }

            MessageBox.Show(listaValores["b1"]);

            if (listaValores.ContainsKey("b2"))
            {
                MessageBox.Show("Contém a chave b2");
            }
        }
    }
}

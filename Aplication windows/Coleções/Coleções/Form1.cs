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
            //array
            string[] nomes = new string[5];
            nomes[0] = "João";
            nomes[1] = "Antônio";
            nomes[2] = "Paulo";
            nomes[3] = "Lucas";
            nomes[4] = "Carlos";
            //listBox1.Items.AddRange(nomes);

            //coleção - LIST
            List<string> NOMES = new List<string>();
            NOMES.Add("Paulo");
            NOMES.Add("Antônio");
            NOMES.Add("Rodrigo");
            NOMES.Add("Carlos");
            NOMES.Add("Emanuel");

            //NOMES.Remove("Paulo");

            NOMES.RemoveAt(2);

            foreach(string item in NOMES)
            {
                listBox1.Items.Add(item);
            }

            MessageBox.Show("Tamanho do array: " + NOMES.Count);
        }
    }
}

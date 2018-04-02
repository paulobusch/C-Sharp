using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace ApagaPastaArquivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            //File.Delete(@"C:\tmp\dados.txt");
            if(Directory.Exists(@"C:\tmp"))
                Directory.Delete(@"C:\tmp",true);
            MessageBox.Show("Terminado!");
        }
    }
}

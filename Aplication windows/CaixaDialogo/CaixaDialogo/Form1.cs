using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CaixaDialogo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            //MessageBox
            MessageBox.Show("Uma mensagem para exibição");

            //titulo, botões, icone
            MessageBox.Show("Mensagem",
                              "Titulo",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
           */

            //caixa com resultado
            if(MessageBox.Show("Deseja sair da aplicação?",
                            "Sair",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question) == DialogResult.No)
            return;

            //fecha a aplicação
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog caixa = new OpenFileDialog();
            caixa.Title = "Escolher arquivo";
            caixa.InitialDirectory = @"C:\";
            caixa.Filter = "Jpeg Images (*.jpg)|*.jpg" +
                           "|BMP files (*.bmp)|*.bmp";
            if (caixa.ShowDialog() == DialogResult.Cancel)
                return;
            //abre o arquivo
            MessageBox.Show("O usuário escolheu o arquivo " + caixa.FileName);
            pictureBox1.BackgroundImage = Image.FromFile(caixa.FileName);
        }
    } 
}

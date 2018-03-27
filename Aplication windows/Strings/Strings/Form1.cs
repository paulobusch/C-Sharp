using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Strings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_executar_Click(object sender, EventArgs e)
        {
            string frase = "Este tipo de variável é alfanumérica";
            //bool resultado = frase.StartsWith("Es");
            bool resultado = frase.EndsWith("ca");
            lbl_texto.Text = resultado.ToString();
            /*
            lbl_texto.Text = frase + " (contém " + frase.Length + " letras).";
            lbl_texto.Text += " \nMédodo ToUpper() [" + frase.ToUpper() + "].";
            lbl_texto.Text += " \nMédodo ToLower() [" + frase.ToLower() + "].";
            */
            /*
            lbl_texto.Text += " \nMédodo Substring(5) [" + frase.Substring(5) + "].";
            lbl_texto.Text += " \nMédodo Substring(5,4) [" + frase.Substring(5,4) + "].";
            bool resultado = frase.Contains("é");
            lbl_texto.Text += " \nMédodo Contains(\"é\") [" + resultado.ToString() + "].";
            */
        }
    }
}

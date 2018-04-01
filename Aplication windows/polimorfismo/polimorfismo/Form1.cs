using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace polimorfismo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rectangulo forma1 = new rectangulo();
            forma1.Largura = 50;
            forma1.Altura = 100;
            forma1.Apresentar();
            forma1.Desenhar();
            forma1.DesenharOutro();

            triangulo forma2 = new triangulo();
            forma2.Largura = 50;
            forma2.Altura = 100;
            forma2.Apresentar();
            forma2.Desenhar();
            forma2.DesenharOutro();

            circunrefencia forma3 = new circunrefencia();
            forma3.Largura = 50;
            forma3.Altura = 100;
            forma3.Apresentar();
            forma3.Desenhar();
            forma3.DesenharOutro();
        }
    }
}

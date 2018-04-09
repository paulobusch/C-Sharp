using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace LigacaoBaseDados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_conectar_Click(object sender, EventArgs e)
        {
            //ligação a base de dados
            SqlCeConnection ligacao = new SqlCeConnection();
            ligacao.ConnectionString = @"Data Source=C:\Users\paulo\Desktop\Projetos\C#\SQL Database\teste.sdf";
            ligacao.Open();
            lbl_resultado.Text = "Ligação efetuada com sucesso!";

            ligacao.Close();
        }
    }
}

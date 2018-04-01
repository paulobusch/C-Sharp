namespace DataHora
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_resultado = new System.Windows.Forms.Button();
            this.lbl_dia = new System.Windows.Forms.Label();
            this.txt_dia = new System.Windows.Forms.TextBox();
            this.txt_mes = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_ano = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_resultado
            // 
            this.btn_resultado.Location = new System.Drawing.Point(122, 361);
            this.btn_resultado.Name = "btn_resultado";
            this.btn_resultado.Size = new System.Drawing.Size(98, 46);
            this.btn_resultado.TabIndex = 0;
            this.btn_resultado.Text = "Executar";
            this.btn_resultado.UseVisualStyleBackColor = true;
            this.btn_resultado.Click += new System.EventHandler(this.btn_resultado_Click);
            // 
            // lbl_dia
            // 
            this.lbl_dia.AutoSize = true;
            this.lbl_dia.Location = new System.Drawing.Point(46, 36);
            this.lbl_dia.Name = "lbl_dia";
            this.lbl_dia.Size = new System.Drawing.Size(33, 20);
            this.lbl_dia.TabIndex = 1;
            this.lbl_dia.Text = "Dia";
            // 
            // txt_dia
            // 
            this.txt_dia.Location = new System.Drawing.Point(50, 70);
            this.txt_dia.Name = "txt_dia";
            this.txt_dia.Size = new System.Drawing.Size(100, 26);
            this.txt_dia.TabIndex = 2;
            // 
            // txt_mes
            // 
            this.txt_mes.Location = new System.Drawing.Point(50, 160);
            this.txt_mes.Name = "txt_mes";
            this.txt_mes.Size = new System.Drawing.Size(100, 26);
            this.txt_mes.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mês";
            // 
            // txt_ano
            // 
            this.txt_ano.Location = new System.Drawing.Point(50, 250);
            this.txt_ano.Name = "txt_ano";
            this.txt_ano.Size = new System.Drawing.Size(100, 26);
            this.txt_ano.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ano";
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(46, 314);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(82, 20);
            this.lbl_resultado.TabIndex = 7;
            this.lbl_resultado.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 434);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.txt_ano);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_mes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_dia);
            this.Controls.Add(this.lbl_dia);
            this.Controls.Add(this.btn_resultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_resultado;
        private System.Windows.Forms.Label lbl_dia;
        private System.Windows.Forms.TextBox txt_dia;
        private System.Windows.Forms.TextBox txt_mes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_ano;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_resultado;
    }
}


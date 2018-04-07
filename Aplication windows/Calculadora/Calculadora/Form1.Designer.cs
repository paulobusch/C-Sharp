namespace Calculadora
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
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.txt_operacao = new System.Windows.Forms.TextBox();
            this.lbl_algoritmo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(28, 130);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(176, 49);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Sair";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(218, 130);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(176, 49);
            this.btn_calcular.TabIndex = 1;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // txt_operacao
            // 
            this.txt_operacao.Location = new System.Drawing.Point(28, 67);
            this.txt_operacao.MaxLength = 30;
            this.txt_operacao.Name = "txt_operacao";
            this.txt_operacao.Size = new System.Drawing.Size(366, 26);
            this.txt_operacao.TabIndex = 0;
            this.txt_operacao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_operacao_KeyDown);
            // 
            // lbl_algoritmo
            // 
            this.lbl_algoritmo.AutoSize = true;
            this.lbl_algoritmo.Location = new System.Drawing.Point(24, 33);
            this.lbl_algoritmo.Name = "lbl_algoritmo";
            this.lbl_algoritmo.Size = new System.Drawing.Size(152, 20);
            this.lbl_algoritmo.TabIndex = 3;
            this.lbl_algoritmo.Text = "Escreva o algoritmo:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(428, 191);
            this.Controls.Add(this.lbl_algoritmo);
            this.Controls.Add(this.txt_operacao);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.btn_close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CALCULADORA 1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.TextBox txt_operacao;
        private System.Windows.Forms.Label lbl_algoritmo;
    }
}


namespace ArquivosTexto
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
            this.btn_executar = new System.Windows.Forms.Button();
            this.lst_texto = new System.Windows.Forms.ListBox();
            this.txt_mensagem = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_executar
            // 
            this.btn_executar.Location = new System.Drawing.Point(281, 386);
            this.btn_executar.Name = "btn_executar";
            this.btn_executar.Size = new System.Drawing.Size(122, 47);
            this.btn_executar.TabIndex = 0;
            this.btn_executar.Text = "Executar";
            this.btn_executar.UseVisualStyleBackColor = true;
            this.btn_executar.Click += new System.EventHandler(this.btn_executar_Click);
            // 
            // lst_texto
            // 
            this.lst_texto.FormattingEnabled = true;
            this.lst_texto.ItemHeight = 20;
            this.lst_texto.Location = new System.Drawing.Point(12, 12);
            this.lst_texto.Name = "lst_texto";
            this.lst_texto.Size = new System.Drawing.Size(391, 304);
            this.lst_texto.TabIndex = 1;
            // 
            // txt_mensagem
            // 
            this.txt_mensagem.Location = new System.Drawing.Point(12, 340);
            this.txt_mensagem.Name = "txt_mensagem";
            this.txt_mensagem.Size = new System.Drawing.Size(391, 26);
            this.txt_mensagem.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 445);
            this.Controls.Add(this.txt_mensagem);
            this.Controls.Add(this.lst_texto);
            this.Controls.Add(this.btn_executar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_executar;
        private System.Windows.Forms.ListBox lst_texto;
        private System.Windows.Forms.TextBox txt_mensagem;
    }
}


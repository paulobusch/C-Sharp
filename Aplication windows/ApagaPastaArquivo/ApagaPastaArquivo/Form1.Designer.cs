namespace ApagaPastaArquivo
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
            this.lst_arquivos = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_executar
            // 
            this.btn_executar.Location = new System.Drawing.Point(42, 313);
            this.btn_executar.Name = "btn_executar";
            this.btn_executar.Size = new System.Drawing.Size(162, 67);
            this.btn_executar.TabIndex = 0;
            this.btn_executar.Text = "Executar";
            this.btn_executar.UseVisualStyleBackColor = true;
            this.btn_executar.Click += new System.EventHandler(this.btn_executar_Click);
            // 
            // lst_arquivos
            // 
            this.lst_arquivos.FormattingEnabled = true;
            this.lst_arquivos.ItemHeight = 20;
            this.lst_arquivos.Location = new System.Drawing.Point(12, 12);
            this.lst_arquivos.Name = "lst_arquivos";
            this.lst_arquivos.Size = new System.Drawing.Size(236, 284);
            this.lst_arquivos.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 401);
            this.Controls.Add(this.lst_arquivos);
            this.Controls.Add(this.btn_executar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_executar;
        private System.Windows.Forms.ListBox lst_arquivos;
    }
}


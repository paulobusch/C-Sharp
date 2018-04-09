namespace LigacaoBaseDados
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
            this.btn_conectar = new System.Windows.Forms.Button();
            this.lst_dados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_conectar
            // 
            this.btn_conectar.Location = new System.Drawing.Point(439, 12);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(128, 42);
            this.btn_conectar.TabIndex = 0;
            this.btn_conectar.Text = "Executar Query";
            this.btn_conectar.UseVisualStyleBackColor = true;
            this.btn_conectar.Click += new System.EventHandler(this.btn_conectar_Click);
            // 
            // lst_dados
            // 
            this.lst_dados.FormattingEnabled = true;
            this.lst_dados.ItemHeight = 20;
            this.lst_dados.Location = new System.Drawing.Point(12, 12);
            this.lst_dados.Name = "lst_dados";
            this.lst_dados.Size = new System.Drawing.Size(421, 304);
            this.lst_dados.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(577, 331);
            this.Controls.Add(this.lst_dados);
            this.Controls.Add(this.btn_conectar);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_conectar;
        private System.Windows.Forms.ListBox lst_dados;
    }
}


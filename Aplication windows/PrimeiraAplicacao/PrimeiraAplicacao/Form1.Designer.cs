namespace PrimeiraAplicacao
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
            this.btn_clique = new System.Windows.Forms.Button();
            this.lbl_texto = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_clique
            // 
            this.btn_clique.Location = new System.Drawing.Point(153, 244);
            this.btn_clique.Name = "btn_clique";
            this.btn_clique.Size = new System.Drawing.Size(165, 38);
            this.btn_clique.TabIndex = 0;
            this.btn_clique.Text = "Executar";
            this.btn_clique.UseVisualStyleBackColor = true;
            this.btn_clique.Click += new System.EventHandler(this.btn_clique_Click);
            // 
            // lbl_texto
            // 
            this.lbl_texto.Location = new System.Drawing.Point(12, 118);
            this.lbl_texto.Name = "lbl_texto";
            this.lbl_texto.Size = new System.Drawing.Size(454, 34);
            this.lbl_texto.TabIndex = 1;
            this.lbl_texto.Text = "Texto de exemplo";
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(12, 12);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(156, 34);
            this.btn_exit.TabIndex = 2;
            this.btn_exit.Text = "Fechar aplicação";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 294);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_texto);
            this.Controls.Add(this.btn_clique);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_clique;
        private System.Windows.Forms.Label lbl_texto;
        private System.Windows.Forms.Button btn_exit;
    }
}


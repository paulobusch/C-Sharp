namespace ConversãoValores
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
            this.btn_gravar = new System.Windows.Forms.Button();
            this.btn_ler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_gravar
            // 
            this.btn_gravar.Location = new System.Drawing.Point(74, 331);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(145, 55);
            this.btn_gravar.TabIndex = 0;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // btn_ler
            // 
            this.btn_ler.Location = new System.Drawing.Point(380, 331);
            this.btn_ler.Name = "btn_ler";
            this.btn_ler.Size = new System.Drawing.Size(145, 55);
            this.btn_ler.TabIndex = 1;
            this.btn_ler.Text = "Ler";
            this.btn_ler.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 450);
            this.Controls.Add(this.btn_ler);
            this.Controls.Add(this.btn_gravar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Button btn_ler;
    }
}


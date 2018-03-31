namespace Enumerações
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_cima = new System.Windows.Forms.Button();
            this.btn_baixo = new System.Windows.Forms.Button();
            this.btn_direita = new System.Windows.Forms.Button();
            this.btn_esquerda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Executar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_cima
            // 
            this.btn_cima.Location = new System.Drawing.Point(165, 21);
            this.btn_cima.Name = "btn_cima";
            this.btn_cima.Size = new System.Drawing.Size(106, 52);
            this.btn_cima.TabIndex = 1;
            this.btn_cima.Text = "Cima";
            this.btn_cima.UseVisualStyleBackColor = true;
            this.btn_cima.Click += new System.EventHandler(this.btn_cima_Click);
            // 
            // btn_baixo
            // 
            this.btn_baixo.Location = new System.Drawing.Point(165, 134);
            this.btn_baixo.Name = "btn_baixo";
            this.btn_baixo.Size = new System.Drawing.Size(106, 54);
            this.btn_baixo.TabIndex = 2;
            this.btn_baixo.Text = "Baixo";
            this.btn_baixo.UseVisualStyleBackColor = true;
            this.btn_baixo.Click += new System.EventHandler(this.btn_baixo_Click);
            // 
            // btn_direita
            // 
            this.btn_direita.Location = new System.Drawing.Point(280, 79);
            this.btn_direita.Name = "btn_direita";
            this.btn_direita.Size = new System.Drawing.Size(114, 49);
            this.btn_direita.TabIndex = 3;
            this.btn_direita.Text = "Direita";
            this.btn_direita.UseVisualStyleBackColor = true;
            this.btn_direita.Click += new System.EventHandler(this.btn_direita_Click);
            // 
            // btn_esquerda
            // 
            this.btn_esquerda.Location = new System.Drawing.Point(55, 79);
            this.btn_esquerda.Name = "btn_esquerda";
            this.btn_esquerda.Size = new System.Drawing.Size(103, 49);
            this.btn_esquerda.TabIndex = 4;
            this.btn_esquerda.Text = "Esquerda";
            this.btn_esquerda.UseVisualStyleBackColor = true;
            this.btn_esquerda.Click += new System.EventHandler(this.btn_esquerda_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(443, 271);
            this.Controls.Add(this.btn_esquerda);
            this.Controls.Add(this.btn_direita);
            this.Controls.Add(this.btn_baixo);
            this.Controls.Add(this.btn_cima);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_cima;
        private System.Windows.Forms.Button btn_baixo;
        private System.Windows.Forms.Button btn_direita;
        private System.Windows.Forms.Button btn_esquerda;
    }
}


namespace Strings
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
            this.lbl_texto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_executar
            // 
            this.btn_executar.Location = new System.Drawing.Point(430, 178);
            this.btn_executar.Name = "btn_executar";
            this.btn_executar.Size = new System.Drawing.Size(143, 38);
            this.btn_executar.TabIndex = 0;
            this.btn_executar.Text = "Executar";
            this.btn_executar.UseVisualStyleBackColor = true;
            this.btn_executar.Click += new System.EventHandler(this.btn_executar_Click);
            // 
            // lbl_texto
            // 
            this.lbl_texto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_texto.Location = new System.Drawing.Point(13, 13);
            this.lbl_texto.Name = "lbl_texto";
            this.lbl_texto.Size = new System.Drawing.Size(560, 162);
            this.lbl_texto.TabIndex = 1;
            this.lbl_texto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(585, 228);
            this.Controls.Add(this.lbl_texto);
            this.Controls.Add(this.btn_executar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Strings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_executar;
        private System.Windows.Forms.Label lbl_texto;
    }
}


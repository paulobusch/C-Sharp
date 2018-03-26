namespace Variáveis
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
            this.btn_executa = new System.Windows.Forms.Button();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_executa
            // 
            this.btn_executa.Location = new System.Drawing.Point(152, 84);
            this.btn_executa.Name = "btn_executa";
            this.btn_executa.Size = new System.Drawing.Size(114, 59);
            this.btn_executa.TabIndex = 0;
            this.btn_executa.Text = "Executa";
            this.btn_executa.UseVisualStyleBackColor = true;
            this.btn_executa.Click += new System.EventHandler(this.btn_executa_Click);
            // 
            // lbl_msg
            // 
            this.lbl_msg.Location = new System.Drawing.Point(12, 9);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(385, 56);
            this.lbl_msg.TabIndex = 1;
            this.lbl_msg.Text = "Texto....";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 155);
            this.Controls.Add(this.lbl_msg);
            this.Controls.Add(this.btn_executa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_executa;
        private System.Windows.Forms.Label lbl_msg;
    }
}


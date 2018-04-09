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
            this.txt_base = new System.Windows.Forms.TextBox();
            this.btn_insert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_conectar
            // 
            this.btn_conectar.Location = new System.Drawing.Point(531, 13);
            this.btn_conectar.Name = "btn_conectar";
            this.btn_conectar.Size = new System.Drawing.Size(154, 61);
            this.btn_conectar.TabIndex = 0;
            this.btn_conectar.Text = "Select";
            this.btn_conectar.UseVisualStyleBackColor = true;
            this.btn_conectar.Click += new System.EventHandler(this.btn_conectar_Click);
            // 
            // lst_dados
            // 
            this.lst_dados.FormattingEnabled = true;
            this.lst_dados.ItemHeight = 20;
            this.lst_dados.Location = new System.Drawing.Point(12, 52);
            this.lst_dados.Name = "lst_dados";
            this.lst_dados.Size = new System.Drawing.Size(499, 324);
            this.lst_dados.TabIndex = 1;
            // 
            // txt_base
            // 
            this.txt_base.Location = new System.Drawing.Point(12, 13);
            this.txt_base.Name = "txt_base";
            this.txt_base.Size = new System.Drawing.Size(499, 26);
            this.txt_base.TabIndex = 2;
            this.txt_base.Text = "dados";
            // 
            // btn_insert
            // 
            this.btn_insert.Location = new System.Drawing.Point(531, 93);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(154, 61);
            this.btn_insert.TabIndex = 3;
            this.btn_insert.Text = "Insert";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(697, 410);
            this.Controls.Add(this.btn_insert);
            this.Controls.Add(this.txt_base);
            this.Controls.Add(this.lst_dados);
            this.Controls.Add(this.btn_conectar);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_conectar;
        private System.Windows.Forms.ListBox lst_dados;
        private System.Windows.Forms.TextBox txt_base;
        private System.Windows.Forms.Button btn_insert;
    }
}


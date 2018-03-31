namespace Encapsulamento
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
            this.rd_1 = new System.Windows.Forms.RadioButton();
            this.rd_2 = new System.Windows.Forms.RadioButton();
            this.rd_3 = new System.Windows.Forms.RadioButton();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.btn_executar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rd_1
            // 
            this.rd_1.AutoSize = true;
            this.rd_1.Checked = true;
            this.rd_1.Location = new System.Drawing.Point(12, 12);
            this.rd_1.Name = "rd_1";
            this.rd_1.Size = new System.Drawing.Size(69, 24);
            this.rd_1.TabIndex = 0;
            this.rd_1.TabStop = true;
            this.rd_1.Text = "Leite";
            this.rd_1.UseVisualStyleBackColor = true;
            // 
            // rd_2
            // 
            this.rd_2.AutoSize = true;
            this.rd_2.Location = new System.Drawing.Point(12, 43);
            this.rd_2.Name = "rd_2";
            this.rd_2.Size = new System.Drawing.Size(87, 24);
            this.rd_2.TabIndex = 1;
            this.rd_2.Text = "Martelo";
            this.rd_2.UseVisualStyleBackColor = true;
            // 
            // rd_3
            // 
            this.rd_3.AutoSize = true;
            this.rd_3.Location = new System.Drawing.Point(12, 74);
            this.rd_3.Name = "rd_3";
            this.rd_3.Size = new System.Drawing.Size(94, 24);
            this.rd_3.TabIndex = 2;
            this.rd_3.Text = "Perfume";
            this.rd_3.UseVisualStyleBackColor = true;
            // 
            // txt_preco
            // 
            this.txt_preco.Location = new System.Drawing.Point(12, 131);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(100, 26);
            this.txt_preco.TabIndex = 3;
            // 
            // btn_executar
            // 
            this.btn_executar.Location = new System.Drawing.Point(98, 192);
            this.btn_executar.Name = "btn_executar";
            this.btn_executar.Size = new System.Drawing.Size(167, 48);
            this.btn_executar.TabIndex = 4;
            this.btn_executar.Text = "Calcular";
            this.btn_executar.UseVisualStyleBackColor = true;
            this.btn_executar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(353, 265);
            this.Controls.Add(this.btn_executar);
            this.Controls.Add(this.txt_preco);
            this.Controls.Add(this.rd_3);
            this.Controls.Add(this.rd_2);
            this.Controls.Add(this.rd_1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encapsulamento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rd_1;
        private System.Windows.Forms.RadioButton rd_2;
        private System.Windows.Forms.RadioButton rd_3;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.Button btn_executar;
    }
}


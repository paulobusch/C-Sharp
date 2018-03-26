namespace OperadoresMatemáticos
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
            this.btn_calcula = new System.Windows.Forms.Button();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.txt_parcela1 = new System.Windows.Forms.TextBox();
            this.txt_parcela2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_calcula
            // 
            this.btn_calcula.Location = new System.Drawing.Point(37, 163);
            this.btn_calcula.Name = "btn_calcula";
            this.btn_calcula.Size = new System.Drawing.Size(97, 49);
            this.btn_calcula.TabIndex = 0;
            this.btn_calcula.Text = "Calcular";
            this.btn_calcula.UseVisualStyleBackColor = true;
            this.btn_calcula.Click += new System.EventHandler(this.btn_calcula_Click);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.Location = new System.Drawing.Point(13, 118);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(151, 28);
            this.lbl_resultado.TabIndex = 1;
            this.lbl_resultado.Text = "Resultado";
            this.lbl_resultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_resultado.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_parcela1
            // 
            this.txt_parcela1.Location = new System.Drawing.Point(34, 12);
            this.txt_parcela1.Name = "txt_parcela1";
            this.txt_parcela1.Size = new System.Drawing.Size(100, 26);
            this.txt_parcela1.TabIndex = 2;
            this.txt_parcela1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txt_parcela2
            // 
            this.txt_parcela2.Location = new System.Drawing.Point(34, 56);
            this.txt_parcela2.Name = "txt_parcela2";
            this.txt_parcela2.Size = new System.Drawing.Size(100, 26);
            this.txt_parcela2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 224);
            this.Controls.Add(this.txt_parcela2);
            this.Controls.Add(this.txt_parcela1);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.btn_calcula);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_calcula;
        private System.Windows.Forms.Label lbl_resultado;
        private System.Windows.Forms.TextBox txt_parcela1;
        private System.Windows.Forms.TextBox txt_parcela2;
    }
}


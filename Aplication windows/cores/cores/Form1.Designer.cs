namespace cores
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
            this.caixa = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.caixa)).BeginInit();
            this.SuspendLayout();
            // 
            // caixa
            // 
            this.caixa.BackColor = System.Drawing.Color.Red;
            this.caixa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.caixa.Location = new System.Drawing.Point(143, 110);
            this.caixa.Name = "caixa";
            this.caixa.Size = new System.Drawing.Size(92, 85);
            this.caixa.TabIndex = 0;
            this.caixa.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 84);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 365);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.caixa);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.caixa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox caixa;
        private System.Windows.Forms.Button button1;
    }
}


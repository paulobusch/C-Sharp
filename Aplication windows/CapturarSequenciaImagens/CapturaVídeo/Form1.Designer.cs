namespace CapturaVídeo
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
            this.components = new System.ComponentModel.Container();
            this.cmb_itens = new System.Windows.Forms.ComboBox();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.btn_parar = new System.Windows.Forms.Button();
            this.btn_foto = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_itens
            // 
            this.cmb_itens.FormattingEnabled = true;
            this.cmb_itens.Location = new System.Drawing.Point(12, 332);
            this.cmb_itens.Name = "cmb_itens";
            this.cmb_itens.Size = new System.Drawing.Size(485, 28);
            this.cmb_itens.TabIndex = 0;
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Location = new System.Drawing.Point(12, 379);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(91, 29);
            this.btn_iniciar.TabIndex = 1;
            this.btn_iniciar.Text = "Iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // btn_parar
            // 
            this.btn_parar.Location = new System.Drawing.Point(109, 379);
            this.btn_parar.Name = "btn_parar";
            this.btn_parar.Size = new System.Drawing.Size(91, 29);
            this.btn_parar.TabIndex = 2;
            this.btn_parar.Text = "Parar";
            this.btn_parar.UseVisualStyleBackColor = true;
            this.btn_parar.Click += new System.EventHandler(this.btn_parar_Click);
            // 
            // btn_foto
            // 
            this.btn_foto.Location = new System.Drawing.Point(406, 379);
            this.btn_foto.Name = "btn_foto";
            this.btn_foto.Size = new System.Drawing.Size(91, 29);
            this.btn_foto.TabIndex = 3;
            this.btn_foto.Text = "Foto";
            this.btn_foto.UseVisualStyleBackColor = true;
            this.btn_foto.Click += new System.EventHandler(this.btn_foto_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(485, 314);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = ".jpg.images|*.jpg";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 426);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_foto);
            this.Controls.Add(this.btn_parar);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.cmb_itens);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmb_itens;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Button btn_parar;
        private System.Windows.Forms.Button btn_foto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer timer1;
    }
}


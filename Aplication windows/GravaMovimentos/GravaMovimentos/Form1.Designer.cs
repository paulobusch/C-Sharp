namespace GravaMovimentos
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
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.btn_parar = new System.Windows.Forms.Button();
            this.cmb_dispositivos = new System.Windows.Forms.ComboBox();
            this.imagem_frame = new System.Windows.Forms.PictureBox();
            this.btn_detectar = new System.Windows.Forms.Button();
            this.cmb_procurar = new System.Windows.Forms.ComboBox();
            this.btn_procurar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagem_frame)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Location = new System.Drawing.Point(229, 80);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(107, 50);
            this.btn_iniciar.TabIndex = 0;
            this.btn_iniciar.Text = "Iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // btn_parar
            // 
            this.btn_parar.Location = new System.Drawing.Point(353, 80);
            this.btn_parar.Name = "btn_parar";
            this.btn_parar.Size = new System.Drawing.Size(107, 50);
            this.btn_parar.TabIndex = 1;
            this.btn_parar.Text = "Parar";
            this.btn_parar.UseVisualStyleBackColor = true;
            this.btn_parar.Click += new System.EventHandler(this.btn_parar_Click);
            // 
            // cmb_dispositivos
            // 
            this.cmb_dispositivos.FormattingEnabled = true;
            this.cmb_dispositivos.Location = new System.Drawing.Point(13, 92);
            this.cmb_dispositivos.Name = "cmb_dispositivos";
            this.cmb_dispositivos.Size = new System.Drawing.Size(200, 28);
            this.cmb_dispositivos.TabIndex = 2;
            // 
            // imagem_frame
            // 
            this.imagem_frame.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imagem_frame.Location = new System.Drawing.Point(12, 150);
            this.imagem_frame.Name = "imagem_frame";
            this.imagem_frame.Size = new System.Drawing.Size(587, 426);
            this.imagem_frame.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagem_frame.TabIndex = 3;
            this.imagem_frame.TabStop = false;
            // 
            // btn_detectar
            // 
            this.btn_detectar.Location = new System.Drawing.Point(470, 80);
            this.btn_detectar.Name = "btn_detectar";
            this.btn_detectar.Size = new System.Drawing.Size(129, 50);
            this.btn_detectar.TabIndex = 4;
            this.btn_detectar.Text = "Detectar";
            this.btn_detectar.UseVisualStyleBackColor = true;
            this.btn_detectar.Click += new System.EventHandler(this.btn_detectar_Click);
            // 
            // cmb_procurar
            // 
            this.cmb_procurar.FormattingEnabled = true;
            this.cmb_procurar.Location = new System.Drawing.Point(13, 27);
            this.cmb_procurar.Name = "cmb_procurar";
            this.cmb_procurar.Size = new System.Drawing.Size(428, 28);
            this.cmb_procurar.TabIndex = 5;
            // 
            // btn_procurar
            // 
            this.btn_procurar.Location = new System.Drawing.Point(458, 13);
            this.btn_procurar.Name = "btn_procurar";
            this.btn_procurar.Size = new System.Drawing.Size(128, 49);
            this.btn_procurar.TabIndex = 6;
            this.btn_procurar.Text = "Procurar";
            this.btn_procurar.UseVisualStyleBackColor = true;
            this.btn_procurar.Click += new System.EventHandler(this.btn_procurar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(621, 593);
            this.Controls.Add(this.btn_procurar);
            this.Controls.Add(this.cmb_procurar);
            this.Controls.Add(this.btn_detectar);
            this.Controls.Add(this.imagem_frame);
            this.Controls.Add(this.cmb_dispositivos);
            this.Controls.Add(this.btn_parar);
            this.Controls.Add(this.btn_iniciar);
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Grava Movimentos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagem_frame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Button btn_parar;
        private System.Windows.Forms.ComboBox cmb_dispositivos;
        private System.Windows.Forms.PictureBox imagem_frame;
        private System.Windows.Forms.Button btn_detectar;
        private System.Windows.Forms.ComboBox cmb_procurar;
        private System.Windows.Forms.Button btn_procurar;
    }
}


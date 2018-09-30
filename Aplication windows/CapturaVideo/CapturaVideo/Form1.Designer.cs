namespace CapturaVideo
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
            this.btn_strat = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_foto = new System.Windows.Forms.Button();
            this.btn_video = new System.Windows.Forms.Button();
            this.cmb_dispositivos = new System.Windows.Forms.ComboBox();
            this.imagem_captura = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.imagem_captura)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_strat
            // 
            this.btn_strat.Location = new System.Drawing.Point(206, 13);
            this.btn_strat.Name = "btn_strat";
            this.btn_strat.Size = new System.Drawing.Size(95, 38);
            this.btn_strat.TabIndex = 1;
            this.btn_strat.Text = "Iniciar";
            this.btn_strat.UseVisualStyleBackColor = true;
            this.btn_strat.Click += new System.EventHandler(this.btn_strat_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(318, 13);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(95, 38);
            this.btn_stop.TabIndex = 2;
            this.btn_stop.Text = "Parar";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // btn_foto
            // 
            this.btn_foto.Location = new System.Drawing.Point(472, 13);
            this.btn_foto.Name = "btn_foto";
            this.btn_foto.Size = new System.Drawing.Size(95, 38);
            this.btn_foto.TabIndex = 3;
            this.btn_foto.Text = "Foto";
            this.btn_foto.UseVisualStyleBackColor = true;
            this.btn_foto.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // btn_video
            // 
            this.btn_video.Location = new System.Drawing.Point(583, 13);
            this.btn_video.Name = "btn_video";
            this.btn_video.Size = new System.Drawing.Size(95, 38);
            this.btn_video.TabIndex = 4;
            this.btn_video.Text = "Video";
            this.btn_video.UseVisualStyleBackColor = true;
            this.btn_video.Click += new System.EventHandler(this.btn_capture_Click);
            // 
            // cmb_dispositivos
            // 
            this.cmb_dispositivos.FormattingEnabled = true;
            this.cmb_dispositivos.Location = new System.Drawing.Point(14, 13);
            this.cmb_dispositivos.Name = "cmb_dispositivos";
            this.cmb_dispositivos.Size = new System.Drawing.Size(172, 28);
            this.cmb_dispositivos.TabIndex = 6;
            // 
            // imagem_captura
            // 
            this.imagem_captura.Location = new System.Drawing.Point(14, 57);
            this.imagem_captura.Name = "imagem_captura";
            this.imagem_captura.Size = new System.Drawing.Size(640, 480);
            this.imagem_captura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagem_captura.TabIndex = 7;
            this.imagem_captura.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 606);
            this.Controls.Add(this.imagem_captura);
            this.Controls.Add(this.cmb_dispositivos);
            this.Controls.Add(this.btn_video);
            this.Controls.Add(this.btn_foto);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_strat);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imagem_captura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_strat;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_foto;
        private System.Windows.Forms.Button btn_video;
        private System.Windows.Forms.ComboBox cmb_dispositivos;
        private System.Windows.Forms.PictureBox imagem_captura;
    }
}


namespace MotionDetection
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
            this.videoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
            this.cmb_cameras = new System.Windows.Forms.ComboBox();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.btn_parar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_deteccao = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // videoSourcePlayer
            // 
            this.videoSourcePlayer.Location = new System.Drawing.Point(12, 81);
            this.videoSourcePlayer.Name = "videoSourcePlayer";
            this.videoSourcePlayer.Size = new System.Drawing.Size(724, 543);
            this.videoSourcePlayer.TabIndex = 0;
            this.videoSourcePlayer.Text = "videoSourcePlayer1";
            this.videoSourcePlayer.VideoSource = null;
            this.videoSourcePlayer.NewFrame += new AForge.Controls.VideoSourcePlayer.NewFrameHandler(this.videoSourcePlayer_NewFrame);
            // 
            // cmb_cameras
            // 
            this.cmb_cameras.FormattingEnabled = true;
            this.cmb_cameras.Location = new System.Drawing.Point(13, 22);
            this.cmb_cameras.Name = "cmb_cameras";
            this.cmb_cameras.Size = new System.Drawing.Size(282, 28);
            this.cmb_cameras.TabIndex = 1;
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Location = new System.Drawing.Point(318, 22);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(130, 38);
            this.btn_iniciar.TabIndex = 2;
            this.btn_iniciar.Text = "Iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // btn_parar
            // 
            this.btn_parar.Location = new System.Drawing.Point(454, 22);
            this.btn_parar.Name = "btn_parar";
            this.btn_parar.Size = new System.Drawing.Size(130, 38);
            this.btn_parar.TabIndex = 3;
            this.btn_parar.Text = "Parar";
            this.btn_parar.UseVisualStyleBackColor = true;
            this.btn_parar.Click += new System.EventHandler(this.btn_parar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(590, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nivel de detecção:";
            // 
            // txt_deteccao
            // 
            this.txt_deteccao.Location = new System.Drawing.Point(594, 33);
            this.txt_deteccao.Name = "txt_deteccao";
            this.txt_deteccao.Size = new System.Drawing.Size(134, 26);
            this.txt_deteccao.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 636);
            this.Controls.Add(this.txt_deteccao);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_parar);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.cmb_cameras);
            this.Controls.Add(this.videoSourcePlayer);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detecção de movimento";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AForge.Controls.VideoSourcePlayer videoSourcePlayer;
        private System.Windows.Forms.ComboBox cmb_cameras;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Button btn_parar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_deteccao;
        private System.Windows.Forms.Timer timer1;
    }
}


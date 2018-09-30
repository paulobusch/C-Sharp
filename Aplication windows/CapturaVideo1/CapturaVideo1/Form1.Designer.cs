namespace CapturaVideo1
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
            this.picture_box = new System.Windows.Forms.PictureBox();
            this.btn_iniciar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_gravar = new System.Windows.Forms.Button();
            this.btn_parar_gravar = new System.Windows.Forms.Button();
            this.btn_parar_camera = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).BeginInit();
            this.SuspendLayout();
            // 
            // picture_box
            // 
            this.picture_box.Location = new System.Drawing.Point(12, 72);
            this.picture_box.Name = "picture_box";
            this.picture_box.Size = new System.Drawing.Size(739, 512);
            this.picture_box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picture_box.TabIndex = 0;
            this.picture_box.TabStop = false;
            // 
            // btn_iniciar
            // 
            this.btn_iniciar.Location = new System.Drawing.Point(12, 5);
            this.btn_iniciar.Name = "btn_iniciar";
            this.btn_iniciar.Size = new System.Drawing.Size(122, 47);
            this.btn_iniciar.TabIndex = 1;
            this.btn_iniciar.Text = "Iniciar";
            this.btn_iniciar.UseVisualStyleBackColor = true;
            this.btn_iniciar.Click += new System.EventHandler(this.btn_iniciar_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_gravar
            // 
            this.btn_gravar.Location = new System.Drawing.Point(501, 12);
            this.btn_gravar.Name = "btn_gravar";
            this.btn_gravar.Size = new System.Drawing.Size(122, 47);
            this.btn_gravar.TabIndex = 2;
            this.btn_gravar.Text = "Gravar";
            this.btn_gravar.UseVisualStyleBackColor = true;
            this.btn_gravar.Click += new System.EventHandler(this.btn_gravar_Click);
            // 
            // btn_parar_gravar
            // 
            this.btn_parar_gravar.Location = new System.Drawing.Point(629, 12);
            this.btn_parar_gravar.Name = "btn_parar_gravar";
            this.btn_parar_gravar.Size = new System.Drawing.Size(122, 47);
            this.btn_parar_gravar.TabIndex = 3;
            this.btn_parar_gravar.Text = "Parar";
            this.btn_parar_gravar.UseVisualStyleBackColor = true;
            this.btn_parar_gravar.Click += new System.EventHandler(this.btn_parar_gravar_Click);
            // 
            // btn_parar_camera
            // 
            this.btn_parar_camera.Location = new System.Drawing.Point(140, 5);
            this.btn_parar_camera.Name = "btn_parar_camera";
            this.btn_parar_camera.Size = new System.Drawing.Size(122, 47);
            this.btn_parar_camera.TabIndex = 4;
            this.btn_parar_camera.Text = "Parar";
            this.btn_parar_camera.UseVisualStyleBackColor = true;
            this.btn_parar_camera.Click += new System.EventHandler(this.btn_parar_camera_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(305, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 596);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_parar_camera);
            this.Controls.Add(this.btn_parar_gravar);
            this.Controls.Add(this.btn_gravar);
            this.Controls.Add(this.btn_iniciar);
            this.Controls.Add(this.picture_box);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picture_box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picture_box;
        private System.Windows.Forms.Button btn_iniciar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_gravar;
        private System.Windows.Forms.Button btn_parar_gravar;
        private System.Windows.Forms.Button btn_parar_camera;
        private System.Windows.Forms.Label label1;
    }
}


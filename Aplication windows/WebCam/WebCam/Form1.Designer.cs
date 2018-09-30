namespace WebCam
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
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btn_capturar = new System.Windows.Forms.Button();
            this.btn_limpoar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_dispositivo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(40, 41);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(249, 230);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            // 
            // btn_capturar
            // 
            this.btn_capturar.Location = new System.Drawing.Point(319, 41);
            this.btn_capturar.Name = "btn_capturar";
            this.btn_capturar.Size = new System.Drawing.Size(152, 60);
            this.btn_capturar.TabIndex = 1;
            this.btn_capturar.Text = "Capturar";
            this.btn_capturar.UseVisualStyleBackColor = true;
            this.btn_capturar.Click += new System.EventHandler(this.btn_capturar_Click);
            // 
            // btn_limpoar
            // 
            this.btn_limpoar.Location = new System.Drawing.Point(319, 121);
            this.btn_limpoar.Name = "btn_limpoar";
            this.btn_limpoar.Size = new System.Drawing.Size(152, 60);
            this.btn_limpoar.TabIndex = 2;
            this.btn_limpoar.Text = "Limpar";
            this.btn_limpoar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Dispositivo:";
            // 
            // cmb_dispositivo
            // 
            this.cmb_dispositivo.FormattingEnabled = true;
            this.cmb_dispositivo.Location = new System.Drawing.Point(40, 311);
            this.cmb_dispositivo.Name = "cmb_dispositivo";
            this.cmb_dispositivo.Size = new System.Drawing.Size(431, 28);
            this.cmb_dispositivo.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 381);
            this.Controls.Add(this.cmb_dispositivo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_limpoar);
            this.Controls.Add(this.btn_capturar);
            this.Controls.Add(this.pictureBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btn_capturar;
        private System.Windows.Forms.Button btn_limpoar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_dispositivo;
    }
}


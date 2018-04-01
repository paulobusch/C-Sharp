namespace EnvioRetorno
{
    partial class frm1
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
            this.btn_avancar = new System.Windows.Forms.Button();
            this.lbl_texto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_avancar
            // 
            this.btn_avancar.Location = new System.Drawing.Point(361, 143);
            this.btn_avancar.Name = "btn_avancar";
            this.btn_avancar.Size = new System.Drawing.Size(115, 56);
            this.btn_avancar.TabIndex = 0;
            this.btn_avancar.Text = "Avançar";
            this.btn_avancar.UseVisualStyleBackColor = true;
            this.btn_avancar.Click += new System.EventHandler(this.btn_avancar_Click);
            // 
            // lbl_texto
            // 
            this.lbl_texto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_texto.Location = new System.Drawing.Point(13, 13);
            this.lbl_texto.Name = "lbl_texto";
            this.lbl_texto.Size = new System.Drawing.Size(453, 40);
            this.lbl_texto.TabIndex = 1;
            this.lbl_texto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 217);
            this.Controls.Add(this.lbl_texto);
            this.Controls.Add(this.btn_avancar);
            this.Name = "frm1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FRM_1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_avancar;
        private System.Windows.Forms.Label lbl_texto;
    }
}


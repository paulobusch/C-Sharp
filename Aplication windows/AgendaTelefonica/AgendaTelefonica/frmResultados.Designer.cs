namespace AgendaTelefonica
{
    partial class frmResultados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_fechar = new System.Windows.Forms.Button();
            this.btn_nova_pesquisa = new System.Windows.Forms.Button();
            this.lst_pesquisa = new System.Windows.Forms.ListBox();
            this.lbl_num_registros = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(441, 202);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(145, 48);
            this.btn_fechar.TabIndex = 0;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // btn_nova_pesquisa
            // 
            this.btn_nova_pesquisa.Location = new System.Drawing.Point(273, 202);
            this.btn_nova_pesquisa.Name = "btn_nova_pesquisa";
            this.btn_nova_pesquisa.Size = new System.Drawing.Size(145, 48);
            this.btn_nova_pesquisa.TabIndex = 1;
            this.btn_nova_pesquisa.Text = "Nova pesquisa...";
            this.btn_nova_pesquisa.UseVisualStyleBackColor = true;
            this.btn_nova_pesquisa.Click += new System.EventHandler(this.btn_nova_pesquisa_Click);
            // 
            // lst_pesquisa
            // 
            this.lst_pesquisa.FormattingEnabled = true;
            this.lst_pesquisa.ItemHeight = 20;
            this.lst_pesquisa.Location = new System.Drawing.Point(12, 12);
            this.lst_pesquisa.Name = "lst_pesquisa";
            this.lst_pesquisa.Size = new System.Drawing.Size(574, 184);
            this.lst_pesquisa.TabIndex = 2;
            // 
            // lbl_num_registros
            // 
            this.lbl_num_registros.Location = new System.Drawing.Point(12, 213);
            this.lbl_num_registros.Name = "lbl_num_registros";
            this.lbl_num_registros.Size = new System.Drawing.Size(255, 26);
            this.lbl_num_registros.TabIndex = 11;
            this.lbl_num_registros.Text = "Registros: 0";
            this.lbl_num_registros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 287);
            this.ControlBox = false;
            this.Controls.Add(this.lbl_num_registros);
            this.Controls.Add(this.lst_pesquisa);
            this.Controls.Add(this.btn_nova_pesquisa);
            this.Controls.Add(this.btn_fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resultados";
            this.Load += new System.EventHandler(this.frmResultados_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Button btn_nova_pesquisa;
        private System.Windows.Forms.ListBox lst_pesquisa;
        private System.Windows.Forms.Label lbl_num_registros;
    }
}
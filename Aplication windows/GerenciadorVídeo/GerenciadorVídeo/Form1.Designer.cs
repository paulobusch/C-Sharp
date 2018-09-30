namespace GerenciadorVídeo
{
    partial class frm_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_principal));
            this.btn_listar = new System.Windows.Forms.Button();
            this.lbl_res = new System.Windows.Forms.Label();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.btn_procurar = new System.Windows.Forms.Button();
            this.btn_filtrar = new System.Windows.Forms.Button();
            this.txt_inicio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_fim = new System.Windows.Forms.TextBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.cmb_dir = new System.Windows.Forms.ComboBox();
            this.pic_verde = new System.Windows.Forms.PictureBox();
            this.pic_verm = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic_verde)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_verm)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_listar
            // 
            this.btn_listar.Location = new System.Drawing.Point(621, 110);
            this.btn_listar.Name = "btn_listar";
            this.btn_listar.Size = new System.Drawing.Size(139, 58);
            this.btn_listar.TabIndex = 0;
            this.btn_listar.Text = "Listar";
            this.btn_listar.UseVisualStyleBackColor = true;
            this.btn_listar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_res
            // 
            this.lbl_res.Location = new System.Drawing.Point(13, 466);
            this.lbl_res.Name = "lbl_res";
            this.lbl_res.Size = new System.Drawing.Size(237, 20);
            this.lbl_res.TabIndex = 3;
            this.lbl_res.Text = "Resultados: 0";
            // 
            // btn_apagar
            // 
            this.btn_apagar.Location = new System.Drawing.Point(621, 199);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(139, 59);
            this.btn_apagar.TabIndex = 4;
            this.btn_apagar.Text = "Apagar";
            this.btn_apagar.UseVisualStyleBackColor = true;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(17, 150);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(581, 303);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // btn_procurar
            // 
            this.btn_procurar.Location = new System.Drawing.Point(621, 26);
            this.btn_procurar.Name = "btn_procurar";
            this.btn_procurar.Size = new System.Drawing.Size(139, 53);
            this.btn_procurar.TabIndex = 6;
            this.btn_procurar.Text = "Procurar";
            this.btn_procurar.UseVisualStyleBackColor = true;
            this.btn_procurar.Click += new System.EventHandler(this.btn_procurar_Click);
            // 
            // btn_filtrar
            // 
            this.btn_filtrar.Location = new System.Drawing.Point(498, 89);
            this.btn_filtrar.Name = "btn_filtrar";
            this.btn_filtrar.Size = new System.Drawing.Size(100, 42);
            this.btn_filtrar.TabIndex = 7;
            this.btn_filtrar.Text = "Filtrar";
            this.btn_filtrar.UseVisualStyleBackColor = true;
            this.btn_filtrar.Click += new System.EventHandler(this.btn_filtrar_Click);
            // 
            // txt_inicio
            // 
            this.txt_inicio.Location = new System.Drawing.Point(113, 97);
            this.txt_inicio.Name = "txt_inicio";
            this.txt_inicio.Size = new System.Drawing.Size(77, 26);
            this.txt_inicio.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Hora inicial";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Hora final";
            // 
            // txt_fim
            // 
            this.txt_fim.Location = new System.Drawing.Point(368, 97);
            this.txt_fim.Name = "txt_fim";
            this.txt_fim.Size = new System.Drawing.Size(83, 26);
            this.txt_fim.TabIndex = 11;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(621, 283);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(139, 59);
            this.btn_cancelar.TabIndex = 12;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // cmb_dir
            // 
            this.cmb_dir.FormattingEnabled = true;
            this.cmb_dir.Location = new System.Drawing.Point(25, 39);
            this.cmb_dir.Name = "cmb_dir";
            this.cmb_dir.Size = new System.Drawing.Size(573, 28);
            this.cmb_dir.TabIndex = 13;
            this.cmb_dir.TextChanged += new System.EventHandler(this.cmb_dir_TextChanged_1);
            // 
            // pic_verde
            // 
            this.pic_verde.BackColor = System.Drawing.Color.ForestGreen;
            this.pic_verde.Location = new System.Drawing.Point(256, 466);
            this.pic_verde.Name = "pic_verde";
            this.pic_verde.Size = new System.Drawing.Size(342, 20);
            this.pic_verde.TabIndex = 14;
            this.pic_verde.TabStop = false;
            // 
            // pic_verm
            // 
            this.pic_verm.BackColor = System.Drawing.Color.Red;
            this.pic_verm.Location = new System.Drawing.Point(256, 466);
            this.pic_verm.Name = "pic_verm";
            this.pic_verm.Size = new System.Drawing.Size(106, 20);
            this.pic_verm.TabIndex = 15;
            this.pic_verm.TabStop = false;
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(772, 498);
            this.Controls.Add(this.pic_verm);
            this.Controls.Add(this.pic_verde);
            this.Controls.Add(this.cmb_dir);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.txt_fim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_inicio);
            this.Controls.Add(this.btn_filtrar);
            this.Controls.Add(this.btn_procurar);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btn_apagar);
            this.Controls.Add(this.lbl_res);
            this.Controls.Add(this.btn_listar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciador de arquivos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm_principal_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic_verde)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_verm)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_listar;
        private System.Windows.Forms.Label lbl_res;
        private System.Windows.Forms.Button btn_apagar;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button btn_procurar;
        private System.Windows.Forms.Button btn_filtrar;
        private System.Windows.Forms.TextBox txt_inicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_fim;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.ComboBox cmb_dir;
        private System.Windows.Forms.PictureBox pic_verde;
        private System.Windows.Forms.PictureBox pic_verm;
    }
}


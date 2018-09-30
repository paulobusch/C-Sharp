namespace AgendaSQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResultados));
            this.btn_fechar = new System.Windows.Forms.Button();
            this.grid_resultados = new System.Windows.Forms.DataGridView();
            this.lbl_resultados = new System.Windows.Forms.Label();
            this.btn_apagar = new System.Windows.Forms.Button();
            this.btn_editar = new System.Windows.Forms.Button();
            this.btn_ver_tudo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_resultados)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(650, 447);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(153, 59);
            this.btn_fechar.TabIndex = 0;
            this.btn_fechar.Text = "Fehar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // grid_resultados
            // 
            this.grid_resultados.AllowUserToAddRows = false;
            this.grid_resultados.AllowUserToDeleteRows = false;
            this.grid_resultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_resultados.Location = new System.Drawing.Point(12, 12);
            this.grid_resultados.MultiSelect = false;
            this.grid_resultados.Name = "grid_resultados";
            this.grid_resultados.ReadOnly = true;
            this.grid_resultados.RowHeadersVisible = false;
            this.grid_resultados.RowTemplate.Height = 28;
            this.grid_resultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_resultados.Size = new System.Drawing.Size(790, 420);
            this.grid_resultados.TabIndex = 1;
            this.grid_resultados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_resultados_CellClick);
            // 
            // lbl_resultados
            // 
            this.lbl_resultados.AutoSize = true;
            this.lbl_resultados.Location = new System.Drawing.Point(12, 457);
            this.lbl_resultados.Name = "lbl_resultados";
            this.lbl_resultados.Size = new System.Drawing.Size(107, 20);
            this.lbl_resultados.TabIndex = 2;
            this.lbl_resultados.Text = "Resultados: 0";
            // 
            // btn_apagar
            // 
            this.btn_apagar.Location = new System.Drawing.Point(491, 447);
            this.btn_apagar.Name = "btn_apagar";
            this.btn_apagar.Size = new System.Drawing.Size(153, 59);
            this.btn_apagar.TabIndex = 3;
            this.btn_apagar.Text = "Apagar";
            this.btn_apagar.UseVisualStyleBackColor = true;
            this.btn_apagar.Click += new System.EventHandler(this.btn_apagar_Click);
            // 
            // btn_editar
            // 
            this.btn_editar.Location = new System.Drawing.Point(332, 447);
            this.btn_editar.Name = "btn_editar";
            this.btn_editar.Size = new System.Drawing.Size(153, 59);
            this.btn_editar.TabIndex = 4;
            this.btn_editar.Text = "Editar";
            this.btn_editar.UseVisualStyleBackColor = true;
            this.btn_editar.Click += new System.EventHandler(this.btn_editar_Click);
            // 
            // btn_ver_tudo
            // 
            this.btn_ver_tudo.Location = new System.Drawing.Point(173, 447);
            this.btn_ver_tudo.Name = "btn_ver_tudo";
            this.btn_ver_tudo.Size = new System.Drawing.Size(153, 59);
            this.btn_ver_tudo.TabIndex = 5;
            this.btn_ver_tudo.Text = "Ver tudo";
            this.btn_ver_tudo.UseVisualStyleBackColor = true;
            this.btn_ver_tudo.Click += new System.EventHandler(this.btn_ver_tudo_Click);
            // 
            // frmResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 548);
            this.ControlBox = false;
            this.Controls.Add(this.btn_ver_tudo);
            this.Controls.Add(this.btn_editar);
            this.Controls.Add(this.btn_apagar);
            this.Controls.Add(this.lbl_resultados);
            this.Controls.Add(this.grid_resultados);
            this.Controls.Add(this.btn_fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmResultados";
            this.Load += new System.EventHandler(this.frmResultados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_resultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.DataGridView grid_resultados;
        private System.Windows.Forms.Label lbl_resultados;
        private System.Windows.Forms.Button btn_apagar;
        private System.Windows.Forms.Button btn_editar;
        private System.Windows.Forms.Button btn_ver_tudo;
    }
}
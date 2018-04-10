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
            this.btn_fechar = new System.Windows.Forms.Button();
            this.grid_resultados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_resultados)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(374, 438);
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
            this.grid_resultados.Name = "grid_resultados";
            this.grid_resultados.ReadOnly = true;
            this.grid_resultados.RowTemplate.Height = 28;
            this.grid_resultados.Size = new System.Drawing.Size(515, 420);
            this.grid_resultados.TabIndex = 1;
            // 
            // frmResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 548);
            this.ControlBox = false;
            this.Controls.Add(this.grid_resultados);
            this.Controls.Add(this.btn_fechar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmResultados";
            this.Load += new System.EventHandler(this.frmResultados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_resultados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.DataGridView grid_resultados;
    }
}
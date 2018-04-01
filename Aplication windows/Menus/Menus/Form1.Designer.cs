namespace Menus
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
            this.button1 = new System.Windows.Forms.Button();
            this.mn_geral = new System.Windows.Forms.MenuStrip();
            this.mn_file = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_new = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_new_project = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_new_file = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_open = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mn_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.proprietiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mn_cmb = new System.Windows.Forms.ToolStripComboBox();
            this.lbl_resultado = new System.Windows.Forms.Label();
            this.mn_geral.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(775, 325);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 48);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mn_geral
            // 
            this.mn_geral.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mn_geral.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_file,
            this.editToolStripMenuItem,
            this.mn_cmb});
            this.mn_geral.Location = new System.Drawing.Point(0, 0);
            this.mn_geral.Name = "mn_geral";
            this.mn_geral.Size = new System.Drawing.Size(899, 37);
            this.mn_geral.TabIndex = 1;
            this.mn_geral.Text = "menuStrip1";
            // 
            // mn_file
            // 
            this.mn_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_new,
            this.mn_open,
            this.toolStripSeparator1,
            this.mn_exit});
            this.mn_file.Name = "mn_file";
            this.mn_file.Size = new System.Drawing.Size(50, 33);
            this.mn_file.Text = "File";
            // 
            // mn_new
            // 
            this.mn_new.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mn_new_project,
            this.mn_new_file});
            this.mn_new.Name = "mn_new";
            this.mn_new.Size = new System.Drawing.Size(252, 30);
            this.mn_new.Text = "New";
            // 
            // mn_new_project
            // 
            this.mn_new_project.Name = "mn_new_project";
            this.mn_new_project.Size = new System.Drawing.Size(252, 30);
            this.mn_new_project.Text = "Project";
            // 
            // mn_new_file
            // 
            this.mn_new_file.Name = "mn_new_file";
            this.mn_new_file.Size = new System.Drawing.Size(252, 30);
            this.mn_new_file.Text = "File";
            // 
            // mn_open
            // 
            this.mn_open.Name = "mn_open";
            this.mn_open.Size = new System.Drawing.Size(252, 30);
            this.mn_open.Text = "Open";
            this.mn_open.Click += new System.EventHandler(this.mn_open_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(249, 6);
            // 
            // mn_exit
            // 
            this.mn_exit.Name = "mn_exit";
            this.mn_exit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.mn_exit.Size = new System.Drawing.Size(252, 30);
            this.mn_exit.Text = "Exit";
            this.mn_exit.Click += new System.EventHandler(this.mn_exit_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator2,
            this.proprietiesToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(54, 33);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(249, 6);
            // 
            // proprietiesToolStripMenuItem
            // 
            this.proprietiesToolStripMenuItem.Name = "proprietiesToolStripMenuItem";
            this.proprietiesToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.proprietiesToolStripMenuItem.Text = "Propeties...";
            // 
            // mn_cmb
            // 
            this.mn_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.mn_cmb.Name = "mn_cmb";
            this.mn_cmb.Size = new System.Drawing.Size(121, 33);
            this.mn_cmb.SelectedIndexChanged += new System.EventHandler(this.mn_cmb_SelectedIndexChanged);
            // 
            // lbl_resultado
            // 
            this.lbl_resultado.AutoSize = true;
            this.lbl_resultado.Location = new System.Drawing.Point(13, 69);
            this.lbl_resultado.Name = "lbl_resultado";
            this.lbl_resultado.Size = new System.Drawing.Size(86, 20);
            this.lbl_resultado.TabIndex = 2;
            this.lbl_resultado.Text = "Resultado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 385);
            this.Controls.Add(this.lbl_resultado);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.mn_geral);
            this.MainMenuStrip = this.mn_geral;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mn_geral.ResumeLayout(false);
            this.mn_geral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip mn_geral;
        private System.Windows.Forms.ToolStripMenuItem mn_file;
        private System.Windows.Forms.ToolStripMenuItem mn_new;
        private System.Windows.Forms.ToolStripMenuItem mn_open;
        private System.Windows.Forms.ToolStripMenuItem mn_new_project;
        private System.Windows.Forms.ToolStripMenuItem mn_new_file;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mn_exit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem proprietiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox mn_cmb;
        private System.Windows.Forms.Label lbl_resultado;
    }
}


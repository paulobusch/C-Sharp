namespace Formulários
{
    partial class frmUm
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
            this.lbl_resultado_final = new System.Windows.Forms.Label();
            this.lbl_recebe = new System.Windows.Forms.Label();
            this.btn_tranf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_fechar
            // 
            this.btn_fechar.Location = new System.Drawing.Point(187, 297);
            this.btn_fechar.Name = "btn_fechar";
            this.btn_fechar.Size = new System.Drawing.Size(113, 52);
            this.btn_fechar.TabIndex = 2;
            this.btn_fechar.Text = "Fechar";
            this.btn_fechar.UseVisualStyleBackColor = true;
            this.btn_fechar.Click += new System.EventHandler(this.btn_fechar_Click);
            // 
            // lbl_resultado_final
            // 
            this.lbl_resultado_final.AutoSize = true;
            this.lbl_resultado_final.Location = new System.Drawing.Point(13, 13);
            this.lbl_resultado_final.Name = "lbl_resultado_final";
            this.lbl_resultado_final.Size = new System.Drawing.Size(51, 20);
            this.lbl_resultado_final.TabIndex = 3;
            this.lbl_resultado_final.Text = "label1";
            // 
            // lbl_recebe
            // 
            this.lbl_recebe.AutoSize = true;
            this.lbl_recebe.Location = new System.Drawing.Point(13, 91);
            this.lbl_recebe.Name = "lbl_recebe";
            this.lbl_recebe.Size = new System.Drawing.Size(51, 20);
            this.lbl_recebe.TabIndex = 4;
            this.lbl_recebe.Text = "label1";
            // 
            // btn_tranf
            // 
            this.btn_tranf.Location = new System.Drawing.Point(187, 193);
            this.btn_tranf.Name = "btn_tranf";
            this.btn_tranf.Size = new System.Drawing.Size(113, 52);
            this.btn_tranf.TabIndex = 5;
            this.btn_tranf.Text = "Transferir";
            this.btn_tranf.UseVisualStyleBackColor = true;
            this.btn_tranf.Click += new System.EventHandler(this.btn_tranf_Click);
            // 
            // frmUm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 398);
            this.Controls.Add(this.btn_tranf);
            this.Controls.Add(this.lbl_recebe);
            this.Controls.Add(this.lbl_resultado_final);
            this.Controls.Add(this.btn_fechar);
            this.Name = "frmUm";
            this.Text = "frmUm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_fechar;
        private System.Windows.Forms.Label lbl_resultado_final;
        private System.Windows.Forms.Label lbl_recebe;
        private System.Windows.Forms.Button btn_tranf;
    }
}
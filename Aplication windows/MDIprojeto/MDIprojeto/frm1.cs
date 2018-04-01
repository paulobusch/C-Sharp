using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MDIprojeto
{
    public partial class frm1 : Form
    {
        public frm1(Form frmParent)
        {
            InitializeComponent();
            this.MdiParent = frmParent;

            int largura = frmParent.DisplayRectangle.Width;
            int altura = frmParent.DisplayRectangle.Height;

            //posiciona no meio do formulário
            this.Location = new Point(largura / 2 - this.Width / 2,
                                      altura / 2 - this.Height / 2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    class pessoa
    {
        public void Falar(){
            System.Windows.Forms.MessageBox.Show("Falar.");
        }
        public void Correr(){
            System.Windows.Forms.MessageBox.Show("Correr.");
            Saltar();
        }
        private void Saltar(){
            System.Windows.Forms.MessageBox.Show("Saltar.");
        }
    }
}

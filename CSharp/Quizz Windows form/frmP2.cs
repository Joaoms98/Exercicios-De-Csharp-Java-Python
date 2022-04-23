using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class frmP2 : Form
    {
        public frmP2()
        {
            InitializeComponent();
        }

        private void frmP2_Load(object sender, EventArgs e)
        {

        }
        private void botaoProximo_Click_1(object sender, EventArgs e)
        {
            if (rbtnCerta.Checked == true)
            {
                MessageBox.Show("Certa resposta");
                this.Dispose();
                //Somar na varialvel global
                variaveisGlobais.Acertos += 1;
                frmFinal pfinal = new frmFinal(); //chamando proxima janela
                pfinal.ShowDialog();
            }
            else
            {
                MessageBox.Show("Resposta incorreta");
                this.Dispose();
                variaveisGlobais.Erros += 1;
                frmFinal pfinal = new frmFinal();
                pfinal.ShowDialog();
            }
        }
    }
}

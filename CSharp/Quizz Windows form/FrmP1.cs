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
    public partial class FrmP1 : Form
    {
        public FrmP1()
        {
            InitializeComponent();
        }

        private void botaoProximo_Click(object sender, EventArgs e) // botão proximo e contagem de erros e acertos
        {
            if (rbtnCerta.Checked == true)
            {
                MessageBox.Show("Certa resposta");
                this.Dispose();//sobrepor a janela anterior
                //Somar na varialvel global
                variaveisGlobais.Acertos += 1; //acrescentando pontos
                frmP2 p2 = new frmP2();
                p2.ShowDialog();
            }
            else
            {
                MessageBox.Show("Resposta incorreta");
                this.Dispose();
                variaveisGlobais.Erros +=1;
                frmP2 p2 = new frmP2();
                p2.ShowDialog();
            }
        }
        private void FrmP1_Load(object sender, EventArgs e)
        {

        }
    }
}

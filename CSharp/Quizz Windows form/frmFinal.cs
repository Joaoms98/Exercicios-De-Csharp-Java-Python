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
    public partial class frmFinal : Form
    {
        public frmFinal()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmFinal_Load(object sender, EventArgs e)
        {
            lblAcertos.Text=variaveisGlobais.Acertos.ToString(); //instanciando erros e acertos
            lblErros.Text=variaveisGlobais.Erros.ToString();

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close(); // fechando
        }
    }
}

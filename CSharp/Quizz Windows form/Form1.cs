using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media; // biblioteca para rodar o audio

namespace Quiz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer soundPlayer = new SoundPlayer(@"C:\Users\jvm18\Desktop\Quiz\obj\neymusic.wav");  //chamando música
            soundPlayer.Play();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            FrmP1 p1 = new FrmP1();  //intanciando a janela 2 pergunta 1
            p1.ShowDialog();
        }
        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close(); // comando sair
        }
    }
}

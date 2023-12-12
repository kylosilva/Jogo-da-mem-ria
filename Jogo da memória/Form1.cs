using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Jogo_da_memória
{
    public partial class FormPrincipal : Form
    {
        static public bool login = false;
        static public short um = 1;
        static public short zero = 0;

        //static public short menos10 = -10;

        //public short zero2 = 0;
        //public short d10 = 10;

        SoundPlayer Sp = new System.Media.SoundPlayer(Properties.Resources.thejazzpiano);

        const int nCartas = 20;

        public int[] tags = new int[nCartas];

        byte nCliques;
        Button cartaAnterior;
        byte restanteCt = nCartas / 2;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void ButaoLogin_Click(object sender, EventArgs e)
        {
            FormLogin frm = new FormLogin();
            frm.ShowDialog();
            if (login)
            {
                DistribuirCartas();
                AtribuirTags();
                VisibleMenuFalse();
                buttonNiveis.Visible = true;
                pictureBox1.Visible = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            buttonNiveis.Visible = false;
            pictureBox1.Visible = false;

            Ocultar();
            groupBoxDefSom.Visible = false;
            Sp.PlayLooping();

            timer2.Interval = 1000;
            timer2.Enabled = true;
        }

        private void Ocultar()
        {
            foreach (Control x in this.Controls)
                if ((x is Button) && ((x as Button).Tag.ToString() == "c"))
                {
                    (x as Button).Visible = false;
                }
        }

        private void DistribuirCartas()
        {
            foreach (Control x in this.Controls)
                if ((x is Button) && (x.Tag.ToString() == "c"))
                {
                    x.Visible = true;
                    x.BackgroundImage = Properties.Resources.parte_de_tras_da_carta;
                }
        }

        private void pictureBoxDef_Click(object sender, EventArgs e)
        {
            if (groupBoxDefSom.Visible == true)
                groupBoxDefSom.Visible = false;
            else
                groupBoxDefSom.Visible = true;
        }

        private void pictureBoxSomOn_Click(object sender, EventArgs e)
        {
            pictureBoxSomOff.Visible = true;
            pictureBoxSomOn.Visible = false;
            Sp.Stop();
        }

        private void pictureBoxSomOff_Click(object sender, EventArgs e)
        {
            pictureBoxSomOff.Visible = false;
            pictureBoxSomOn.Visible = true;
            Sp.PlayLooping();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            //labelPontos.Visible = true;
            //labelPontosN.Visible = true;

            timer1.Interval = 1000;
            timer1.Enabled = true;

            //labelPontosN.Text = "10";
        }

        private void AtribuirTags()
        {
            Random rnd = new Random();

            int i = 0;
            int n;

            while (i < nCartas)
            {
                n = rnd.Next(1, nCartas + 1);
                if (Array.IndexOf(tags, n) == -1)
                {
                    tags[i] = n;
                    i++;
                }
            }

            for (int j = 0; j < nCartas; j++)
                if (tags[j] > nCartas / 2)
                    tags[j] = tags[j] - (nCartas / 2);

            //for (int j = 0; j < nCartas; j++)
            //MessageBox.Show("tags[" + j + "]=" + tags[j]);

            i = 0;
            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() == "c")
                {
                    x.Tag = tags[i];
                    i++;
                }
        }

        
        private void timer2_Tick(object sender, EventArgs e)
        {
            toolStripStatusData.Text = DateTime.Now.ToLongDateString();
            toolStripStatusHora.Text = DateTime.Now.ToLongTimeString();
        }

        




        private void VisibleMenuFalse()
        {
            pictureBox4.Visible = false;
            ButaoLogin.Visible = false;
        }

        /*
        private bool VerificaçãoDosPares()
        {
            if (tags[0] == tags[1]) { return true; } else { return false; }
        }
        */

        /*private void button1_Click(object sender, EventArgs e)
        {
            Button cartaAtual = (sender as Button);
            string s = "_" + cartaAtual.Tag.ToString();
            object o = Properties.Resources.ResourceManager.GetObject(s);
            cartaAtual.BackgroundImage = (System.Drawing.Image)o;

            if (nCliques == 0)
            {
                cartaAnterior = cartaAtual;
                nCliques++;
            }
            else
                CompararCartas(cartaAnterior, cartaAtual);
        }*/

        private void CompararCartas(Button cAnterior, Button cAtual)
        {
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);
            if (cAnterior == cAtual)
            {
                MessageBox.Show("Selecionou a mesma carta");
                nCliques = 0;
                cAtual.BackgroundImage = Properties.Resources.parte_de_tras_da_carta;
            }
            else
            {
                if (cAtual.Tag.ToString() == cAnterior.Tag.ToString())
                {
                    restanteCt--;
                    nCliques = 0;
                    cAnterior.Visible = false;
                    cAtual.Visible = false;
                    //VerificarSeGanhou();

                    //labelPontosN.Text = "" + zero2;

                    //zero2 += d10;
                }
                else
                {
                    nCliques = 0;
                    cAnterior.BackgroundImage = Properties.Resources.parte_de_tras_da_carta;
                    cAtual.BackgroundImage = Properties.Resources.parte_de_tras_da_carta;
                }
            }
        }

        private void buttonNiveis_Click(object sender, EventArgs e)
        {
            FormNiveis frNiveis = new FormNiveis();
            frNiveis.Show();
        }

        //private void VerificarSeGanhou()
        //{
        //    if (restanteCt == 0)
        //        pictureBoxCarro1.Visible = true;
        //}
    }
}
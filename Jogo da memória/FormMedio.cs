﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jogo_da_memória
{
    public partial class FormMedio : Form
    {
        const int nCartas = 20;

        public int[] tags = new int[nCartas];

        byte nCliques;
        Button cartaAnterior;
        byte restanteCt = nCartas / 2;

        short Segundos = 1;

        public FormMedio()
        {
            InitializeComponent();
        }

        private void ButaoMostrar_Click(object sender, EventArgs e)
        {
            //zero2 -= menos10;

            //labelPontosN.Text = "" + zero2;

            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() != "o")
                {
                    string s = "medio" + x.Tag.ToString();
                    object o = Properties.Resources.ResourceManager.GetObject(s);
                    x.BackgroundImage = (System.Drawing.Image)o;
                }

            Application.DoEvents();
            System.Threading.Thread.Sleep(800);

            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() != "o")
                    x.BackgroundImage = Properties.Resources.parte_de_tras_da_carta;
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
                    VerificarSeGanhou();

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

        private void FormMedio_Load(object sender, EventArgs e)
        {
            AtribuirTags();
            DistribuirCartas();

            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() != "o")
                {
                    string s = "medio" + x.Tag.ToString();
                    object o = Properties.Resources.ResourceManager.GetObject(s);
                    x.BackgroundImage = (System.Drawing.Image)o;
                }

            Application.DoEvents();
            System.Threading.Thread.Sleep(1);

            foreach (Control x in this.Controls)
                if (x is Button && x.Tag.ToString() != "o")
                    x.BackgroundImage = Properties.Resources.parte_de_tras_da_carta;

            timer1.Interval = 1000;
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button cartaAtual = (sender as Button);
            string s = "medio" + cartaAtual.Tag.ToString();
            object o = Properties.Resources.ResourceManager.GetObject(s);
            cartaAtual.BackgroundImage = (System.Drawing.Image)o;

            if (nCliques == 0)
            {
                cartaAnterior = cartaAtual;
                nCliques++;
            }
            else
                CompararCartas(cartaAnterior, cartaAtual);
        }

        private void ButaoJogarDeNovo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelTempoS.Text = "" + Segundos + "s";
            Segundos++;
        }

        private void VerificarSeGanhou()
        {
            if (restanteCt == 0)
            {
                timer1.Enabled = false;
                FormGanhou frG = new FormGanhou();
                frG.Show();
                ButaoMostrar.Visible = false;
            }
        }
    }
}

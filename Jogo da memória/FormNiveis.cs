using System;
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
    public partial class FormNiveis : Form
    {
        public FormNiveis()
        {
            InitializeComponent();
        }

        private void buttonFacil_Click(object sender, EventArgs e)
        {
            FormNivelFacil frF = new FormNivelFacil();
            frF.Show();
        }

        private void ButaoMedio_Click(object sender, EventArgs e)
        {
            FormMedio frM = new FormMedio();
            frM.Show();
        }

        private void buttonDificil_Click(object sender, EventArgs e)
        {
            FormDificil frDif = new FormDificil();
            frDif.Show();
        }

        private void buttonImpossivel_Click(object sender, EventArgs e)
        {
            FormImpossivel frImp = new FormImpossivel();
            frImp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCreditos frC = new FormCreditos();
            frC.Show();
        }
    }
}

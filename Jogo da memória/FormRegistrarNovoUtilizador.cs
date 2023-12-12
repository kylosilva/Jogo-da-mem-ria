using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Jogo_da_memória
{
    public partial class FormRegistrarNovoUtilizador : Form
    {
        string pathCd = "credenciais.txt";
        public FormRegistrarNovoUtilizador()
        {
            InitializeComponent();
        }

        private void BotaoCriar_Click(object sender, EventArgs e)
        {
            if(textBoxUsername2.Text!="" && textBoxPass1.Text!="")
            {
                if (textBoxPass1.Text == textBoxPass2.Text)
                {
                    if (!UtilizadorJaExistente(textBoxUsername2.Text))
                        RegistarDadosUtilz(textBoxUsername2.Text, textBoxPass1.Text);
                    else
                        MessageBox.Show("Utilizador já existente!!");
                }
                else
                {
                    MessageBox.Show("As passwords não correspondem!!");
                    textBoxPass1.Text = "";
                    textBoxPass2.Text = "";
                    textBoxPass1.Focus();
                }
                    
            }
        }

        private bool UtilizadorJaExistente(string user)
        {
            if(File.Exists(pathCd))
            {
                try
                {
                    string[] users = File.ReadAllLines(pathCd);
                    foreach (string linhaUser in users)
                    {
                        string[] dadosUser = linhaUser.Split('#');
                        if (dadosUser[0] == user) return true;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
            return false;
        }

        private void RegistarDadosUtilz(string user, string pass)
        {
            try
            {
                string texto = "\n" + user + "#" + pass;
                File.AppendAllText(pathCd, texto);
                MessageBox.Show("Novo utilizador registado com suceso!!");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
            this.Close();
        }

        private void ButaoCancelar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

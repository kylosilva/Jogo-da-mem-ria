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
    public partial class FormLogin : Form
    {
        static public string pathCd = "credenciais.txt";

        public FormLogin()
        {
            InitializeComponent();
            pictureBoxMacacoNaoVe.Visible = false;
        }

        private void linkLabelMostrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            if(textBoxPass.UseSystemPasswordChar)
            {
                pictureBoxMacacoNaoVe.Visible = true;
                textBoxPass.UseSystemPasswordChar = false;
                return;
            }

            textBoxPass.UseSystemPasswordChar = true;
            pictureBoxMacacoNaoVe.Visible = false;

        }

        private void BotaoEntrar_Click(object sender, EventArgs e)
        {
            FormPrincipal.login = false;
            string user = textBoxUsername.Text;
            string pass = textBoxPass.Text;

            FormPrincipal.login = false;
            if ((textBoxUsername.Text == "Silva") && (textBoxPass.Text == "Silva"))
                FormPrincipal.login = true;
            else
                FormPrincipal.login = VerificarCredenciais(user, pass);
            this.Close();
        }

        private bool VerificarCredenciais(string us, string ps)
        {
            if(File.Exists(pathCd))
            {
                try
                {
                    string[] users = File.ReadAllLines(pathCd);
                    foreach (string user in users)
                    {
                        string[] dadosUsers = user.Split('#');
                        if (dadosUsers[0] == us && dadosUsers[1] == ps)
                            return true;
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
            MessageBox.Show("Credenciais de utilizador não encontradas");
            return false;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void ButaoCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void linkLabelCrearConta_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegistrarNovoUtilizador frm = new FormRegistrarNovoUtilizador();
            frm.ShowDialog();
        }
    }
}


namespace Jogo_da_memória
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.linkLabelMostrar = new System.Windows.Forms.LinkLabel();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.ButaoCancelar = new System.Windows.Forms.Button();
            this.BotaoEntrar = new System.Windows.Forms.Button();
            this.pictureBoxMacacoNaoVe = new System.Windows.Forms.PictureBox();
            this.pictureBoxMacacoVe = new System.Windows.Forms.PictureBox();
            this.linkLabelCrearConta = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMacacoNaoVe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMacacoVe)).BeginInit();
            this.SuspendLayout();
            // 
            // linkLabelMostrar
            // 
            this.linkLabelMostrar.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabelMostrar.AutoSize = true;
            this.linkLabelMostrar.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelMostrar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkLabelMostrar.Location = new System.Drawing.Point(468, 293);
            this.linkLabelMostrar.Name = "linkLabelMostrar";
            this.linkLabelMostrar.Size = new System.Drawing.Size(56, 15);
            this.linkLabelMostrar.TabIndex = 1;
            this.linkLabelMostrar.TabStop = true;
            this.linkLabelMostrar.Text = "Mostrar";
            this.linkLabelMostrar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelMostrar_LinkClicked);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.Peru;
            this.textBoxUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxUsername.Location = new System.Drawing.Point(222, 258);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(240, 22);
            this.textBoxUsername.TabIndex = 2;
            this.textBoxUsername.Text = "username";
            // 
            // textBoxPass
            // 
            this.textBoxPass.BackColor = System.Drawing.Color.Peru;
            this.textBoxPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPass.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxPass.Location = new System.Drawing.Point(222, 287);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(240, 22);
            this.textBoxPass.TabIndex = 3;
            this.textBoxPass.Text = "password";
            this.textBoxPass.UseSystemPasswordChar = true;
            // 
            // ButaoCancelar
            // 
            this.ButaoCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButaoCancelar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButaoCancelar.Image = global::Jogo_da_memória.Properties.Resources.fds;
            this.ButaoCancelar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.ButaoCancelar.Location = new System.Drawing.Point(222, 315);
            this.ButaoCancelar.Name = "ButaoCancelar";
            this.ButaoCancelar.Size = new System.Drawing.Size(114, 34);
            this.ButaoCancelar.TabIndex = 5;
            this.ButaoCancelar.Text = "Cancelar";
            this.ButaoCancelar.UseVisualStyleBackColor = true;
            this.ButaoCancelar.Click += new System.EventHandler(this.ButaoCancelar_Click);
            // 
            // BotaoEntrar
            // 
            this.BotaoEntrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoEntrar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoEntrar.Image = global::Jogo_da_memória.Properties.Resources.fds;
            this.BotaoEntrar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.BotaoEntrar.Location = new System.Drawing.Point(348, 315);
            this.BotaoEntrar.Name = "BotaoEntrar";
            this.BotaoEntrar.Size = new System.Drawing.Size(114, 34);
            this.BotaoEntrar.TabIndex = 4;
            this.BotaoEntrar.Text = "Entrar";
            this.BotaoEntrar.UseVisualStyleBackColor = true;
            this.BotaoEntrar.Click += new System.EventHandler(this.BotaoEntrar_Click);
            // 
            // pictureBoxMacacoNaoVe
            // 
            this.pictureBoxMacacoNaoVe.Image = global::Jogo_da_memória.Properties.Resources.cego;
            this.pictureBoxMacacoNaoVe.Location = new System.Drawing.Point(222, 12);
            this.pictureBoxMacacoNaoVe.Name = "pictureBoxMacacoNaoVe";
            this.pictureBoxMacacoNaoVe.Size = new System.Drawing.Size(240, 240);
            this.pictureBoxMacacoNaoVe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMacacoNaoVe.TabIndex = 6;
            this.pictureBoxMacacoNaoVe.TabStop = false;
            // 
            // pictureBoxMacacoVe
            // 
            this.pictureBoxMacacoVe.Image = global::Jogo_da_memória.Properties.Resources.mudo;
            this.pictureBoxMacacoVe.Location = new System.Drawing.Point(222, 12);
            this.pictureBoxMacacoVe.Name = "pictureBoxMacacoVe";
            this.pictureBoxMacacoVe.Size = new System.Drawing.Size(240, 240);
            this.pictureBoxMacacoVe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMacacoVe.TabIndex = 0;
            this.pictureBoxMacacoVe.TabStop = false;
            // 
            // linkLabelCrearConta
            // 
            this.linkLabelCrearConta.ActiveLinkColor = System.Drawing.Color.Black;
            this.linkLabelCrearConta.AutoSize = true;
            this.linkLabelCrearConta.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabelCrearConta.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.linkLabelCrearConta.Location = new System.Drawing.Point(284, 352);
            this.linkLabelCrearConta.Name = "linkLabelCrearConta";
            this.linkLabelCrearConta.Size = new System.Drawing.Size(122, 24);
            this.linkLabelCrearConta.TabIndex = 7;
            this.linkLabelCrearConta.TabStop = true;
            this.linkLabelCrearConta.Text = "Criar Conda";
            this.linkLabelCrearConta.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCrearConta_LinkClicked);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(687, 380);
            this.Controls.Add(this.linkLabelCrearConta);
            this.Controls.Add(this.ButaoCancelar);
            this.Controls.Add(this.BotaoEntrar);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxUsername);
            this.Controls.Add(this.linkLabelMostrar);
            this.Controls.Add(this.pictureBoxMacacoNaoVe);
            this.Controls.Add(this.pictureBoxMacacoVe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMacacoNaoVe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMacacoVe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMacacoVe;
        private System.Windows.Forms.LinkLabel linkLabelMostrar;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Button BotaoEntrar;
        private System.Windows.Forms.Button ButaoCancelar;
        private System.Windows.Forms.PictureBox pictureBoxMacacoNaoVe;
        private System.Windows.Forms.LinkLabel linkLabelCrearConta;
    }
}
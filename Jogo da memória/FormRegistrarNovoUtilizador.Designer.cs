
namespace Jogo_da_memória
{
    partial class FormRegistrarNovoUtilizador
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
            this.ButaoCancelar2 = new System.Windows.Forms.Button();
            this.BotaoCriar = new System.Windows.Forms.Button();
            this.textBoxPass1 = new System.Windows.Forms.TextBox();
            this.textBoxUsername2 = new System.Windows.Forms.TextBox();
            this.pictureBoxMacacoNaoVe = new System.Windows.Forms.PictureBox();
            this.pictureBoxMacacoVe = new System.Windows.Forms.PictureBox();
            this.textBoxPass2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMacacoNaoVe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMacacoVe)).BeginInit();
            this.SuspendLayout();
            // 
            // ButaoCancelar2
            // 
            this.ButaoCancelar2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButaoCancelar2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButaoCancelar2.Image = global::Jogo_da_memória.Properties.Resources.fds;
            this.ButaoCancelar2.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.ButaoCancelar2.Location = new System.Drawing.Point(218, 322);
            this.ButaoCancelar2.Name = "ButaoCancelar2";
            this.ButaoCancelar2.Size = new System.Drawing.Size(248, 34);
            this.ButaoCancelar2.TabIndex = 14;
            this.ButaoCancelar2.Text = "{ ------- Cancelar ------- }";
            this.ButaoCancelar2.UseVisualStyleBackColor = true;
            this.ButaoCancelar2.Click += new System.EventHandler(this.ButaoCancelar2_Click);
            // 
            // BotaoCriar
            // 
            this.BotaoCriar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BotaoCriar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoCriar.Image = global::Jogo_da_memória.Properties.Resources.fds;
            this.BotaoCriar.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.BotaoCriar.Location = new System.Drawing.Point(218, 282);
            this.BotaoCriar.Name = "BotaoCriar";
            this.BotaoCriar.Size = new System.Drawing.Size(248, 34);
            this.BotaoCriar.TabIndex = 13;
            this.BotaoCriar.Text = "{ ------- Criar ------- }";
            this.BotaoCriar.UseVisualStyleBackColor = true;
            this.BotaoCriar.Click += new System.EventHandler(this.BotaoCriar_Click);
            // 
            // textBoxPass1
            // 
            this.textBoxPass1.BackColor = System.Drawing.Color.Peru;
            this.textBoxPass1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPass1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxPass1.Location = new System.Drawing.Point(218, 217);
            this.textBoxPass1.Name = "textBoxPass1";
            this.textBoxPass1.Size = new System.Drawing.Size(248, 22);
            this.textBoxPass1.TabIndex = 11;
            this.textBoxPass1.Text = "password";
            // 
            // textBoxUsername2
            // 
            this.textBoxUsername2.BackColor = System.Drawing.Color.Peru;
            this.textBoxUsername2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxUsername2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUsername2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxUsername2.Location = new System.Drawing.Point(218, 189);
            this.textBoxUsername2.Name = "textBoxUsername2";
            this.textBoxUsername2.Size = new System.Drawing.Size(248, 22);
            this.textBoxUsername2.TabIndex = 10;
            this.textBoxUsername2.Text = "username";
            // 
            // pictureBoxMacacoNaoVe
            // 
            this.pictureBoxMacacoNaoVe.Image = global::Jogo_da_memória.Properties.Resources.cego;
            this.pictureBoxMacacoNaoVe.Location = new System.Drawing.Point(-17, -1);
            this.pictureBoxMacacoNaoVe.Name = "pictureBoxMacacoNaoVe";
            this.pictureBoxMacacoNaoVe.Size = new System.Drawing.Size(240, 240);
            this.pictureBoxMacacoNaoVe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMacacoNaoVe.TabIndex = 14;
            this.pictureBoxMacacoNaoVe.TabStop = false;
            // 
            // pictureBoxMacacoVe
            // 
            this.pictureBoxMacacoVe.Image = global::Jogo_da_memória.Properties.Resources.mudo;
            this.pictureBoxMacacoVe.Location = new System.Drawing.Point(463, -1);
            this.pictureBoxMacacoVe.Name = "pictureBoxMacacoVe";
            this.pictureBoxMacacoVe.Size = new System.Drawing.Size(240, 240);
            this.pictureBoxMacacoVe.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMacacoVe.TabIndex = 8;
            this.pictureBoxMacacoVe.TabStop = false;
            // 
            // textBoxPass2
            // 
            this.textBoxPass2.BackColor = System.Drawing.Color.Peru;
            this.textBoxPass2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPass2.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBoxPass2.Location = new System.Drawing.Point(218, 245);
            this.textBoxPass2.Name = "textBoxPass2";
            this.textBoxPass2.Size = new System.Drawing.Size(248, 22);
            this.textBoxPass2.TabIndex = 12;
            this.textBoxPass2.Text = "password";
            // 
            // FormRegistrarNovoUtilizador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(687, 380);
            this.Controls.Add(this.textBoxPass2);
            this.Controls.Add(this.ButaoCancelar2);
            this.Controls.Add(this.BotaoCriar);
            this.Controls.Add(this.textBoxPass1);
            this.Controls.Add(this.textBoxUsername2);
            this.Controls.Add(this.pictureBoxMacacoNaoVe);
            this.Controls.Add(this.pictureBoxMacacoVe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegistrarNovoUtilizador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegistrarNovoUtilizador";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMacacoNaoVe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMacacoVe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButaoCancelar2;
        private System.Windows.Forms.Button BotaoCriar;
        private System.Windows.Forms.TextBox textBoxPass1;
        private System.Windows.Forms.TextBox textBoxUsername2;
        private System.Windows.Forms.PictureBox pictureBoxMacacoNaoVe;
        private System.Windows.Forms.PictureBox pictureBoxMacacoVe;
        private System.Windows.Forms.TextBox textBoxPass2;
    }
}
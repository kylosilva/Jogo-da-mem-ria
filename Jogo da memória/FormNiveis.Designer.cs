
namespace Jogo_da_memória
{
    partial class FormNiveis
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
            this.ButaoMedio = new System.Windows.Forms.Button();
            this.buttonDificil = new System.Windows.Forms.Button();
            this.buttonImpossivel = new System.Windows.Forms.Button();
            this.buttonFacil = new System.Windows.Forms.Button();
            this.labelSelecioneDif = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButaoMedio
            // 
            this.ButaoMedio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButaoMedio.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButaoMedio.Image = global::Jogo_da_memória.Properties.Resources.fds;
            this.ButaoMedio.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.ButaoMedio.Location = new System.Drawing.Point(90, 142);
            this.ButaoMedio.Name = "ButaoMedio";
            this.ButaoMedio.Size = new System.Drawing.Size(628, 50);
            this.ButaoMedio.TabIndex = 22;
            this.ButaoMedio.Tag = "o";
            this.ButaoMedio.Text = "{ ------- Médio ------- }";
            this.ButaoMedio.UseVisualStyleBackColor = true;
            this.ButaoMedio.Click += new System.EventHandler(this.ButaoMedio_Click);
            // 
            // buttonDificil
            // 
            this.buttonDificil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDificil.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDificil.Image = global::Jogo_da_memória.Properties.Resources.fds;
            this.buttonDificil.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonDificil.Location = new System.Drawing.Point(90, 198);
            this.buttonDificil.Name = "buttonDificil";
            this.buttonDificil.Size = new System.Drawing.Size(628, 50);
            this.buttonDificil.TabIndex = 23;
            this.buttonDificil.Tag = "o";
            this.buttonDificil.Text = "{ ------- Difícil ------- }";
            this.buttonDificil.UseVisualStyleBackColor = true;
            this.buttonDificil.Click += new System.EventHandler(this.buttonDificil_Click);
            // 
            // buttonImpossivel
            // 
            this.buttonImpossivel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonImpossivel.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonImpossivel.Image = global::Jogo_da_memória.Properties.Resources.fds;
            this.buttonImpossivel.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonImpossivel.Location = new System.Drawing.Point(90, 254);
            this.buttonImpossivel.Name = "buttonImpossivel";
            this.buttonImpossivel.Size = new System.Drawing.Size(628, 50);
            this.buttonImpossivel.TabIndex = 24;
            this.buttonImpossivel.Tag = "o";
            this.buttonImpossivel.Text = "{ ------- Impossivel ------- }";
            this.buttonImpossivel.UseVisualStyleBackColor = true;
            this.buttonImpossivel.Click += new System.EventHandler(this.buttonImpossivel_Click);
            // 
            // buttonFacil
            // 
            this.buttonFacil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFacil.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFacil.Image = global::Jogo_da_memória.Properties.Resources.fds;
            this.buttonFacil.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonFacil.Location = new System.Drawing.Point(90, 86);
            this.buttonFacil.Name = "buttonFacil";
            this.buttonFacil.Size = new System.Drawing.Size(628, 50);
            this.buttonFacil.TabIndex = 25;
            this.buttonFacil.Tag = "o";
            this.buttonFacil.Text = "{ ------- Facil ------- }";
            this.buttonFacil.UseVisualStyleBackColor = true;
            this.buttonFacil.Click += new System.EventHandler(this.buttonFacil_Click);
            // 
            // labelSelecioneDif
            // 
            this.labelSelecioneDif.AutoSize = true;
            this.labelSelecioneDif.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelecioneDif.Location = new System.Drawing.Point(235, 10);
            this.labelSelecioneDif.Name = "labelSelecioneDif";
            this.labelSelecioneDif.Size = new System.Drawing.Size(338, 34);
            this.labelSelecioneDif.TabIndex = 26;
            this.labelSelecioneDif.Text = "Selecione a dificuldade";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = global::Jogo_da_memória.Properties.Resources.fds;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.Location = new System.Drawing.Point(90, 331);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(628, 50);
            this.button1.TabIndex = 27;
            this.button1.Tag = "o";
            this.button1.Text = "{ ------- Créditos ------- }";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormNiveis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(800, 388);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelSelecioneDif);
            this.Controls.Add(this.buttonFacil);
            this.Controls.Add(this.buttonImpossivel);
            this.Controls.Add(this.buttonDificil);
            this.Controls.Add(this.ButaoMedio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormNiveis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormNiveis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButaoMedio;
        private System.Windows.Forms.Button buttonDificil;
        private System.Windows.Forms.Button buttonImpossivel;
        private System.Windows.Forms.Button buttonFacil;
        private System.Windows.Forms.Label labelSelecioneDif;
        private System.Windows.Forms.Button button1;
    }
}
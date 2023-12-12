
namespace Jogo_da_memória
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPrincipal));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusAutor = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBoxDefSom = new System.Windows.Forms.GroupBox();
            this.pictureBoxIconSom = new System.Windows.Forms.PictureBox();
            this.pictureBoxSomOn = new System.Windows.Forms.PictureBox();
            this.pictureBoxSomOff = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.labelO2 = new System.Windows.Forms.Label();
            this.labelM = new System.Windows.Forms.Label();
            this.labelE = new System.Windows.Forms.Label();
            this.labelM2 = new System.Windows.Forms.Label();
            this.labelR = new System.Windows.Forms.Label();
            this.labelI = new System.Windows.Forms.Label();
            this.labelA2 = new System.Windows.Forms.Label();
            this.labelD = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.labelG = new System.Windows.Forms.Label();
            this.labelO = new System.Windows.Forms.Label();
            this.labelJ = new System.Windows.Forms.Label();
            this.buttonNiveis = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxDef = new System.Windows.Forms.PictureBox();
            this.ButaoLogin = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBoxCerebro = new System.Windows.Forms.PictureBox();
            this.pictureBoxCarro1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.groupBoxDefSom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconSom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSomOn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSomOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDef)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerebro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarro1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusAutor,
            this.toolStripStatusLabel1,
            this.toolStripStatusData,
            this.toolStripStatusLabel2,
            this.toolStripStatusHora});
            this.statusStrip1.Location = new System.Drawing.Point(0, 676);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1370, 22);
            this.statusStrip1.TabIndex = 25;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusAutor
            // 
            this.toolStripStatusAutor.Name = "toolStripStatusAutor";
            this.toolStripStatusAutor.Size = new System.Drawing.Size(133, 17);
            this.toolStripStatusAutor.Text = "©Leonardo Santos Silva";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabel1.Text = "||";
            // 
            // toolStripStatusData
            // 
            this.toolStripStatusData.Name = "toolStripStatusData";
            this.toolStripStatusData.Size = new System.Drawing.Size(65, 17);
            this.toolStripStatusData.Text = "19/09/2023";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabel2.Text = "||";
            // 
            // toolStripStatusHora
            // 
            this.toolStripStatusHora.Name = "toolStripStatusHora";
            this.toolStripStatusHora.Size = new System.Drawing.Size(34, 17);
            this.toolStripStatusHora.Text = "16:00";
            // 
            // groupBoxDefSom
            // 
            this.groupBoxDefSom.Controls.Add(this.pictureBoxIconSom);
            this.groupBoxDefSom.Controls.Add(this.pictureBoxSomOn);
            this.groupBoxDefSom.Controls.Add(this.pictureBoxSomOff);
            this.groupBoxDefSom.Location = new System.Drawing.Point(1223, 64);
            this.groupBoxDefSom.Name = "groupBoxDefSom";
            this.groupBoxDefSom.Size = new System.Drawing.Size(147, 74);
            this.groupBoxDefSom.TabIndex = 44;
            this.groupBoxDefSom.TabStop = false;
            // 
            // pictureBoxIconSom
            // 
            this.pictureBoxIconSom.Image = global::Jogo_da_memória.Properties.Resources.Som;
            this.pictureBoxIconSom.Location = new System.Drawing.Point(6, 10);
            this.pictureBoxIconSom.Name = "pictureBoxIconSom";
            this.pictureBoxIconSom.Size = new System.Drawing.Size(61, 58);
            this.pictureBoxIconSom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxIconSom.TabIndex = 0;
            this.pictureBoxIconSom.TabStop = false;
            // 
            // pictureBoxSomOn
            // 
            this.pictureBoxSomOn.Image = global::Jogo_da_memória.Properties.Resources.On_Off_removebg_preview__1_;
            this.pictureBoxSomOn.Location = new System.Drawing.Point(73, 19);
            this.pictureBoxSomOn.Name = "pictureBoxSomOn";
            this.pictureBoxSomOn.Size = new System.Drawing.Size(62, 39);
            this.pictureBoxSomOn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSomOn.TabIndex = 1;
            this.pictureBoxSomOn.TabStop = false;
            this.pictureBoxSomOn.Click += new System.EventHandler(this.pictureBoxSomOn_Click);
            // 
            // pictureBoxSomOff
            // 
            this.pictureBoxSomOff.Image = global::Jogo_da_memória.Properties.Resources.On_Off_removebg_preview__2_;
            this.pictureBoxSomOff.Location = new System.Drawing.Point(73, 20);
            this.pictureBoxSomOff.Name = "pictureBoxSomOff";
            this.pictureBoxSomOff.Size = new System.Drawing.Size(62, 39);
            this.pictureBoxSomOff.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxSomOff.TabIndex = 2;
            this.pictureBoxSomOff.TabStop = false;
            this.pictureBoxSomOff.Click += new System.EventHandler(this.pictureBoxSomOff_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // labelO2
            // 
            this.labelO2.AutoSize = true;
            this.labelO2.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelO2.Location = new System.Drawing.Point(663, 30);
            this.labelO2.Name = "labelO2";
            this.labelO2.Size = new System.Drawing.Size(41, 38);
            this.labelO2.TabIndex = 54;
            this.labelO2.Tag = "o";
            this.labelO2.Text = "O";
            // 
            // labelM
            // 
            this.labelM.AutoSize = true;
            this.labelM.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelM.Location = new System.Drawing.Point(545, 87);
            this.labelM.Name = "labelM";
            this.labelM.Size = new System.Drawing.Size(50, 38);
            this.labelM.TabIndex = 63;
            this.labelM.Tag = "o";
            this.labelM.Text = "M";
            // 
            // labelE
            // 
            this.labelE.AutoSize = true;
            this.labelE.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelE.Location = new System.Drawing.Point(585, 87);
            this.labelE.Name = "labelE";
            this.labelE.Size = new System.Drawing.Size(44, 38);
            this.labelE.TabIndex = 62;
            this.labelE.Tag = "o";
            this.labelE.Text = "E";
            // 
            // labelM2
            // 
            this.labelM2.AutoSize = true;
            this.labelM2.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelM2.Location = new System.Drawing.Point(619, 87);
            this.labelM2.Name = "labelM2";
            this.labelM2.Size = new System.Drawing.Size(50, 38);
            this.labelM2.TabIndex = 61;
            this.labelM2.Tag = "o";
            this.labelM2.Text = "M";
            // 
            // labelR
            // 
            this.labelR.AutoSize = true;
            this.labelR.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelR.Location = new System.Drawing.Point(721, 87);
            this.labelR.Name = "labelR";
            this.labelR.Size = new System.Drawing.Size(44, 38);
            this.labelR.TabIndex = 60;
            this.labelR.Tag = "o";
            this.labelR.Text = "R";
            // 
            // labelI
            // 
            this.labelI.AutoSize = true;
            this.labelI.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelI.Location = new System.Drawing.Point(758, 87);
            this.labelI.Name = "labelI";
            this.labelI.Size = new System.Drawing.Size(33, 38);
            this.labelI.TabIndex = 59;
            this.labelI.Tag = "o";
            this.labelI.Text = "I";
            // 
            // labelA2
            // 
            this.labelA2.AutoSize = true;
            this.labelA2.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA2.Location = new System.Drawing.Point(781, 87);
            this.labelA2.Name = "labelA2";
            this.labelA2.Size = new System.Drawing.Size(44, 38);
            this.labelA2.TabIndex = 58;
            this.labelA2.Tag = "o";
            this.labelA2.Text = "A";
            // 
            // labelD
            // 
            this.labelD.AutoSize = true;
            this.labelD.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelD.Location = new System.Drawing.Point(723, 30);
            this.labelD.Name = "labelD";
            this.labelD.Size = new System.Drawing.Size(45, 38);
            this.labelD.TabIndex = 57;
            this.labelD.Tag = "o";
            this.labelD.Text = "D";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelA.Location = new System.Drawing.Point(759, 30);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(44, 38);
            this.labelA.TabIndex = 56;
            this.labelA.Tag = "o";
            this.labelA.Text = "A";
            // 
            // labelG
            // 
            this.labelG.AutoSize = true;
            this.labelG.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelG.Location = new System.Drawing.Point(630, 30);
            this.labelG.Name = "labelG";
            this.labelG.Size = new System.Drawing.Size(43, 38);
            this.labelG.TabIndex = 55;
            this.labelG.Tag = "o";
            this.labelG.Text = "G";
            // 
            // labelO
            // 
            this.labelO.AutoSize = true;
            this.labelO.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelO.Location = new System.Drawing.Point(598, 30);
            this.labelO.Name = "labelO";
            this.labelO.Size = new System.Drawing.Size(41, 38);
            this.labelO.TabIndex = 53;
            this.labelO.Tag = "o";
            this.labelO.Text = "O";
            // 
            // labelJ
            // 
            this.labelJ.AutoSize = true;
            this.labelJ.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJ.Location = new System.Drawing.Point(570, 30);
            this.labelJ.Name = "labelJ";
            this.labelJ.Size = new System.Drawing.Size(35, 38);
            this.labelJ.TabIndex = 52;
            this.labelJ.Tag = "o";
            this.labelJ.Text = "J";
            // 
            // buttonNiveis
            // 
            this.buttonNiveis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNiveis.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNiveis.Image = global::Jogo_da_memória.Properties.Resources.fds;
            this.buttonNiveis.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.buttonNiveis.Location = new System.Drawing.Point(374, 399);
            this.buttonNiveis.Name = "buttonNiveis";
            this.buttonNiveis.Size = new System.Drawing.Size(628, 50);
            this.buttonNiveis.TabIndex = 65;
            this.buttonNiveis.Tag = "o";
            this.buttonNiveis.Text = "{ ------- Niveis ------- }";
            this.buttonNiveis.UseVisualStyleBackColor = true;
            this.buttonNiveis.Click += new System.EventHandler(this.buttonNiveis_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Jogo_da_memória.Properties.Resources.extra;
            this.pictureBox1.Location = new System.Drawing.Point(374, 399);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(628, 74);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "o";
            // 
            // pictureBoxDef
            // 
            this.pictureBoxDef.Image = global::Jogo_da_memória.Properties.Resources.DefenicoesJogos;
            this.pictureBoxDef.Location = new System.Drawing.Point(1303, 12);
            this.pictureBoxDef.Name = "pictureBoxDef";
            this.pictureBoxDef.Size = new System.Drawing.Size(55, 46);
            this.pictureBoxDef.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxDef.TabIndex = 43;
            this.pictureBoxDef.TabStop = false;
            this.pictureBoxDef.Click += new System.EventHandler(this.pictureBoxDef_Click);
            // 
            // ButaoLogin
            // 
            this.ButaoLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButaoLogin.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButaoLogin.Image = global::Jogo_da_memória.Properties.Resources.fds;
            this.ButaoLogin.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.ButaoLogin.Location = new System.Drawing.Point(374, 399);
            this.ButaoLogin.Name = "ButaoLogin";
            this.ButaoLogin.Size = new System.Drawing.Size(628, 50);
            this.ButaoLogin.TabIndex = 21;
            this.ButaoLogin.Tag = "o";
            this.ButaoLogin.Text = "{ ------- Login ------- }";
            this.ButaoLogin.UseVisualStyleBackColor = true;
            this.ButaoLogin.Click += new System.EventHandler(this.ButaoLogin_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Jogo_da_memória.Properties.Resources.extra;
            this.pictureBox4.Location = new System.Drawing.Point(374, 399);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(628, 74);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 41;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "o";
            // 
            // pictureBoxCerebro
            // 
            this.pictureBoxCerebro.Image = global::Jogo_da_memória.Properties.Resources.cute_cartoon_brain_brain_illustration_png;
            this.pictureBoxCerebro.Location = new System.Drawing.Point(658, 71);
            this.pictureBoxCerebro.Name = "pictureBoxCerebro";
            this.pictureBoxCerebro.Size = new System.Drawing.Size(70, 66);
            this.pictureBoxCerebro.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCerebro.TabIndex = 64;
            this.pictureBoxCerebro.TabStop = false;
            this.pictureBoxCerebro.Tag = "o";
            // 
            // pictureBoxCarro1
            // 
            this.pictureBoxCarro1.Image = global::Jogo_da_memória.Properties.Resources.Carro_de_Imagem;
            this.pictureBoxCarro1.Location = new System.Drawing.Point(374, 30);
            this.pictureBoxCarro1.Name = "pictureBoxCarro1";
            this.pictureBoxCarro1.Size = new System.Drawing.Size(628, 522);
            this.pictureBoxCarro1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCarro1.TabIndex = 51;
            this.pictureBoxCarro1.TabStop = false;
            this.pictureBoxCarro1.Tag = "o";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Khaki;
            this.ClientSize = new System.Drawing.Size(1370, 698);
            this.Controls.Add(this.buttonNiveis);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBoxDefSom);
            this.Controls.Add(this.pictureBoxDef);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ButaoLogin);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.labelO2);
            this.Controls.Add(this.labelM);
            this.Controls.Add(this.labelE);
            this.Controls.Add(this.labelM2);
            this.Controls.Add(this.labelR);
            this.Controls.Add(this.labelI);
            this.Controls.Add(this.labelA2);
            this.Controls.Add(this.labelD);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.labelG);
            this.Controls.Add(this.labelO);
            this.Controls.Add(this.labelJ);
            this.Controls.Add(this.pictureBoxCerebro);
            this.Controls.Add(this.pictureBoxCarro1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jogo da Memória";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBoxDefSom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIconSom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSomOn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSomOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDef)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCerebro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCarro1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusAutor;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusData;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusHora;
        private System.Windows.Forms.PictureBox pictureBoxDef;
        private System.Windows.Forms.GroupBox groupBoxDefSom;
        private System.Windows.Forms.PictureBox pictureBoxIconSom;
        private System.Windows.Forms.PictureBox pictureBoxSomOn;
        private System.Windows.Forms.PictureBox pictureBoxSomOff;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button ButaoLogin;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label labelO2;
        private System.Windows.Forms.Label labelM;
        private System.Windows.Forms.Label labelE;
        private System.Windows.Forms.Label labelM2;
        private System.Windows.Forms.Label labelR;
        private System.Windows.Forms.Label labelI;
        private System.Windows.Forms.Label labelA2;
        private System.Windows.Forms.Label labelD;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelG;
        private System.Windows.Forms.Label labelO;
        private System.Windows.Forms.Label labelJ;
        private System.Windows.Forms.PictureBox pictureBoxCerebro;
        private System.Windows.Forms.PictureBox pictureBoxCarro1;
        private System.Windows.Forms.Button buttonNiveis;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}


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
    public partial class FormCreditos : Form
    {
        public FormCreditos()
        {
            InitializeComponent();
        }

        private void FormCreditos_Load(object sender, EventArgs e)
        {

        }

        private void ButaoDnv_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

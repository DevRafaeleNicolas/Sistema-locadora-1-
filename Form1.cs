using Sistema_locadora.br.com.locadora.view;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_locadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastroUsuárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //abrir outra tela dentro do menu

            frmusuario tela = new frmusuario();

            tela.MdiParent = this;

            tela.Show();
        }
    }
}

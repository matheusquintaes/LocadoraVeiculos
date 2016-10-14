using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Locadora_Veiculos
{
    public partial class Veiculos : Form
    {
        public Veiculos()
        {
            InitializeComponent();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            CadastroVeiculos novo = new CadastroVeiculos();
            novo.Show();
        }

        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton_Selecionar_Click(object sender, EventArgs e)
        {
            ExibirVeiculo novo = new ExibirVeiculo();
            novo.Show();
        }

        private void toolStripButton_Novo_Click(object sender, EventArgs e)
        {
            CadastroVeiculos novo = new CadastroVeiculos();
            novo.Show();
        }
    }
}

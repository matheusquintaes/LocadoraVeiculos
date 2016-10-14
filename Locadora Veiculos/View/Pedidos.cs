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
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }

        private void toolStripButton_Novo_Click(object sender, EventArgs e)
        {
            Locacao novo = new Locacao();
            novo.Show();
        }

        private void toolStripButton_Selecionar_Click(object sender, EventArgs e)
        {
            ExibirPedido novo = new ExibirPedido();
            novo.Show();
        }

        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Pesquisar_Click(object sender, EventArgs e)
        {

        }
    }
}

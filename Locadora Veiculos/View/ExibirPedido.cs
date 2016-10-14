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
    public partial class ExibirPedido : Form
    {
        public ExibirPedido()
        {
            InitializeComponent();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void toolStripButton_Imprimir_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Deseja efetuar a impressão do pedido?",
            "Impressão",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result1 == DialogResult.OK)
            {

            }
            if (result1 == DialogResult.Cancel)
            {

            }
        }

        private void toolStripButton_Contrato_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("Deseja emitir o contrato?",
             "Contrato",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result2 == DialogResult.OK)
            {

            }
            if (result2 == DialogResult.Cancel)
            {

            }
        }

        private void toolStripButton_Entrega_Click(object sender, EventArgs e)
        {
            EntregaVeiculo novo = new EntregaVeiculo();
            novo.Show();
        }

        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

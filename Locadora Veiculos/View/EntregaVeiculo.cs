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
    public partial class EntregaVeiculo : Form
    {
        private long CodigoVeiculo = 0;

        public EntregaVeiculo(long codVeiculo)
        {
            CodigoVeiculo = codVeiculo;
            InitializeComponent();
        }
        private void toolStripButton_Confirmar_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("Deseja registrar entrega do veiculo?",
            "Entrega de Veículo",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result2 == DialogResult.OK)
            {

            }
            if (result2 == DialogResult.Cancel)
            {

            }
        }

        private void toolStripButton_CheckList_Click(object sender, EventArgs e)
        {

            CheckList novo = new CheckList(CodigoVeiculo);
            if (novo.ShowDialog() == DialogResult.OK) { textBox_CheckList.Text = "Realizado"; }

        }

        private void toolStripButton_Pesquisar_Click(object sender, EventArgs e)
        {
            SelecionarVeiculo novo = new SelecionarVeiculo();
            novo.Show();
        }

        private void toolStripButton_Cancelar_Click(object sender, EventArgs e)
        {
            Close();

        }
    }
}

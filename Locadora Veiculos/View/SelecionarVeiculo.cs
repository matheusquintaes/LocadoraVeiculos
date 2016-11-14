using Persistencia.DAO;
using Persistencia.Modelo;
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
    public partial class SelecionarVeiculo : Form
    {
        public long CodigoVeiculo { get; set; }

        public SelecionarVeiculo()
        {
            InitializeComponent();
        }

        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton_Selecionar_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Deseja selecionar o veículo?",
            "Seleção Veículo",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result1 == DialogResult.OK)
            {

            }
            if (result1 == DialogResult.Cancel)
            {

            }
        }

        private void toolStripButton_Novo_Click(object sender, EventArgs e)
        {
            CadastroVeiculos novo = new CadastroVeiculos();
            novo.Show();
        }

        private void SelecionarVeiculo_Activated(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            foreach (Veiculo veiculo in new VeiculoDAO().Listar())
            {
                int index = dataGridView1.Rows.Add();
                DataGridViewRow dado = dataGridView1.Rows[index];
                dado.Cells["Código"].Value = veiculo.CodigoVeiculo;
                dado.Cells["Marca"].Value = veiculo.Marca;
                dado.Cells["Modelo"].Value = veiculo.Modelo;

                Documento documento = new DocumentoDAO().Buscar(veiculo.CodigoVeiculo);

                dado.Cells["Placa"].Value = documento.Placa;
                dado.Cells["Renavam"].Value = documento.Renavam;

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CodigoVeiculo = long.Parse(dataGridView1.Rows[e.RowIndex].Cells["Código"].Value.ToString());
            this.Close();
        }
    }
}

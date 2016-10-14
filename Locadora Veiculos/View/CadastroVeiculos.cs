using System;
using System.Windows.Forms;

namespace Locadora_Veiculos
{
    public partial class CadastroVeiculos : Form
    {
        public CadastroVeiculos()
        {
            InitializeComponent();
        }
        private void toolStripButton_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Deseja realmente cancelar?",
             "Cancelamento de cadastro",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result1 == DialogResult.OK)
            {

            }
            if (result1 == DialogResult.Cancel)
            {

            }
        }

        private void toolStripButton_Pesquisar_Click(object sender, EventArgs e)
        {
            SelecionarFornecedor novo = new SelecionarFornecedor();
            novo.ShowDialog();
        }

        private void toolStripButton_Salvar_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("Deseja salvar o novo cadastro?",
             "Salvar novo cadastro",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result2 == DialogResult.OK)
            {

            }
            if (result2 == DialogResult.Cancel)
            {

            }
        }

        private void label_KM_Click(object sender, EventArgs e)
        {

        }

        private void textBox_KM_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_Tanque_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CadastroVeiculos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'locadora_veiculoDataSet2.fornecedor' table. You can move, or remove it, as needed.
            //this.fornecedorTableAdapter.Fill(this.locadora_veiculoDataSet2.fornecedor);
            // TODO: This line of code loads data into the 'locadora_veiculoDataSet1.categoria' table. You can move, or remove it, as needed.
            //this.categoriaTableAdapter.Fill(this.locadora_veiculoDataSet1.categoria);

        }
    }
}

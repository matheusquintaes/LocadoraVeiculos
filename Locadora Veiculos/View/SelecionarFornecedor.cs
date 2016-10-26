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
    public partial class SelecionarFornecedor : Form
    {
        public long codFornecedor;
        public SelecionarFornecedor()
        {
            InitializeComponent();
        }

        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton_Novo_Click(object sender, EventArgs e)
        {
            CadastroFornecedor novo = new CadastroFornecedor();
            novo.ShowDialog();
        }

        private void SelecionarFornecedor_Activated(object sender, EventArgs e)
        {
            dataGrid_Fornecedor.Rows.Clear();

            foreach (Fornecedor fornecedor in new FornecedorDAO().Listar())
            {
                int index = dataGrid_Fornecedor.Rows.Add();
                DataGridViewRow dado = dataGrid_Fornecedor.Rows[index];
                dado.Cells["Código"].Value = fornecedor.CodigoFornecedor;
                dado.Cells["Nome"].Value = fornecedor.NomeFantasia;
                dado.Cells["Razao"].Value = fornecedor.RazaoSocial;
                dado.Cells["CNPJ"].Value = fornecedor.CNPJ;
            }
        }

        private void dataGrid_Fornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Fornecedor fornecedor = new FornecedorDAO().Buscar(long.Parse(dataGrid_Fornecedor.Rows[e.RowIndex].Cells["Código"].Value.ToString()));
            codFornecedor = fornecedor.CodigoFornecedor;
            this.DialogResult = DialogResult.OK;
        }
    }
}

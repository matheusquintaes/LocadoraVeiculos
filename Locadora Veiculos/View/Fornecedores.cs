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
    public partial class Fornecedores : Form
    {
        public Fornecedores()
        {
            InitializeComponent();
        }
        private void toolStripButton_Novo_Click(object sender, EventArgs e)
        {
            CadastroFornecedor novo = new CadastroFornecedor();
            novo.ShowDialog();
        }

        private void toolStripButton_Selecionar_Click(object sender, EventArgs e)
        {
            ExibirFornecedor novo = new ExibirFornecedor();
            novo.ShowDialog();
        }

        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Fornecedores_Load(object sender, EventArgs e)
        {

        }

        private void Fornecedores_Activated(object sender, EventArgs e)
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
            ExibirFornecedor novo = new ExibirFornecedor(long.Parse(dataGrid_Fornecedor.Rows[e.RowIndex].Cells["Código"].Value.ToString()));
            novo.ShowDialog();

        }
        
    }
    }


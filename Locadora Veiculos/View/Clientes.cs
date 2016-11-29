using Persistencia.DAO;
using Persistencia.Modelo;
using Persistencia.Service;
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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }

        private void toolStripButton_Novo_Click_1(object sender, EventArgs e)
        {
            CadastroClientes novo = new CadastroClientes();
            novo.ShowDialog();
        }

        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clientes_Activated(object sender, EventArgs e)
        {
            dataGrid_Clientes.Rows.Clear();

            foreach (Cliente cliente in new ClienteService().Listar())
            {
                int index = dataGrid_Clientes.Rows.Add();
                DataGridViewRow dado = dataGrid_Clientes.Rows[index];

                ClienteService clienteService = new ClienteService();

                string tipoPessoa = clienteService.TipoDePessoa(cliente.CodigoCliente);

                if (tipoPessoa == "PF")
                {
                    PessoaFisica pessoaFisica =  clienteService.BuscarPessoaFisica(cliente.CodigoCliente);
                    dado.Cells["Tipo"].Value = "Pessoa Física";
                    dado.Cells["Nome"].Value = pessoaFisica.Nome;
                    dado.Cells["Documento"].Value = pessoaFisica.RG;
                    dado.Cells["Código"].Value = cliente.CodigoCliente;
                    dado.Cells["Email"].Value = cliente.Email;

                } else if (tipoPessoa == "PJ")
                {
                    PessoaJuridica pessoaJuridica = clienteService.BuscarPessoaJuridica(cliente.CodigoCliente); 
                    dado.Cells["Tipo"].Value = "Pessoa Juridica";
                    dado.Cells["Nome"].Value = pessoaJuridica.NomeFantasia;
                    dado.Cells["Documento"].Value = pessoaJuridica.CNPJ;
                    dado.Cells["Código"].Value = cliente.CodigoCliente;
                    dado.Cells["Email"].Value = cliente.Email;
                }

            }
        }

        private void dataGrid_Clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ExibirCliente novo = new ExibirCliente(long.Parse(dataGrid_Clientes.Rows[e.RowIndex].Cells["Código"].Value.ToString()));
            novo.ShowDialog();
        }
    }
}

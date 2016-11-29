﻿using Persistencia.Modelo;
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
    public partial class SelecionarCliente : Form
    {
        public long CodigoCliente { get; set; }
        public SelecionarCliente()
        {
            InitializeComponent();
        }
        private void oolStripButton_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton_Novo_Click(object sender, EventArgs e)
        {
            CadastroClientes novo = new CadastroClientes();
            novo.ShowDialog();
        }

        private void SelecionarCliente_Activated(object sender, EventArgs e)
        {
            dataGridView_Clientes.Rows.Clear();

            foreach (Cliente cliente in new ClienteService().Listar())
            {
                int index = dataGridView_Clientes.Rows.Add();
                DataGridViewRow dado = dataGridView_Clientes.Rows[index];

                ClienteService clienteService = new ClienteService();

                string tipoPessoa = clienteService.TipoDePessoa(cliente.CodigoCliente);

                if (tipoPessoa == "PF")
                {
                    PessoaFisica pessoaFisica = clienteService.BuscarPessoaFisica(cliente.CodigoCliente);
                    dado.Cells["Tipo"].Value = "Pessoa Física";
                    dado.Cells["Nome"].Value = pessoaFisica.Nome;
                    dado.Cells["Documento"].Value = pessoaFisica.RG;
                    dado.Cells["Código"].Value = cliente.CodigoCliente;
                    dado.Cells["Email"].Value = cliente.Email;

                }
                else if (tipoPessoa == "PJ")
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

        private void dataGridView_Clientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CodigoCliente = long.Parse(dataGridView_Clientes.Rows[e.RowIndex].Cells["Código"].Value.ToString());
            this.Close();
        }
    }
}

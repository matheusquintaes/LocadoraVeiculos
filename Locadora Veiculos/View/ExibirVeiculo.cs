﻿using Persistencia.DAO;
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
    public partial class ExibirVeiculo : Form
    {
        private long CodigoVeiculo = 0;
        public ExibirVeiculo()
        {
           
            InitializeComponent();
        }

        public ExibirVeiculo(long codigo)
        {
            CodigoVeiculo = codigo;
            InitializeComponent();
            Veiculo veiculo = new VeiculoDAO().Buscar(codigo);
            VeiculoTemFornecedor veiculofornecedor = new VeiculoTemFornecedorDAO().Buscar(codigo);
            Fornecedor fornecedor = new FornecedorDAO().Buscar(veiculofornecedor.CodigoFornecedor);

        

            foreach (Fornecedor fornecedores in new FornecedorDAO().Listar())
            {
               comboBox_Fornecedores.Items.Add(fornecedores.NomeFantasia);
            }

            comboBox_Fornecedores.SelectedIndex = comboBox_Fornecedores.FindStringExact(fornecedor.NomeFantasia);
            //Veiculo veiculo = new VeiculoDAO().Buscar(codigo);

        }
        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton_CheckLists_Click(object sender, EventArgs e)
        {
            ExibirHistoricoCheckList novo = new ExibirHistoricoCheckList();
            novo.Show();
        }

        private void toolStripButton_Imprimir_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Deseja efetuar a impressão do cadastro?",
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

        private void toolStripButton_Manutencao_Click(object sender, EventArgs e)
        {
            Manutencao novo = new Manutencao();
            novo.Show();
        }

        private void toolStripButton_Excluir_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("Deseja realmente excluir o cadastro?",
            "Excluir Veículo",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result2 == DialogResult.OK)
            {

            }
            if (result2 == DialogResult.Cancel)
            {

            }
        }

        private void toolStripButton_Salvar_Click(object sender, EventArgs e)
        {
            DialogResult result3 = MessageBox.Show("Deseja salvar o novo cadastro?",
            "Salvar novo cadastro",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result3 == DialogResult.OK)
            {

            }
            if (result3 == DialogResult.Cancel)
            {

            }
        }

        private void comboBox_Fornecedores_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}

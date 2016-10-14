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
    public partial class Locacao : Form
    {
        public Locacao()
        {
            InitializeComponent();
        }
        private void toolStripButton_Confirmar_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Deseja efetuar a locação?",
            "Efetuar Nova Locação",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result1 == DialogResult.OK)
            {

            }
            if (result1 == DialogResult.Cancel)
            {

            }
        }

        private void toolStripButton_CheckList_Click(object sender, EventArgs e)
        {
            CheckList novo = new CheckList();
            novo.Show();
            Convert.ToString(textBox_CheckList);
            textBox_CheckList.Text = "Realizado";

        }

        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton_PesquisarC_Click(object sender, EventArgs e)
        {
            SelecionarCliente novo = new SelecionarCliente();
            novo.Show();
        }

        private void toolStripButton_PesquisarV_Click(object sender, EventArgs e)
        {
            SelecionarVeiculo novo = new SelecionarVeiculo();
            novo.Show();
        }

        private void toolStripButton_Adicionar_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("Deseja adicionar o veículo selecionado?",
            "Adicionar Veículo",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result2 == DialogResult.OK)
            {

            }
            if (result2 == DialogResult.Cancel)
            {

            }
        }

        private void toolStripButton_Remover_Click(object sender, EventArgs e)
        {
            DialogResult result3 = MessageBox.Show("Deseja remover o veículo selecionado?",
            "Remover Veículo",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result3 == DialogResult.OK)
            {

            }
            if (result3 == DialogResult.Cancel)
            {

            }
        }

        private void comboBox_TipoRetirada_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }


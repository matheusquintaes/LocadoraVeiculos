﻿using Persistencia.DAO;
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

        private void toolStripButton_Novo_Click(object sender, EventArgs e)
        {
            CadastroVeiculos novo = new CadastroVeiculos();
            novo.ShowDialog();
        }

        private void SelecionarVeiculo_Activated(object sender, EventArgs e)
        {
            dataGridView_Veiculo.Rows.Clear();

            foreach (Veiculo veiculo in new VeiculoService().Listar())
            {
                int index = dataGridView_Veiculo.Rows.Add();
                DataGridViewRow dado = dataGridView_Veiculo.Rows[index];
                dado.Cells["Código"].Value = veiculo.CodigoVeiculo;
                dado.Cells["Marca"].Value = veiculo.Marca;
                dado.Cells["Modelo"].Value = veiculo.Modelo;

                Documento documento = new VeiculoService().BuscarDocumento(veiculo.CodigoVeiculo);

                dado.Cells["Placa"].Value = documento.Placa;
                dado.Cells["Renavam"].Value = documento.Renavam;

            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CodigoVeiculo = long.Parse(dataGridView_Veiculo.Rows[e.RowIndex].Cells["Código"].Value.ToString());
            this.Close();
        }
    }
}

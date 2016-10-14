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
    public partial class Relatorios : Form
    {
        public Relatorios()
        {
            InitializeComponent();
        }

        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton_Entrar_Click(object sender, EventArgs e)
        {
            Convert.ToString(comboBox_Selecionar.SelectedText);
            if (comboBox_Selecionar.SelectedText == "")
            {
                MessageBox.Show("Selecione um tipo de relatório válido !", "Erro de Autenticação", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            if (comboBox_Selecionar.SelectedText == "Geral")
            {
                RelatorioTodos novo = new RelatorioTodos();
                novo.Show();
            }
            if (comboBox_Selecionar.SelectedText == "Categorias")
            {
                RelatorioCategorias novo = new RelatorioCategorias();
                novo.Show();
            }
            if (comboBox_Selecionar.SelectedText == "Clientes")
            {
                RelatorioClientes novo = new RelatorioClientes();
                novo.Show();
            }
            if (comboBox_Selecionar.SelectedText == "Fornecedores")
            {
                RelatorioFornecedores novo = new RelatorioFornecedores();
                novo.Show();
            }
            if (comboBox_Selecionar.SelectedText == "Usuários")
            {
                RelatorioUsuarios novo = new RelatorioUsuarios();
                novo.Show();
            }
            if (comboBox_Selecionar.SelectedText == "Veículos")
            {
                RelatorioVeiculos novo = new RelatorioVeiculos();
                novo.Show();
            }
        }
    }
}

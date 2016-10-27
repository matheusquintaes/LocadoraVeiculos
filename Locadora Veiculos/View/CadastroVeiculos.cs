using Persistencia.DAO;
using Persistencia.Service;
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
    public partial class CadastroVeiculos : Form
    {
        public long codCatSelecionada = 0;
        public long codForSelecionado = 0;
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
                MessageBox.Show("Cadastro cancelado com sucesso!");
                this.Close();
            }
            if (result1 == DialogResult.Cancel)
            {

            }
        }
        private void toolStripButton_PesquisarF_Click(object sender, EventArgs e)
        {
            SelecionarFornecedor selecionarF = new SelecionarFornecedor();

            if (selecionarF.ShowDialog() == DialogResult.OK)
            {
                codForSelecionado = selecionarF.codFornecedor;
                Fornecedor fornecedor = new FornecedorDAO().Buscar(codForSelecionado);
                textBox_Fornecedor.Text = fornecedor.NomeFantasia;
                textBox_Fornecedor.BackColor = Color.PaleGreen;
            }
        }

        private void toolStripButton_BuscarC_Click(object sender, EventArgs e)
        {
            SelecionarCategoria selecionarC = new SelecionarCategoria();
            if (selecionarC.ShowDialog() == DialogResult.OK)
            {
                codCatSelecionada = selecionarC.codCategoria;
                Categoria categoria = new CategoriaDAO().Buscar(codCatSelecionada);
                textBox_Categoria.Text = categoria.Nome;
                textBox_Categoria.BackColor = Color.PaleGreen;
            }
        }

        private void toolStripButton_Salvar_Click(object sender, EventArgs e)
        {
            
            DialogResult result2 = MessageBox.Show("Deseja salvar o novo cadastro?",
            "Salvar novo cadastro",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);

            if (result2 == DialogResult.OK)
            {

                long i = new VeiculoService().Inserir(
                    textBox_Marca.Text,
                    textBox_Modelo.Text,
                    textBox_KM.Text,
                    TextBox_AnoF.Text,
                     1,
                    (checkBox_Vidro.Checked ? true : false),
                    (checkBox_Trava.Checked ? true : false),
                    (checkBox_Automatico.Checked ? true : false),
                    (checkBox_4portas.Checked ? 4 : 2),
                    (checkBox_Hidraulica.Checked ? true : false),
                    (checkBox_ArCondicionado.Checked ? true : false),
                    textBox_Cor.Text,
                    codCatSelecionada,
                    1
                );

                MessageBox.Show("Cadastro efetuado com sucesso! - " + i);
                this.Close();


                /*
                Documento documento = new Documento();
                documento.Placa = textBox_Placa.Text;
                documento.Renavam = textBox_RENAVAM.Text;
                documento.Chassi = textBox_Chassi.Text;
                documento.DataLicenciamento = comboBox_MesLic.Text + "-" + TextBox_AnoLic.Text;

                VeiculoTemFornecedor veiculotemfornecedor = new VeiculoTemFornecedor();
                veiculotemfornecedor.CodigoFornecedor = codForSelecionado;

                long id_v = new VeiculoDAO().Inserir(veiculo);
                documento.CodigoVeiculo = id_v;
                new DocumentoDAO().Inserir(documento);
                veiculotemfornecedor.CodigoVeiculo = id_v;
                new VeiculoTemFornecedorDAO().Inserir(veiculotemfornecedor);
                MessageBox.Show("Cadastro efetuado com sucesso!");
                this.Close();

                */

            }

                
            if (result2 == DialogResult.Cancel)
            {

            }

            /* if ((textBox_Marca.Text != "") && (textBox_Modelo.Text != "") &&
                (textBox_Chassi.Text != "") && (textBox_RENAVAM.Text != "")
                && (textBox_Cor.Text != "") && (textBox_Placa.Text != "") && (textBox_KM.Text != "")
                && (comboBox_Combustivel.Text != "") && (comboBox_Tanque.Text != "") && (codCatSelecionada !=0)
                && (codForSelecionado != 0))
            {*/

        }
    }
}


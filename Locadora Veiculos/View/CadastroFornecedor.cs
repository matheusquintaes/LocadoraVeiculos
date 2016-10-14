using Persistencia.DAO;
using Persistencia.Modelo;
using System;
using System.Windows.Forms;

namespace Locadora_Veiculos
{
    public partial class CadastroFornecedor : Form
    {
        public CadastroFornecedor()
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

        private void toolStripButton_Salvar_Click(object sender, EventArgs e)
        {
            if ((textBox_NomeFantasia.Text != "") && (textBox_RazaoSocial.Text != "") &&
                    (textBox_CNPJ.Text != "") && (textBox_InscEstadual.Text != "")
                    && (textBox_CEP.Text != "") && (textBox_Logradouro.Text != "") && (textBox_N.Text != "")
                    && (textBox_Cidade.Text != "") && (comboBox_Estado.Text != ""))
            {
                DialogResult result2 = MessageBox.Show("Deseja salvar o novo cadastro?", "Salvar novo cadastro", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (result2 == DialogResult.OK)
                {
                    Endereco endereco = new Endereco();
                    TelefoneFornecedor telefone = new TelefoneFornecedor();
                    Fornecedor fornecedor = new Fornecedor();

                    endereco.CEP = textBox_CEP.Text;
                    endereco.Logradouro = textBox_Logradouro.Text;
                    endereco.Bairro = textBox_Bairro.Text;
                    endereco.Numero = textBox_N.Text;
                    endereco.Cidade = textBox_Cidade.Text;
                    endereco.Estado = comboBox_Estado.Text;

                    telefone.Telefone = textBox_Telefone.Text + ":" + textBox_Celular.Text;

                    fornecedor.NomeFantasia = textBox_NomeFantasia.Text;
                    fornecedor.RazaoSocial = textBox_RazaoSocial.Text;
                    fornecedor.CNPJ = textBox_CNPJ.Text;
                    fornecedor.InscricaoEstadual = textBox_InscEstadual.Text;
                    fornecedor.Email = textBox_Email.Text;

                    long id_e = new EnderecoDAO().Inserir(endereco);
                    fornecedor.CodigoEndereco = id_e;
                    long id_f = new FornecedorDAO().Inserir(fornecedor);
                    telefone.CodigoFornecedor = id_f;
                    new TelefoneFornecedorDAO().Inserir(telefone);
                    MessageBox.Show("Cadastro efetuado com sucesso!");
                    this.Close();
                }
            }
             else
                MessageBox.Show("Preencha corretamente as informações", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}

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
    public partial class ExibirFornecedor : Form
    {
        private long CodigoFornecedor= 0;
        public ExibirFornecedor()
        {
            InitializeComponent();
        }
        public ExibirFornecedor(long codigo)
        {
            CodigoFornecedor = codigo;
            InitializeComponent();
            Fornecedor fornecedor = new FornecedorDAO().Buscar(codigo);
            textBox_NomeFantasia.Text = fornecedor.NomeFantasia;
            textBox_RazaoSocial.Text = fornecedor.RazaoSocial;
            textBox_CNPJ.Text = fornecedor.CNPJ;
            textBox_InscEstadual.Text = fornecedor.InscricaoEstadual;
            textBox_Email.Text = fornecedor.Email;

            TelefoneFornecedor telefone = new TelefoneFornecedorDAO().Buscar(CodigoFornecedor);
            telefone.CodigoFornecedor = CodigoFornecedor;
            textBox_Telefone.Text = telefone.Telefone.Substring(0, telefone.Telefone.IndexOf(":"));
            textBox_Celular.Text = telefone.Telefone.Substring(telefone.Telefone.IndexOf(":")+1);

            Endereco endereco = new EnderecoDAO().Buscar(fornecedor.CodigoEndereco);
            textBox_CEP.Text = endereco.CEP;
            textBox_Logradouro.Text = endereco.Logradouro;
            textBox_N.Text = endereco.Numero;
            textBox_Bairro.Text = endereco.Bairro;
            textBox_Cidade.Text = endereco.Cidade;
            comboBox_Estado.Text = endereco.Estado;
            

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton_Salvar_Click(object sender, EventArgs e)
        {
            DialogResult result3 = MessageBox.Show("Deseja salvar as alterações no cadastro?",
            "Salvar Alterações",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result3 == DialogResult.OK)
            {
                if ((textBox_NomeFantasia.Text != "") && (textBox_RazaoSocial.Text != "") &&
                    (textBox_CNPJ.Text != "") && (textBox_InscEstadual.Text != "") 
                    && (textBox_CEP.Text != "") && (textBox_Logradouro.Text != "") && (textBox_N.Text != "")
                    && (textBox_Cidade.Text != "") && (comboBox_Estado.Text != ""))
                {
                    Fornecedor f = new Fornecedor();
                    Endereco end = new Endereco();
                    TelefoneFornecedor tel = new TelefoneFornecedor();

                    f.CodigoFornecedor = CodigoFornecedor;
                    f.NomeFantasia = textBox_NomeFantasia.Text;
                    f.RazaoSocial = textBox_RazaoSocial.Text;
                    f.CNPJ = textBox_CNPJ.Text;
                    f.InscricaoEstadual = textBox_InscEstadual.Text;
                    f.Email = textBox_Email.Text;

                    Fornecedor fornecedor = new FornecedorDAO().Buscar(CodigoFornecedor);
                    end.CodigoEndereco = fornecedor.CodigoEndereco;
                    end.CEP = textBox_CEP.Text;
                    end.Logradouro = textBox_Logradouro.Text;
                    end.Bairro = textBox_Bairro.Text;
                    end.Numero = textBox_N.Text;
                    end.Cidade = textBox_Cidade.Text;
                    end.Estado = comboBox_Estado.Text;
                                               
                    tel.CodigoFornecedor = CodigoFornecedor;
                    tel.Telefone = textBox_Telefone.Text + ":" + textBox_Celular.Text;

                    new FornecedorDAO().Atualizar(f);
                    new EnderecoDAO().Atualizar(end);
                    new TelefoneFornecedorDAO().Atualizar(tel);

                    if ((new FornecedorDAO().Atualizar(f)) && (new EnderecoDAO().Atualizar(end)) && (new TelefoneFornecedorDAO().Atualizar(tel))){
                        MessageBox.Show(" Fornecedor alterado com Sucesso","Cadastro Alterado", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    } else MessageBox.Show("Verifique os valores digitados","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error); 
                }
            }
            if (result3 == DialogResult.Cancel)
            {

            }
        }

        private void toolStripButton_Excluir_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Deseja realmente excluir o cadastro?",
            "Excluir Fornecedor",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result1 == DialogResult.OK)
            {
                Fornecedor f = new Fornecedor();

                f.CodigoFornecedor = CodigoFornecedor;
                f.Status = 9;

                new FornecedorDAO().Remover(f);

                TelefoneFornecedor tel = new TelefoneFornecedor();

                tel.CodigoFornecedor = CodigoFornecedor;
                tel.Status = 9;

                new TelefoneFornecedorDAO().Remover(tel);

                Endereco end = new Endereco();

                Fornecedor fornecedor = new FornecedorDAO().Buscar(CodigoFornecedor);
                end.CodigoEndereco = fornecedor.CodigoEndereco;
                end.Status = 9;

                new EnderecoDAO().Remover(end);

                if (new FornecedorDAO().Remover(f) && new TelefoneFornecedorDAO().Remover(tel) && new EnderecoDAO().Remover(end))
                {
                    MessageBox.Show(" Fornecedor Removido com Sucesso", "Remoção de Fornecedor", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                this.Close();
            }
            if (result1 == DialogResult.Cancel)
            {

            }
        }

        private void toolStripButton_Imprimir_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("Deseja efetuar a impressão do cadastro?",
            "Impressão",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result2 == DialogResult.OK)
            {
            }
            if (result2 == DialogResult.Cancel)
            {

            }
        }
    }
}

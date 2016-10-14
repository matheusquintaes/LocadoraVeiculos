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
    public partial class ExibirCliente : Form
    {
        public ExibirCliente()
        {
            InitializeComponent();
        }
        private void toolStripButton_Sair_Click_1(object sender, EventArgs e)
        {
            this.Close();
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

        private void toolStripButton_Excluir_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("Deseja realmente excluir o cadastro?",
            "Excluir Cliente",
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

        private void radioButton_PessoaFisica_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_PessoaFisica.Checked)
            {
                label_CNPJ.Visible = false;
                textBox_InscEstadual.Visible = false;
                label_InscEstadual.Visible = false;
                textBox_CNPJ.Visible = false;
                label_RazaoSocial.Visible = false;
                textBox_RazaoSocial.Visible = false;
                label_NomeFantasia.Visible = false;
                textBox_NomeFantasia.Visible = false;
                label_CPF.Visible = true;
                textBox_CPF.Visible = true;
                label_RG.Visible = true;
                textBox_RG.Visible = true;
                label_CNH.Visible = true;
                textBox_CNH.Visible = true;
                label_Naturalidade.Visible = true;
                label_Passaporte.Visible = true;
                textBox_Passaporte.Visible = true;
                label_DataNasc.Visible = true;
               
            }
        }

        private void radioButton_PessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_PessoaJuridica.Checked)
            {
                label_CPF.Visible = false;
                textBox_CPF.Visible = false;
                label_RG.Visible = false;
                textBox_RG.Visible = false;
                label_CNH.Visible = false;
                textBox_CNH.Visible = false;
                label_Naturalidade.Visible = false;
                label_Passaporte.Visible = false;
                textBox_Passaporte.Visible = false;
                label_DataNasc.Visible = false;
                label_CNPJ.Visible = true;
                textBox_InscEstadual.Visible = true;
                label_InscEstadual.Visible = true;
                textBox_CNPJ.Visible = true;
                label_RazaoSocial.Visible = true;
                textBox_RazaoSocial.Visible = true;
                label_NomeFantasia.Visible = true;
                textBox_NomeFantasia.Visible = true;
            }
        }
    }
}

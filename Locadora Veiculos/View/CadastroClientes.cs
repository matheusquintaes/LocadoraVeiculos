using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Persistencia;
using Persistencia.DAO;
using Persistencia.Modelo;

namespace Locadora_Veiculos
{
    public partial class CadastroClientes : Form
    {
        public CadastroClientes()
        {
            InitializeComponent();
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
                textBox_Naturalidade.Visible = true;
                label_Passaporte.Visible = true;
                textBox_Passaporte.Visible = true;
                label_DataNasc.Visible = true;
                textBox_DataNasc.Visible = true;
                label_Nome.Visible = true;
                textBox_Nome.Visible = true;
            }
        }
        private void radioButton_PessoaJuridica_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_PessoaJuridica.Checked)
            {
                label_Nome.Visible = false;
                textBox_Nome.Visible = false;
                label_CPF.Visible = false;
                textBox_CPF.Visible = false;
                label_RG.Visible = false;
                textBox_RG.Visible = false;
                label_CNH.Visible = false;
                textBox_CNH.Visible = false;
                label_Naturalidade.Visible = false;
                textBox_Naturalidade.Visible = false;
                label_Passaporte.Visible = false;
                textBox_Passaporte.Visible = false;
                label_DataNasc.Visible = false;
                textBox_DataNasc.Visible = false;
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
        private void toolStripButton_salvar_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("Deseja salvar o novo cadastro?",
            "Salvar novo cadastro",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result2 == DialogResult.OK)
            {
               
                ClienteDAO cliente = new ClienteDAO();
                Cliente c = new Cliente();

                PessoaFisicaDAO pessoaFisica = new PessoaFisicaDAO();
                PessoaFisica pf = new PessoaFisica();

                c.Email             = textBox_Email.Text;
                pf.Nome             = textBox_Nome.Text;
                pf.RG               = textBox_RG.Text;
                pf.CPF              = textBox_CPF.Text;
                pf.DataNascimento   = textBox_DataNasc.Text;
                pf.CNH = textBox_CNH.Text;
                pf.Passaporte = textBox_CNH.Text;
                pf.Naturalidade = textBox_Naturalidade.Text;
                

                pessoaFisica.Inserir(pf);                    
                cliente.Inserir(c);
              
            }
            if (result2 == DialogResult.Cancel)
            {

            }
        }

        private void toolStripButton_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Deseja realmente cancelar?",
            "Cancelamento de cadastro",
            MessageBoxButtons.OKCancel);
            if (result1 == DialogResult.OK)
            {
                this.Close();
            }
            if (result1 == DialogResult.Cancel)
            {

            }
        }

        private void label_CNPJ_Click(object sender, EventArgs e)
        {

        }

    }
}

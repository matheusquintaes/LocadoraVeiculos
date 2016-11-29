using Persistencia.DAO;
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
    public partial class Locacao : Form
    {
        private Veiculo veiculo;
        private long codCliente;
        private string formapagamento;
        private string nomeuser;

        public Locacao(string nomeusuario)
        {
            nomeuser = nomeusuario;
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
                if (radioButton_Boleto.Checked) { formapagamento = "Boleto"; };
                if (radioButton_Dinheiro.Checked) { formapagamento = "Dinheiro"; };
                if (radioButton_CartaoDebito.Checked) { formapagamento = "Cartão Debito"; };
                if (radioButton_CartaoCredito.Checked) { formapagamento = "Cartão Credito"; };

                if (new LocacaoService().EfetuarReserva(veiculo.CodigoVeiculo, codCliente,
                    dateTimePicker_Retirada.Value, dateTimePicker_Entrega.Value, comboBox_TipoRetirada.Text, formapagamento, textBox_ValorPedido.Text,nomeuser) != false)
                {
                    MessageBox.Show("Locação Inserida com sucesso!");
                    this.Close();
                };
            }
            if (result1 == DialogResult.Cancel)
            {

            }
        }

        private void toolStripButton_CheckList_Click(object sender, EventArgs e)
        {
            if (veiculo != null)
            {
                CheckList novo = new CheckList(veiculo.CodigoVeiculo);
                if(novo.ShowDialog() == DialogResult.OK) { textBox_CheckList.Text = "Realizado"; }   
            }

        }

        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton_PesquisarC_Click(object sender, EventArgs e)
        {
            SelecionarCliente novo = new SelecionarCliente();
            novo.ShowDialog();
            textBox_Cliente.Text = new LocacaoService().BuscarCliente(novo.CodigoCliente);
            codCliente = novo.CodigoCliente;
            if (textBox_Cliente.Text != "") { textBox_Cliente.BackColor = Color.PaleGreen;}
            
        }

        private void toolStripButton_PesquisarV_Click(object sender, EventArgs e)
        {
            SelecionarVeiculo novo = new SelecionarVeiculo();
            novo.ShowDialog();
            veiculo = new LocacaoService().BuscarVeiculo(novo.CodigoVeiculo);
            textBox_Veiculo.Text = veiculo.Modelo;
            textBox_Veiculo.BackColor = Color.PaleGreen;
            
        }

        private void dateTimePicker_Retirada_ValueChanged(object sender, EventArgs e)
        {
            decimal resultado = new LocacaoService().CalculaPedido(dateTimePicker_Retirada.Value, dateTimePicker_Entrega.Value, veiculo.CodigoVeiculo);

            if (resultado == 1)
            {
                MessageBox.Show("Selecione um veiculo !!");
            }

            if(resultado == 0)
            {
                MessageBox.Show("A data de retirada não pode ser maior que a de entrega!!");
            }
            if (resultado != 1 && resultado != 0)
             {
                textBox_ValorPedido.Text = resultado.ToString();
             }
            

        }

        private void dateTimePicker_Entrega_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker_Retirada.Value < dateTimePicker_Entrega.Value)
            {
                textBox_ValorPedido.Text = new LocacaoService().CalculaPedido(dateTimePicker_Retirada.Value, dateTimePicker_Entrega.Value, veiculo.CodigoVeiculo).ToString();
            }
            else MessageBox.Show("A data de Retirada não pode ser menor que a de entrega! Favor Corrigir");
        }
    }
}


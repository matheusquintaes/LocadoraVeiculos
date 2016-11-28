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
    public partial class ExibirPedido : Form
    {
        private long CodigoReserva = 0;

        public ExibirPedido()
        {
            InitializeComponent();
        }
        public ExibirPedido(long codigo)
        {
            CodigoReserva = codigo;
            InitializeComponent();

            Reserva reserva = new PedidoService().Buscar(codigo);

            ClienteService clienteService = new ClienteService();
            string tipoPessoa = clienteService.TipoDePessoa(reserva.CodigoCliente);

            if (tipoPessoa == "PF")
            {
                PessoaFisica pessoaFisica = clienteService.BuscarPessoaFisica(reserva.CodigoCliente);
                textBox_Cliente.Text = pessoaFisica.Nome;

            }
            else if (tipoPessoa == "PJ")
            {
                PessoaJuridica pessoaJuridica = clienteService.BuscarPessoaJuridica(reserva.CodigoCliente);
                textBox_Cliente.Text = pessoaJuridica.NomeFantasia;
            }

            textBoxData.Text = reserva.DataReserva;
            textBoxFormaPagamento.Text = reserva.FormaPagamento;
            textBoxSituacao.Text = reserva.Situacao;
            textBoxTipoRetirada.Text = reserva.TipoRetirada;
            Usuario usuario = new UsuarioService().Busca(reserva.CodigoUsuario);
            textBoxusuario.Text = usuario.Nome;

            textBox_NPedido.Text = reserva.NumeroReserva.ToString();
            textBox_Valor.Text = reserva.ValorLocacao.ToString("C");

            dataGridView_Pedido.Rows.Clear();

            int index = dataGridView_Pedido.Rows.Add();
            DataGridViewRow dado = dataGridView_Pedido.Rows[index];

            dado.Cells["ReservaId"].Value = "Teste";
            dado.Cells["DataReserva"].Value = "20/01/2016";
            dado.Cells["DataEntrega"].Value = "20/01/2016";
            dado.Cells["DataRetirada"].Value = "20/01/2016";
            dado.Cells["Veiculo"].Value = "";
            dado.Cells["ValorCategoria"].Value = reserva.DataEntrega;
            dado.Cells["Total"].Value = reserva.DataEntrega;


        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void toolStripButton_Imprimir_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Deseja efetuar a impressão do pedido?",
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

        private void toolStripButton_Contrato_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("Deseja emitir o contrato?",
             "Contrato",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result2 == DialogResult.OK)
            {

            }
            if (result2 == DialogResult.Cancel)
            {

            }
        }

        private void toolStripButton_Entrega_Click(object sender, EventArgs e)
        {
            EntregaVeiculo novo = new EntregaVeiculo();
            novo.Show();
        }

        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

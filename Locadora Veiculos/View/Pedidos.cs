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
    public partial class Pedidos : Form
    {
        public Pedidos()
        {
            InitializeComponent();
        }

        private void toolStripButton_Novo_Click(object sender, EventArgs e)
        {
            Locacao novo = new Locacao();
            novo.Show();
        }

        private void toolStripButton_Selecionar_Click(object sender, EventArgs e)
        {
            ExibirPedido novo = new ExibirPedido();
            novo.Show();
        }

        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Pesquisar_Click(object sender, EventArgs e)
        {

        }

        private void Pedidos_Activated(object sender, EventArgs e)
        {
            dataGridView_Pedidos.Rows.Clear();

            foreach (Reserva reserva in new PedidoService().Listar())
            {
                int index = dataGridView_Pedidos.Rows.Add();
                DataGridViewRow dado = dataGridView_Pedidos.Rows[index];


                dado.Cells["DataReserva"].Value = "15/02/1990";
                dado.Cells["DataEntrega"].Value = "15/02/1991";
                dado.Cells["DataRetirada"].Value = "15/02/1991";
                dado.Cells["Cliente"].Value = "Cliente";
                dado.Cells["Veiculo"].Value = "Honda";
                dado.Cells["Valor"].Value = "56,20";

            }
        }
    }
}

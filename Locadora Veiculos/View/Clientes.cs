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
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
        }
        private void toolStripButton_Selecionar_Click_1(object sender, EventArgs e)
        {
            ExibirCliente novo = new ExibirCliente();
            novo.Show();
        }

        private void toolStripButton_Novo_Click_1(object sender, EventArgs e)
        {
            CadastroClientes novo = new CadastroClientes();
            novo.Show();
        }

        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

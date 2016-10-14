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
    public partial class SelecionarCliente : Form
    {
        public SelecionarCliente()
        {
            InitializeComponent();
        }
        private void oolStripButton_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton_Novo_Click(object sender, EventArgs e)
        {
            CadastroClientes novo = new CadastroClientes();
            novo.Show();
        }

        private void toolStripButton_Selecionar_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Deseja selecionar o cliente?",
             "Seleção Cliente",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result1 == DialogResult.OK)
            {

            }
            if (result1 == DialogResult.Cancel)
            {

            }
        }
    }
}

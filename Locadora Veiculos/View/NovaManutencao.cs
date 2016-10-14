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
    public partial class NovaManutencao : Form
    {
        public NovaManutencao()
        {
            InitializeComponent();
        }
        private void toolStripButton_Confirmar_Click(object sender, EventArgs e)
        {
             DialogResult result1 = MessageBox.Show("Deseja confirmar nova manutenção?",
            "Manutenção",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result1 == DialogResult.OK)
            {

            }
            if (result1 == DialogResult.Cancel)
            {

            }
        }

        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton_PesquisarF_Click(object sender, EventArgs e)
        {
            SelecionarFornecedor novo = new SelecionarFornecedor();
            novo.Show();
        }
    }
}

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
    public partial class Manutencao : Form
    {
        public Manutencao()
        {
            InitializeComponent();
        }
        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton_Devolucao_Click(object sender, EventArgs e)
        {
            DevolucaoManutencao novo = new DevolucaoManutencao();
            novo.Show();
        }

        private void toolStripButton_Nova_Click(object sender, EventArgs e)
        {
            NovaManutencao novo = new NovaManutencao();
            novo.Show();
        }
    }
}

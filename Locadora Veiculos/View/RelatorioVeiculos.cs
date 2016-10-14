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
    public partial class RelatorioVeiculos : Form
    {
        public RelatorioVeiculos()
        {
            InitializeComponent();
        }

        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton_Todos_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Todos.Checked)
            {
                label_DeData.Enabled = false;
                label_AteData.Enabled = false;
                dateTimePicker_DeData.Enabled = false;
                dateTimePicker_AteData.Enabled = false;
            }
        }

        private void radioButton_Selecionar_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Selecionar.Checked)
            {
                label_DeData.Enabled = true;
                label_AteData.Enabled = true;
                dateTimePicker_DeData.Enabled = true;
                dateTimePicker_AteData.Enabled = true;
            }
        }

        private void toolStripButton_Emitir_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Deseja efetuar a emissão do relatorio?",
            "Emissão de Relatório",
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

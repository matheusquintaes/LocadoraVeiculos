using Persistencia.DAO;
using Persistencia.Modelo;
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
    public partial class Veiculos : Form
    {
        public Veiculos()
        {
            InitializeComponent();
        }

        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton_Novo_Click(object sender, EventArgs e)
        {
            CadastroVeiculos novo = new CadastroVeiculos();
            novo.ShowDialog();
        }

        private void Veiculos_Activated(object sender, EventArgs e)
        {
            dataGrid_Veiculo.Rows.Clear();
           

            foreach (Veiculo veiculo in new VeiculoDAO().Listar())
            {
                int index = dataGrid_Veiculo.Rows.Add();
                DataGridViewRow dado = dataGrid_Veiculo.Rows[index];
                dado.Cells["Código"].Value = veiculo.CodigoVeiculo;
                dado.Cells["Marca"].Value = veiculo.Marca;
                dado.Cells["Modelo"].Value = veiculo.Modelo;

                Documento documento = new DocumentoDAO().Buscar(veiculo.CodigoVeiculo);
            
                dado.Cells["Placa"].Value = documento.Placa;
                dado.Cells["Renavam"].Value = documento.Renavam;
                
            }
           
        }


    }
}

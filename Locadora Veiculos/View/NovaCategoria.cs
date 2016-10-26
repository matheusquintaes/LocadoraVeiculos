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
    public partial class NovaCategoria : Form
    {
        public NovaCategoria()
        {
            InitializeComponent();
        }
        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton_Salvar_Click(object sender, EventArgs e)
        {
            CategoriaService novaC = new CategoriaService();
            novaC.Inserir(textBox_Nome.Text, textBox_Valor.Text);
        }
    }
            
}

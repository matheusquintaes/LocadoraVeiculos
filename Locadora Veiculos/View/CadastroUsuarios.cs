using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Persistencia.Service;

namespace Locadora_Veiculos
{
    public partial class CadastroUsuarios : Form
    {
        public CadastroUsuarios()
        {
            InitializeComponent();
        }
        private void toolStripButton_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult result1 = MessageBox.Show("Deseja realmente cancelar?",
             "Cancelamento de cadastro",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result1 == DialogResult.OK)
            {
                MessageBox.Show("Cadastro cancelado com sucesso!");
                this.Close();
            }
            if (result1 == DialogResult.Cancel)
            {

            }
        }

        private void toolStripButton_Salvar_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("Deseja salvar o novo cadastro?",
            "Salvar novo cadastro",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result2 == DialogResult.OK)
            {

                if ((textBox_Nome.Text != "") && (textBox_RG.Text != "") && (textBox_CPF.Text != "") && (textBox_Usuario.Text != "") && (textBox_Senha.Text != "") && (comboBox_TipoUsuario != null))
                {
                    long i = new UsuarioService().Inserir(
                        textBox_Nome.Text,
                        textBox_RG.Text,
                        textBox_CPF.Text,
                        textBox_Usuario.Text,
                        textBox_Senha.Text,
                        (comboBox_TipoUsuario.Text == "Comum" ? 2 : 1));
                    MessageBox.Show("Cadastro efetuado com sucesso!  " + i);
                    this.Close();
                }
                else MessageBox.Show("Preencha corretamente as informações");
            }
            if (result2 == DialogResult.Cancel)
            {

            }
        }
    }
}

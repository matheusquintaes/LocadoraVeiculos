using System;
using System.Windows.Forms;
using Persistencia.DAO;
using Persistencia.Modelo;

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
                    UsuarioDAO user = new UsuarioDAO();
                    Usuario u = new Usuario();
                    u.Nome = textBox_Nome.Text;
                    u.RG = textBox_RG.Text;
                    u.CPF = textBox_CPF.Text;
                    u.Login = textBox_Usuario.Text;
                    u.Senha = textBox_Senha.Text;
                    u.CodigoPermissao = 1;
                    user.Inserir(u);
                    MessageBox.Show("Cadastro efetuado com sucesso!");
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

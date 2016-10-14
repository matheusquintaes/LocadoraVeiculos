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
    public partial class ExibirUsuario : Form
    {
        private long CodigoUsuario = 0;
        public ExibirUsuario()
        {
            InitializeComponent();
        }
        public ExibirUsuario(long codigo)
        {
            CodigoUsuario = codigo;
            InitializeComponent();
            Usuario usuario = new UsuarioDAO().Buscar(codigo);
            textBox_Nome.Text = usuario.Nome;
            textBox_CPF.Text = usuario.CPF;
            textBox_RG.Text = usuario.RG;
            textBox_Usuario.Text = usuario.Login;
            textBox_Senha.Text = usuario.Senha;
            Permissao permissao = new PermissaoDAO().Buscar(usuario.CodigoPermissao);
            comboBox_TipoUsuario.Text = permissao.Descricao;
            if(comboBox_TipoUsuario.Text == "Administrador")
            {
                comboBox_TipoUsuario.Enabled = true;
            }else comboBox_TipoUsuario.Enabled = false;
        }
        private void toolStripButton_Salvar_Click(object sender, EventArgs e)
        {
            DialogResult result3 = MessageBox.Show("Deseja efetuar as alterações?",
            "Salvar Alterações",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result3 == DialogResult.OK)
            {
                if ((textBox_Nome.Text != "") && (textBox_RG.Text != "") && (textBox_CPF.Text != "") && (textBox_Usuario.Text != "") && (textBox_Senha.Text != "") && (comboBox_TipoUsuario != null))
                {
                    Usuario u = new Usuario();
                    u.CodigoUsuario = CodigoUsuario;
                    u.Nome = textBox_Nome.Text;
                    u.RG = textBox_RG.Text;
                    u.CPF = textBox_CPF.Text;
                    u.Login = textBox_Usuario.Text;
                    u.Senha = textBox_Senha.Text;
                    new UsuarioDAO().Atualizar(u);
                    if (new UsuarioDAO().Atualizar(u)) {
                        MessageBox.Show("Usuario alterado com sucesso!");
                    }else MessageBox.Show("Erro!");
                }
                else MessageBox.Show("Preencha corretamente as informações");

            }
            if (result3 == DialogResult.Cancel)
            {

            }
        }

        private void toolStripButton_Excluir_Click(object sender, EventArgs e)
        {
            DialogResult result2 = MessageBox.Show("Deseja realmente excluir o usuário?",
            "Excluir Usuário",
            MessageBoxButtons.OKCancel,
            MessageBoxIcon.Question);
            if (result2 == DialogResult.OK)
            {
                Usuario user = new Usuario();

                user.CodigoUsuario = CodigoUsuario;
                user.Status = 9;

                new UsuarioDAO().Remover(user);
                if (new UsuarioDAO().Remover(user))
                {
                    MessageBox.Show("Usuario removido com sucesso!");
                }
                this.Close();

            }
            if (result2 == DialogResult.Cancel)
            {

            }
        }

        private void toolStripButton_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

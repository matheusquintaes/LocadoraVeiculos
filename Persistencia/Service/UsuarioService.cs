using MySql.Data.MySqlClient;
using Persistencia.DAO;
using Persistencia.Interface;
using Persistencia.Modelo;
using Persistencia.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Persistencia.Service
{
    public class UsuarioService
    {
        private UsuarioDAO userDAO;

        public UsuarioService()
        {
            userDAO = new UsuarioDAO();
        }

        public long Inserir(string nome, string rg, string cpf, string login, string senha, int tipo_per)
        {
            long id_usuer = -1; 
            using (TransactionScope transaction = new TransactionScope())
            {
                try
                {
                    if (new Validation().ValidateCPF(cpf))
                    {
                        Permissao p = new Permissao();
                        p.Tipo = tipo_per;
                        p.Descricao = (tipo_per == 1) ? "Admistrador" : "Comum";
                                 
                        Usuario u = new Usuario();
                        u.Nome = nome;
                        u.RG = rg;
                        u.CPF = cpf;
                        u.Login = login;
                        u.Senha = senha;
                        u.CodigoPermissao = new PermissaoDAO().Inserir(p);
                        id_usuer = userDAO.Inserir(u);
                    }

                    transaction.Complete();
                    transaction.Dispose();
                }
                catch(TransactionException ex)
                {
                    transaction.Dispose();
                }
            }
            return id_usuer;
        }

        public bool Atualizar(int cod_u, string nome, string rg, string cpf, string login, string senha)
        {
            if (new Validation().ValidateCPF(cpf))
            {
                Usuario u = new Usuario();
                u.CodigoUsuario = cod_u;
                u.Nome = nome;
                u.RG = rg;
                u.CPF = cpf;
                u.Login = login;
                u.Senha = senha;
                return userDAO.Atualizar(u);
            }

            return false;
        }

        public bool Remover(int cod_user)
        {
            Usuario u = new Usuario();
            u.CodigoUsuario = cod_user;
            u.Status = 9;
            return userDAO.Remover(u);
        }

        public bool Inativar(int cod_user)
        {
            Usuario u = new Usuario();
            u.CodigoUsuario = cod_user;
            u.Status = 2;
            return userDAO.Remover(u);
        }

        public bool Ativar(int cod_user)
        {
            Usuario u = new Usuario();
            u.CodigoUsuario = cod_user;
            u.Status = 1;
            return userDAO.Remover(u);
        }

        public bool Autenticar(string login, string senha)
        {
            foreach (Usuario user in Listar())
                if (user.Login.Equals(login) && user.Senha.Equals(senha))
                    return true;
            return false;
        }

        public Usuario Busca(int id)
        {
            foreach (Usuario user in Listar())
                if (user.CodigoUsuario.Equals(id))
                    return user;
            return null;
        }

        public List<Usuario> Listar()
        {
            return userDAO.Listar();
        }
    }
}
using Persistencia.DAO;
using Persistencia.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Persistencia.Service
{
    public class ClienteService
    {
        private ClienteDAO clienteDAO;
        private EnderecoDAO enderecoDAO;
        private PessoaFisicaDAO pFisicaDAO;
        private PessoaJuridicaDAO pJuridicaDAO;
        private TelefoneClienteDAO telefoneClienteDAO;
        private TelefoneFornecedorDAO telefoneFornecedorDAO;
        public ClienteService()
            
        {
            clienteDAO = new ClienteDAO();
            enderecoDAO = new EnderecoDAO();
            pFisicaDAO = new PessoaFisicaDAO();
            pJuridicaDAO = new PessoaJuridicaDAO();
            telefoneClienteDAO = new TelefoneClienteDAO();
            telefoneFornecedorDAO = new TelefoneFornecedorDAO();
        }

        public List<Cliente> Listar()
        {
            List<Cliente> clientes = new ClienteDAO().Listar();
            return clientes;
        }

        public Cliente Buscar(long codCliente)
        {
            Cliente cliente = new ClienteDAO().Buscar(codCliente);
            return cliente;
        }

        public Endereco BuscarEndereco(long codEndereco)
        {
            Endereco endereco = new EnderecoDAO().Buscar(codEndereco);
            return endereco;
        }

        public TelefoneCliente BuscarTelefoneCliente(long cod)
        {
            TelefoneCliente telefoneCliente = new TelefoneClienteDAO().BuscarTelefoneCliente(cod);
            return telefoneCliente;
        }

        public TelefoneCliente BuscarTelefoneFornecedor(long cod)
        {
            TelefoneCliente telefoneFornecedor = new TelefoneClienteDAO().BuscarTelefoneFornecedor(cod);
            return telefoneFornecedor;
        }

        public PessoaFisica BuscarPessoaFisica(long codCliente)
        {
            PessoaFisica pessoaFisica = new PessoaFisicaDAO().BuscarPorCliente(codCliente);

            return pessoaFisica;
        }

        public PessoaJuridica BuscarPessoaJuridica(long codCliente)
        {
            PessoaJuridica pessoaJuridica = new PessoaJuridicaDAO().BuscarPorCliente(codCliente);

            return pessoaJuridica;
        }

        public long Inserir(bool pessoaFisica, bool pessoaJuridica,String nomeFantasia,String razaoSocial,String cnpj,String InscEstadual,String nome,String rg,String cnh,string passaporte,string cpf,string naturalidade,string dataNascimento,string cep,string bairro,string telefone,string email, string logradouro,string numero,string cidade,string estado)
        {

            long id_endereco = -1;
            long id_cliente = -1;
            long id_pessoaFisica = -1;
            long id_pessoaJuridica = -1;
            long id_telefoneCliente = -1;
            long id_telefoneFornecedor = -1;

            if (pessoaFisica == true)
            {
                if ((nome != "") && (rg != "") && (cnh != "") && (passaporte != "") && (cpf != "") && (naturalidade != "") && (dataNascimento != "") && (cep != "") && (bairro != "") && (telefone != "") && (email != "") && (logradouro != "") && (numero != "") && (cidade != "") && (estado != ""))

                {
                    using (TransactionScope transaction = new TransactionScope())
                    {
                        try
                        {
                            Cliente cliente = new Cliente();
                            PessoaFisica pFisica = new PessoaFisica();
                            Endereco endereco = new Endereco();
                            TelefoneCliente telefoneCliente = new TelefoneCliente();
     
                            endereco.Bairro = bairro;
                            endereco.CEP = cep;
                            endereco.Cidade = cidade;
                            endereco.Estado = estado;
                            endereco.Logradouro = logradouro;
                            endereco.Numero = numero;
                            endereco.Status = 1;

                            id_endereco = enderecoDAO.Inserir(endereco);

                            cliente.CodigoEndereco = id_endereco;
                            cliente.Email = email;
                            cliente.Status = 1;

                            id_cliente = clienteDAO.Inserir(cliente);

                            pFisica.CNH = cnh;
                            pFisica.CodigoCliente = id_cliente;
                            pFisica.CPF = cpf;
                            pFisica.DataNascimento = dataNascimento;
                            pFisica.Naturalidade = naturalidade;
                            pFisica.Nome = nome;
                            pFisica.Passaporte = passaporte;
                            pFisica.RG = rg;
                            pFisica.Status = 1;

                            id_pessoaFisica = pFisicaDAO.Inserir(pFisica);

                            telefoneCliente.CodigoCliente = pFisica.CodigoCliente;
                            telefoneCliente.Telefone = telefone;
          
                            telefoneCliente.Status = 1;

                            id_telefoneCliente = telefoneClienteDAO.Inserir(telefoneCliente);

                            transaction.Complete();
                        }
                        catch (TransactionException )
                        {

                        }
                    }
           

                }
            }
            else if (pessoaJuridica == true)
            {
                if ((nomeFantasia != "") && (razaoSocial != "") && (cnpj != "") && (InscEstadual != "") && (cep != "") && (bairro != "") && (telefone != "") && (email != "") && (logradouro != "") && (numero != "") && (cidade != "") && (estado != ""))
                {
                    using (TransactionScope transaction = new TransactionScope())
                    {
                        try
                        {
                            Cliente cliente = new Cliente();
                            PessoaJuridica pJuridica = new PessoaJuridica();
                            Endereco endereco = new Endereco();
                            TelefoneFornecedor telefoneFornecedor = new TelefoneFornecedor();


                            endereco.Bairro = bairro;
                            endereco.CEP = cep;
                            endereco.Cidade = cidade;
                            endereco.Estado = estado;
                            endereco.Logradouro = logradouro;
                            endereco.Numero = numero;
                            endereco.Status = 1;

                            id_endereco = enderecoDAO.Inserir(endereco);

                            cliente.CodigoEndereco = id_endereco;
                            cliente.Email = email;
                            cliente.Status = 1;

                            id_cliente = clienteDAO.Inserir(cliente);

                            pJuridica.CNPJ = cnpj;
                            pJuridica.CodigoCliente = id_cliente;
                            pJuridica.InscricaoEstadual = InscEstadual;
                            pJuridica.NomeFantasia = nomeFantasia;
                            pJuridica.RazaoSocial = razaoSocial;
                            pJuridica.Status = 1;

                            id_pessoaJuridica = pJuridicaDAO.Inserir(pJuridica);

                            telefoneFornecedor.CodigoFornecedor = pJuridica.CodigoCliente;
                            telefoneFornecedor.Telefone = telefone;
                            telefoneFornecedor.Status = 1;

                            id_telefoneFornecedor = telefoneClienteDAO.InserirTelefoneFornecedor(telefoneFornecedor);

                            transaction.Complete();
                        }
                        catch (TransactionException )
                        {

                        }
                    }
                   
                }
            }

            return id_cliente;

        }
    }
}

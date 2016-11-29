using Persistencia.DAO;
using Persistencia.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Service
{
   public class LocacaoService
    {
        private ReservaDAO reservaDAO;
        public LocacaoService()
        {
            reservaDAO = new ReservaDAO();
        }
        public Veiculo BuscarVeiculo(long codveiculo)
        {
            return new VeiculoDAO().Buscar(codveiculo);
        }

        public string BuscarCliente(long codveiculo)
        {
            string nomecliente = "";

            ClienteService clienteService = new ClienteService();

            string tipoPessoa = clienteService.TipoDePessoa(codveiculo);

            if (tipoPessoa == "PF")
            {
                PessoaFisica pessoaFisica = clienteService.BuscarPessoaFisica(codveiculo);
                nomecliente = pessoaFisica.Nome;

            }
            else if (tipoPessoa == "PJ")
            {
                PessoaJuridica pessoaJuridica = clienteService.BuscarPessoaJuridica(codveiculo);
                nomecliente = pessoaJuridica.NomeFantasia;
            }
            return nomecliente;
        }

        public bool EfetuarReserva(long codveiculo,long codcliente,DateTime dataretirada,DateTime dataentrega,string tiporetirada,string formapagamento,string valorpedido,string nomeuser)
        {
            bool resultado = false;
            Usuario usuario = new UsuarioService().BuscaNome(nomeuser);

            if (codveiculo != 0 && codcliente != 0 && dataretirada != null && dataentrega != null && tiporetirada != "" && formapagamento != "" && valorpedido != "" && usuario.CodigoUsuario != 0)
            {
                Reserva reserva = new Reserva();

                reserva.CodigoCliente = codcliente;
                reserva.CodigoVeiculo = codveiculo;
                reserva.CodigoUsuario = usuario.CodigoUsuario;
                reserva.DataEntrega = dataentrega;
                reserva.DataRetirada = dataretirada;
                reserva.TipoRetirada = tiporetirada;
                reserva.FormaPagamento = formapagamento;
                reserva.ValorLocacao = Decimal.Parse(valorpedido);
                reserva.DataReserva = DateTime.Now;
                reserva.Situacao = "Reserva";

                reservaDAO.Inserir(reserva);
                resultado = true;


            }
            return resultado;


        }

        public decimal CalculaPedido(DateTime dataretirada, DateTime dataentrega,long codveiculo)
        {
            decimal resultado = 0.00m;

            if (codveiculo != 0 || codveiculo != null)
            {
                if (dataretirada > dataentrega)
                {
                    Veiculo veiculo = new VeiculoDAO().Buscar(codveiculo);
                    Categoria categoria = new CategoriaDAO().Buscar(veiculo.CodigoCategoria);

                    DateTime oldDate = dataretirada;
                    DateTime newDate = dataentrega;
                    TimeSpan ts = newDate - oldDate;
                    int differenceInDays = ts.Days;

                    resultado = differenceInDays * categoria.Valor;
                    return resultado;

                }
                return 0;

            }
            return 1;

        }
    }
}

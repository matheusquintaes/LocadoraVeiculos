using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Modelo
{
    public class Reserva
    {
        public long NumeroReserva { get; set; }
        public DateTime DataReserva { get; set; }
        public string FormaPagamento { get; set; }
        public string TipoRetirada { get; set; }
        public DateTime DataEntrega { get; set; }
        public DateTime DataRetirada { get; set; }
        public string Situacao { get; set; }
        public long CodigoCliente { get; set; }
        public long CodigoUsuario { get; set; }
        public long CodigoVeiculo { get; set; }
        public int Status { get; set; }
        public Decimal ValorLocacao { get; set; }
    }
}

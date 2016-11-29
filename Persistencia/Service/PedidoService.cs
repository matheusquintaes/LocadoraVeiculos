using Persistencia.DAO;
using Persistencia.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Service
{
    public class PedidoService
    {

        private ReservaDAO reservaDAO;
        public PedidoService()
        {
            reservaDAO = new ReservaDAO();
        }

        public List<Reserva> Listar()
        {
            List<Reserva> reservas = new ReservaDAO().Listar();
            return reservas;
        }

        public Reserva Buscar(long codReserva)
        {
            Reserva reserva = new ReservaDAO().Buscar(codReserva);
            return reserva;
        }

    }
}

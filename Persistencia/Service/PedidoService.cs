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
            reservas.Reverse();
            return reservas; 
        }

        public Reserva Buscar(long codReserva)
        {
            Reserva reserva = new ReservaDAO().Buscar(codReserva);
            return reserva;
        }

        public String StatusDaReserva(long status)
        {
            if (status == 2)
            {
                return "Em Reserva";
            } else
            {
                return "Devolvido";
            }
        }

        public bool VerificaStatusReserva(long status)
        {
            if (status == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

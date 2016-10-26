using Persistencia.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia.Service
{
    class VeiculoService
    {
        private VeiculoDAO veiculoDAO;
        public VeiculoService()
        {
            veiculoDAO = new VeiculoDAO();
        }
    }
}

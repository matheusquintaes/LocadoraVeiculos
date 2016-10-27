using Persistencia.DAO;
using Persistencia.Modelo;
using Persistencia.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace Persistencia.Service
{
    public class VeiculoService
    {
        private VeiculoDAO veiculoDAO;
        public VeiculoService()
        {
            veiculoDAO = new VeiculoDAO();
        }

        public long Inserir(String marca, String modelo, String km, String AnoFabricacao, int condicao, bool vidro, bool trava, bool automatico, int quantidadePortas, bool direcao, bool ar, String cor, long categoria, int status)
        {

            long id_veiculo = -1;

            using (TransactionScope transaction = new TransactionScope())
            {
                try
                {
                    Veiculo v = new Veiculo();

                    v.Marca = marca;
                    v.Modelo = modelo;
                    v.KM = km;
                    v.AnoFabricacao = AnoFabricacao;
                    v.Condicao = condicao;
                    v.VidroEletrico = vidro;
                    v.TravaEletrica = trava;
                    v.Automatico = automatico;
                    v.QuantidadePortas = quantidadePortas;
                    v.DirecaoHidraulica = direcao;
                    v.ArCondicionado = ar;
                    v.Cor = cor;
                    v.CodigoCategoria = categoria;
                    v.Status = status;

                    id_veiculo = veiculoDAO.Inserir(v);

                    transaction.Complete();
                    transaction.Dispose();

                }

                catch (TransactionException ex)
                {
                    transaction.Dispose();
                }
            }
            return id_veiculo;
        }
    }
}

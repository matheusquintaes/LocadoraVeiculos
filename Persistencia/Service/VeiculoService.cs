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

        public long Inserir(String marca, 
            String modelo, 
            String km, 
            String AnoFabricacao, 
            bool vidro, 
            bool trava, 
            bool automatico, 
            int quantidadePortas, 
            bool direcao, 
            bool ar,
            String cor, 
            String combustivel,
            String tanque,
            long categoria,
            String placa,
            String renavam,
            String chassi,
            String dataLicenciamento,
            long fornecedor)
            {

            if ((marca != "") && (modelo != "") && (km != "") && (AnoFabricacao != "") && (cor != "") && (combustivel != "") && (tanque != "")
                && (categoria != 0) && (placa != "") && (renavam != "") && (chassi != "") && (dataLicenciamento != "") && (fornecedor != 0))
            {

                long id_veiculo = -1;

                using (TransactionScope transaction = new TransactionScope())
                {
                    try
                    {
                        Veiculo veiculo = new Veiculo();
                        Documento documento = new Documento();
                        VeiculoTemFornecedor veiculoFornecedor = new VeiculoTemFornecedor();

                        //Veiculo
                        veiculo.Marca = marca;
                        veiculo.Modelo = modelo;
                        veiculo.KM = km;
                        veiculo.AnoFabricacao = AnoFabricacao;
                        veiculo.VidroEletrico = vidro;
                        veiculo.TravaEletrica = trava;
                        veiculo.Automatico = automatico;
                        veiculo.QuantidadePortas = quantidadePortas;
                        veiculo.DirecaoHidraulica = direcao;
                        veiculo.ArCondicionado = ar;
                        veiculo.Cor = cor;
                        veiculo.CodigoCategoria = categoria;
                        veiculo.Combustivel = combustivel;
                        veiculo.Tanque = tanque;
                        veiculo.Status = 1;

                        id_veiculo = veiculoDAO.Inserir(veiculo);

                        //Documento
                        documento.Placa = placa;
                        documento.Renavam = renavam;
                        documento.CodigoVeiculo = id_veiculo;
                        documento.DataLicenciamento = dataLicenciamento;
                        documento.Chassi = chassi;
                        documento.Status = 1;

                        long id_documento = new DocumentoDAO().Inserir(documento);

                        //VeiculoTemFornecedor
                        veiculoFornecedor.CodigoFornecedor = 1;
                        veiculoFornecedor.CodigoVeiculo = id_veiculo;
                        veiculoFornecedor.Status = 1;

                        long idVeiculoTemFornecedor = new VeiculoTemFornecedorDAO().Inserir(veiculoFornecedor);

                        transaction.Complete();
                        transaction.Dispose();

                    }

                    catch (TransactionException ex)
                    {
                        transaction.Dispose();
                    }
                }
                return id_veiculo;
            } else
            {
                return -1;
            }
        }
    }
}

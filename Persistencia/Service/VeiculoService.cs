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

        public bool Atualizar(
            long codVeiculo,
            long codCategoria,
            long codFornecedor,
            String marca,
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
            String mesDataLicenciamento,
            String anoDataLicenciamento
            )
        {
            if ((codCategoria != 0) && (codFornecedor != 0) &&(marca != "") && (modelo != "") && (km != "") && (AnoFabricacao != "") && (cor != "") && (combustivel != "") && (tanque != "")
                && (categoria != 0) && (placa != "") && (renavam != "") && (chassi != "") && (mesDataLicenciamento != "") && (anoDataLicenciamento != ""))
            {
                using (TransactionScope transaction = new TransactionScope())
                {
                    try
                    {

                        Veiculo veiculo = new Veiculo();
                        Documento documento = new Documento();
                        VeiculoTemFornecedor veiculoFornecedor = new VeiculoTemFornecedor();

                        //Veiculo
                        veiculo.CodigoVeiculo = codVeiculo;
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
                
                        //Documento
                        documento.Placa = placa;
                        documento.Renavam = renavam;
                        documento.CodigoVeiculo = codVeiculo;
                        documento.MesDataLicenciamento = mesDataLicenciamento;
                        documento.AnoDataLicenciamento = anoDataLicenciamento;
                        documento.Chassi = chassi;
                        documento.Status = 1;
                        Documento documentoCod = new DocumentoDAO().Buscar(codVeiculo);
                        documento.CodigoDocumento = documentoCod.CodigoDocumento;

                        //VeiculoTemFornecedor
                        VeiculoTemFornecedor docCodigo = new VeiculoTemFornecedorDAO().Buscar(codVeiculo);
                        veiculoFornecedor.CodigoVeiculoTemFornecedor = docCodigo.CodigoVeiculoTemFornecedor;
                        veiculoFornecedor.CodigoFornecedor = codFornecedor;
                        veiculoFornecedor.CodigoVeiculo = codVeiculo;
                        veiculoFornecedor.Status = 1;

                        new VeiculoDAO().Atualizar(veiculo);
                        new DocumentoDAO().Atualizar(documento);
                        new VeiculoTemFornecedorDAO().Atualizar(veiculoFornecedor);
        
                        transaction.Complete();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Houve um erro " + ex);
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Remover(long CodigoVeiculo)
        {
            if (CodigoVeiculo != 0)
            {

                using (TransactionScope transaction = new TransactionScope())
                {
                    try
                    {
                        Veiculo veiculo = new Veiculo();

                        veiculo.CodigoVeiculo = CodigoVeiculo;
                        veiculo.Status = 9;

                        new VeiculoDAO().Remover(veiculo);

                        VeiculoTemFornecedor veiculoTemFornecedor = new VeiculoTemFornecedor();

                        veiculoTemFornecedor.CodigoVeiculo = CodigoVeiculo;
                        veiculoTemFornecedor.Status = 9;

                        new VeiculoTemFornecedorDAO().Remover(veiculoTemFornecedor);

                        Documento documento = new Documento();

                        documento.CodigoVeiculo = CodigoVeiculo;
                        documento.Status = 9;

                        new DocumentoDAO().Remover(documento);

                        transaction.Complete();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex);
                    }

                    return true;
                }
            }

            return false;
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
            String mesDataLicenciamento,
            String anoDataLicenciamento,
            long fornecedor)
            {

            if ((marca != "") && (modelo != "") && (km != "") && (AnoFabricacao != "") && (cor != "") && (combustivel != "") && (tanque != "")
                && (categoria != 0) && (placa != "") && (renavam != "") && (chassi != "") && (mesDataLicenciamento != "") && (anoDataLicenciamento != "")  && (fornecedor != 0))
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
                        documento.MesDataLicenciamento = mesDataLicenciamento;
                        documento.AnoDataLicenciamento = anoDataLicenciamento;
                        documento.Chassi = chassi;
                        documento.Status = 1;

                        long id_documento = new DocumentoDAO().Inserir(documento);

                        //VeiculoTemFornecedor
                        veiculoFornecedor.CodigoFornecedor = fornecedor;
                        veiculoFornecedor.CodigoVeiculo = id_veiculo;
                        veiculoFornecedor.Status = 1;

                        long idVeiculoTemFornecedor = new VeiculoTemFornecedorDAO().Inserir(veiculoFornecedor);

                        transaction.Complete();

                    }

                    catch (TransactionException ex)
                    {

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

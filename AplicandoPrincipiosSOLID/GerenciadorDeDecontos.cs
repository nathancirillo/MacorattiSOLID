using System;
using System.Collections.Generic;
using System.Text;

namespace AplicandoPrincipiosSOLID
{
    class GerenciadorDeDecontos
    {
        private readonly ICalculaDescontoFidelidade calculaDescontoFidelidade;
        private readonly ICalculaDescontoStatusContaFactory calculaDescontoStatusContaFactory; 

        public GerenciadorDeDecontos(ICalculaDescontoFidelidade _calculaDescontoFidelidade, ICalculaDescontoStatusContaFactory _calculaDescontoStatusContaFactory)
        {
            calculaDescontoFidelidade = _calculaDescontoFidelidade;
            calculaDescontoStatusContaFactory = _calculaDescontoStatusContaFactory;
        }
        public decimal AplicarDesconto(decimal precoProduto, EStatusContaCliente statusContaCliente, int anos)
        {
            decimal precoAposDesconto = calculaDescontoStatusContaFactory.GetDescontoStatusConta(statusContaCliente).AplicaDescontoStatusConta(precoProduto);
            precoAposDesconto = calculaDescontoFidelidade.AplicarDescontoFidelidade(precoAposDesconto, anos);           
            return precoAposDesconto;
        }
    }

    public static class Constantes
    {
        public const int DESCONTO_MAXIMO = 5;
        public const decimal DESCONTO_CLIENTE_COMUM = 0.1m;
        public const decimal DESCONTO_CLIENTE_ESPECIAL = 0.3m;
        public const decimal DESCONTO_CLIENTE_CLIENTEVIP = 0.5m;
    }
}

using ResolvendoProblema1;
using ResolvendoProblema1.Desconto;
using ResolvendoProblema1.StatusConta;
using System;

namespace IdentificandoProblema2
{


    public class GerenciadorDeDescontos
    {
        private readonly ICalculaDescontoFidelidade descontoFidelidade;
        private readonly IcalculaDescontoStatusContaFactory descontoStatusConta;
        public GerenciadorDeDescontos(ICalculaDescontoFidelidade _descontoFidelidade, IcalculaDescontoStatusContaFactory _descontoStatusConta)
        {
            descontoFidelidade = _descontoFidelidade;
            descontoStatusConta = _descontoStatusConta;
        }


        public decimal AplicarDesconto(decimal precoProduto, StatusContaCliente statusContaCliente, int tempoDeContaEmAnos)
        {
            decimal precoAposDesconto = 0;

            precoAposDesconto = descontoStatusConta.GetCalculaDescontoStatusConta(statusContaCliente).AplicarDescontoStatusConta(precoProduto);
            precoAposDesconto = descontoFidelidade.AplicarDescontoFidelidade(precoAposDesconto, tempoDeContaEmAnos);

            return precoAposDesconto;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace ResolvendoProblema1.StatusConta
{
    public class CalculaDescontoStatusContaFactory : IcalculaDescontoStatusContaFactory
    {
        public ICalculaDescontoStatusConta GetCalculaDescontoStatusConta(StatusContaCliente statusContaCliente)
        {
            ICalculaDescontoStatusConta iCalcular;

            switch (statusContaCliente)
            {
                case StatusContaCliente.NaoRegistrado:
                    iCalcular = new ClienteNaoRegistrado();
                    break;

                case StatusContaCliente.ClienteComum:
                    iCalcular = new ClienteComum();
                    break;

                case StatusContaCliente.ClienteEspecial:
                    iCalcular = new ClienteEspecial();
                    break;

                case StatusContaCliente.ClienteVIP:
                    iCalcular = new ClienteVip();
                    break;

                default:
                    throw new NotImplementedException(); //Lançar execption caso entre algum status de conta diferente, tranto assim algum bug oculto

            }
            return iCalcular;
        }
    }
}

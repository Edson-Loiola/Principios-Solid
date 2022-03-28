using System;
using System.Collections.Generic;
using System.Text;

namespace ResolvendoProblema1.StatusConta
{
    public interface IcalculaDescontoStatusContaFactory
    {
        ICalculaDescontoStatusConta GetCalculaDescontoStatusConta(StatusContaCliente statusContaCliente);
    }
}

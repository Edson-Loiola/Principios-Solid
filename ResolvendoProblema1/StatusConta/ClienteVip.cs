using System;
using System.Collections.Generic;
using System.Text;

namespace ResolvendoProblema1.StatusConta
{
    class ClienteVip : ICalculaDescontoStatusConta
    {
        public decimal AplicarDescontoStatusConta(decimal preco)
        {
            return (preco - (Constantes.DESCONTO_CLIENTE_VIP * preco));
        }
    }
}

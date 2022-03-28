using System;
using System.Collections.Generic;
using System.Text;

namespace ResolvendoProblema1.StatusConta
{
    class ClienteEspecial : ICalculaDescontoStatusConta
    {
        public decimal AplicarDescontoStatusConta(decimal preco)
        {
           return preco - (Constantes.DESCONTO_CLIENTE_ESPECIAL * preco);
        }
    }
}

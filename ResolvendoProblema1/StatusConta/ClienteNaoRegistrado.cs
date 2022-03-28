using System;
using System.Collections.Generic;
using System.Text;

namespace ResolvendoProblema1.StatusConta
{
    class ClienteNaoRegistrado : ICalculaDescontoStatusConta
    {
        public decimal AplicarDescontoStatusConta(decimal preco)
        {
            return preco;
        }
    }
}

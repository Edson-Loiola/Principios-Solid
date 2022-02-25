using System;
using System.Collections.Generic;
using System.Text;

namespace Principio_OCP_2
{
    class DescontoClienteEspecial : Pedido
    {
        public override double DescontoPedido(double valorfinal)
        {
            return valorfinal - 50;
        }
    }
}

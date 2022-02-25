using System;
using System.Collections.Generic;
using System.Text;

namespace Principio_OCP_2
{
    public class Pedido
    {
        public virtual double DescontoPedido(double valorfinal)
        {
            return valorfinal;
        }
    }
}

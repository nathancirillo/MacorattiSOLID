using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
    class DescontoClienteVip : PedidoComOCP 
    {
        public override double DescontoPedido(double valor)
        {
            return valor - 100;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
    class DescontoClienteAssociado : PedidoComOCP
    {
        public override double DescontoPedido(double valor)
        {
            return valor - 10; 
        }
    }
}

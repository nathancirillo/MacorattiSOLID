using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
    class PedidoComOCP
    {
        public virtual double DescontoPedido(double valor)
        {
            return valor; 
        }
    }
}

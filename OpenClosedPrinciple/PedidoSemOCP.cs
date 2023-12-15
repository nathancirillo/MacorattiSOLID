using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
    public enum TipoCliente
    {
        Comum,
        Associado,
        Especial
    }

    class PedidoSemOCP
    {

        /*viola o princípio de OCP, pois se precisar, por exemplo, adicionar um novo tipo de cliente
         será necessário alterar a implementação.
         */
        
        public double DescontoPedido(double valor, TipoCliente tipoCliente)
        {
            double valorFinal;

            if (tipoCliente == TipoCliente.Especial)
            {
                valorFinal = valor - 50;
            }
            else if (tipoCliente == TipoCliente.Associado)
            {
                valorFinal = valor - 10;
            }
            else
            {
                valorFinal = valor; 
            }

            return valorFinal;
        }

    }
}

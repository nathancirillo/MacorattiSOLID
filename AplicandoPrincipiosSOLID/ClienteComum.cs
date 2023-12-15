using System;
using System.Collections.Generic;
using System.Text;

namespace AplicandoPrincipiosSOLID
{
    class ClienteComum : ICalculaDescontoStatusConta
    {
        public decimal AplicaDescontoStatusConta(decimal preco)
        {
            return (preco - (Constantes.DESCONTO_CLIENTE_COMUM * preco));
        }
    }
}

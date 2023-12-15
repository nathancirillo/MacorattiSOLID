using System;
using System.Collections.Generic;
using System.Text;

namespace AplicandoPrincipiosSOLID
{
    class ClienteEspecial : ICalculaDescontoStatusConta
    {
        public decimal AplicaDescontoStatusConta(decimal preco)
        {
            return (preco - (Constantes.DESCONTO_CLIENTE_ESPECIAL * preco));
        }
    }
}

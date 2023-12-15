using System;
using System.Collections.Generic;
using System.Text;

namespace AplicandoPrincipiosSOLID
{
    class ClienteNaoRegistrado : ICalculaDescontoStatusConta
    {
        public decimal AplicaDescontoStatusConta(decimal preco)
        {
            return preco; 
        }
    }
}

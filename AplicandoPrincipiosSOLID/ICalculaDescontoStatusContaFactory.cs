using System;
using System.Collections.Generic;
using System.Text;

namespace AplicandoPrincipiosSOLID
{
    interface ICalculaDescontoStatusContaFactory
    {
        public ICalculaDescontoStatusConta GetDescontoStatusConta(EStatusContaCliente statusContaCliente);
    }

}

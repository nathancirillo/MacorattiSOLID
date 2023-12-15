using System;
using System.Collections.Generic;
using System.Text;

namespace AplicandoPrincipiosSOLID
{
    public class CalculaDescontoStatusContaFactory : ICalculaDescontoStatusContaFactory
    {
        public ICalculaDescontoStatusConta GetDescontoStatusConta(EStatusContaCliente statusContaCliente)
        {
            switch (statusContaCliente)
            {
                case EStatusContaCliente.NaoRegistrado:
                    return new ClienteNaoRegistrado();               
                case EStatusContaCliente.ClienteComum:
                    return new ClienteComum();
                case EStatusContaCliente.ClienteEspecial:
                    return new ClienteEspecial();
                case EStatusContaCliente.ClienteVip:
                    return new ClienteVIP();
                default:
                    throw new NotImplementedException();
            }
            
        }
    }
}

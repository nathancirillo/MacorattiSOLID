using System;
using System.Collections.Generic;
using System.Text;

namespace AplicandoPrincipiosSOLID
{
    interface ICalculaDescontoFidelidade
    {
        decimal AplicarDescontoFidelidade(decimal preco, int anos);
    }
}

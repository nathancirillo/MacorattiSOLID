using System;
using System.Collections.Generic;
using System.Text;

namespace AplicandoPrincipiosSOLID
{
    class CalculaDescontoFidelidade : ICalculaDescontoFidelidade
    {
        public decimal AplicarDescontoFidelidade(decimal preco, int anos)
        {
            decimal descontoPorFidelidade = (anos > Constantes.DESCONTO_MAXIMO) ? 
                                            (decimal)Constantes.DESCONTO_MAXIMO / 100 : 
                                            (decimal)anos / 100;

            return preco - (descontoPorFidelidade * preco);
        }
    }
}

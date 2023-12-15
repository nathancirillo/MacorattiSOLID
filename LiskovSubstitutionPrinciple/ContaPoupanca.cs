using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple
{
    class ContaPoupanca : Conta
    {
        public override void Saque(double valor)
        {
            if (Saldo >= valor)
            {
                Saldo -= valor; 
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitutionPrinciple
{
    class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }

        public virtual void Saque(double valor)
        {
            Saldo -= valor; 
        }
    }
}

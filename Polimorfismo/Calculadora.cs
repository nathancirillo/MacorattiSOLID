using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    static class Calculadora
    {
        public static int Soma(int n1, int n2, int n3)
        {
            return n1 + n2 + n3; 
        }

        public static int Soma(int n1, int n2)
        {
            return n1 + n2; 
        }
    }
}

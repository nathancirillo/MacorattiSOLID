using System;
using System.Collections.Generic;
using System.Text;

namespace Sobrecarga
{
    public class Calculadora
    {
        public static int Somar(int num1, int num2)
        {
            return num1 + num2; 
        }

        public static double Somar(double num1, int num2, int num3)
        {
            return num1 + num2 + num3; 
        }

        public static int Somar(params int[] numeros)
        {
            var total = 0;
            foreach (var numero in numeros)
            {
                total += numero; 
            }
            return total; 
        }
    }
}

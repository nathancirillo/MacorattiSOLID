using System;

namespace Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Dois parâmetros: {Calculadora.Somar(2, 2)}");
            Console.WriteLine($"Três parâmetros: {Calculadora.Somar(2.5,3,5)}");
            Console.WriteLine($"Array int: {Calculadora.Somar(4,4,4,4,4,4,4,4,4,4)}");
            Console.ReadLine();
        }
    }
}

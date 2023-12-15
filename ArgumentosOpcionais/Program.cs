using System;

namespace ArgumentosOpcionais
{
    class Program
    {
        static void Main(string[] args)
        {
            //Posso chamar o método passando até 4 valores, sendo o primeiro obrigatório. 
            //o restante é opcional.
            int valor = Calculadora.Soma(10,30);
            Console.WriteLine($"Valor calculado = {valor}");
            Console.ReadLine();
        }
    }

    class Calculadora
    {
        public static int Soma(int n1, int n2=20, int n3=30, int n4=40)
        {
            return n1 + n2 + n3 + n4;
        }
    }
}

using System;

namespace ClasseSelada
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculo calc = new Calculo();
            calc.Soma(2, 2);
        }
    }

    /*
        Uma classe selada não pode ser herdada, por esse motivo a implementação comentada
        abaixo não irá funcionar. No entanto é possível usar seus métodos normalmente via
        instanciação. 
     */

    sealed class Calculo
    {
        public void Soma(int n1, int n2)
        {
            Console.WriteLine("A soma é : " + (n1+n2));
        }
    }

    //class Calculadora : Calculo
    //{ 
    //}
}

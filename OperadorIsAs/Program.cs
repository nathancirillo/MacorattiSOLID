using System;

namespace OperadorIsAs
{
    public class Forma
    {
        public virtual void Desenhar()
        {
            Console.WriteLine("Desenhando Forma...");
        }
    }

    public class Circulo : Forma
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhando Círculo...");
        }

        public void PintarCirculo()
        {
            Console.WriteLine("Pintando Circulo...");
        }
    }

    class Program
    {
        /* O uso do operador "as" é útil para as operações de downcasting, onde pode haver exceções.
         * Ele faz a conversão entre tipos de referência e tipos anuláveis. Se compatível retorna
         * o objeto, caso contrário retorna null ao invés de exceção. 
         */
        
        /*
           Outro operador usado para assegurar o  Downcasting é o "is". 
           Verifica se o objeto é compatível com o tipo específicado ou não. 
           Em caso positivo retorna true, caso contrário false. Assim verificamos se a conversão será bem sucedida.
         */


        static void Main(string[] args)
        {
            //DownCasting_As();
            DownCasting_Is();

        }

        private static void DownCasting_Is()
        {
            Circulo circulo = new Circulo();
            Forma f = circulo;
            if (f is Circulo)
            {
                ((Circulo)f).PintarCirculo();
            }
            else
            {
                Console.WriteLine("Operação de Downcasting inválida!");
            }
        }

        private static void DownCasting_As()
        {
            Forma f = new Forma();
            var circulo = f as Circulo;

            if (circulo != null)
            {
                circulo.PintarCirculo();
            }
            else
            {
                Console.WriteLine("Operação de Downcasting inválida!");
            }
        }
    }
}

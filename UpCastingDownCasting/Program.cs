using System;

namespace UpCastingDownCasting
{
    class Program
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
                Console.WriteLine("Desenhando Circulo...");   
            }

            public void PintarCirculo()
            {
                Console.WriteLine("Pintando Circulo...");
            }
        }


        static void Main(string[] args)
        {
            Circulo circulo = new Circulo();
            
            /*
                Isso é um exemplo de UpCasting. Estou convertendo um objeto mais específico
                para um que seja mais geral. 
             */
            Forma f = circulo;
            Console.WriteLine($"São o mesmo objeto = {f == circulo}.");
            f.Desenhar();

            /*
             * Se tentar acessar o método PintarCirculo usando a referência f não será possível, 
             * pois o mesmo é do tipo forma: 
             * f.PintarCirculo();
             * Para conseguir acessá-lo é necessário realizar o DownCasting. Ou seja, converter
             * do tipo mais generalizado para o mais específico. Trata-se de uma operação explícita
             * e nem sempre será possível. 
             */

            // Isso é o chamado Downcasting: no entanto pode haver problemas então 
            // é possível fazer isso através dos operadores is e as. 
            Circulo c = (Circulo)f;
            Console.WriteLine($"São o mesmo objeto = {c == f}");
            c.PintarCirculo();


        }
    }
}

using System;

namespace ClasseAbstrata
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Classes abstratas não podem ser implementadas, ou seja, não pode ser instâncias.
             */
            //Forma f = new Forma();

            Quadrado q = new Quadrado();
            q.Lado = 10;
            q.CalcularArea();
            q.CalcularPerimetro();
            Console.WriteLine($"Área = {q.Area}");
            Console.WriteLine($"Perímetro = {q.Perimetro}.");
        }
    }

    public abstract class Forma
    {
        public string Cor { get; set; }
        public double Area { get; set; }
        public double Perimetro { get; set; }
        public abstract void CalcularArea();
        public abstract void CalcularPerimetro();

        public string Descricao()
        {
            return "Eu sou uma forma...";
        }

    }

    public class Quadrado : Forma
    {
        public double Lado { get; set; }
        public override void CalcularArea()
        {
            this.Area = Lado * Lado; 
        }

        public override void CalcularPerimetro()
        {
            this.Perimetro = 4 * Lado;
        }
    }
}

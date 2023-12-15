using System;

namespace HerancaConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Carro(123);
            car.Teste();
        }
    }

    public class Veiculo
    {

        private int numeroChassi; 

        public Veiculo()
        {
            Console.WriteLine("Construtor da classe pai (executará primeiro)!");
        }

        public Veiculo(int numeroChassi)
        {
            this.numeroChassi = numeroChassi;
            Console.WriteLine($"Número do chassi do Veiculo: {this.numeroChassi}");
        }

        public virtual void Teste()
        {
            Console.WriteLine("Acessei a classe Veiculo!");
        }
    }


    public class Carro : Veiculo
    {
        public Carro()
        {
            Console.WriteLine("Construtor da classe filho (executará em segundo)!");
        }

        public Carro(int numeroChassi): base(numeroChassi)
        {
            Console.WriteLine($"Número do chassi do Carro: {numeroChassi}");
        }

        public override void Teste()
        {
            base.Teste();
            Console.WriteLine("Acessei a classe Carro!");
        }
    }

}

using System;
using System.Collections.Generic;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exemplo de polimorfismo via sobrescrita (herança)
            List<Figura> listaFiguras = new List<Figura>
            {
                new Circulo(),
                new Triangulo(),
                new Quadrado()
            };

            foreach (var figura in listaFiguras)
            {
                figura.Desenhar();
            }

            //Exemplo de polimorfismo via sobrecarga
            var val1 = Calculadora.Soma(10, 10);
            var val2 = Calculadora.Soma(10, 10, 10);
            Console.WriteLine($"Valor1 = {val1} e Valor2 = {val2}.");
        }
    }
}

using System;

namespace MetodosEstaticos
{
    class Program
    {
        static void Main(string[] args)
        {
            //A palavra static em um método permite que chamá-lo sem ter um objeto da classe; 
            //O método passa a pertencer a classe e não mais ao objeto; 
            //O método estático não sabe a quem pertence. Pois ele não é de instãncia e em alguns casos viola o paradigma de encapsulamento;
            //Em outras palavras não é necessário realizar o processo de instanciação. Veja: 
            int somar = Calculadora.Somar(10, 20);
            int subtrair = Calculadora.Subtrair(40, 20);
            Console.WriteLine($"Valor soma: {somar} - Valor substração: {subtrair}.");

        }
    }
}

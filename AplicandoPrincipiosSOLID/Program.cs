using System;

namespace AplicandoPrincipiosSOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            var aplicarDesconto = new GerenciadorDeDecontos(new CalculaDescontoFidelidade(), new CalculaDescontoStatusContaFactory());
            
            var valorFinal = aplicarDesconto.AplicarDesconto(1000, EStatusContaCliente.ClienteComum, 10);
            Console.WriteLine($"Valor para cliente comum: {valorFinal.ToString("F2")}");

            valorFinal = aplicarDesconto.AplicarDesconto(1000, EStatusContaCliente.ClienteEspecial, 10);
            Console.WriteLine($"Valor para cliente especial: {valorFinal.ToString("F2")}");

            valorFinal = aplicarDesconto.AplicarDesconto(1000, EStatusContaCliente.ClienteVip, 10);
            Console.WriteLine($"Valor para cliente vip: {valorFinal.ToString("F2")}");
        }
    }
}

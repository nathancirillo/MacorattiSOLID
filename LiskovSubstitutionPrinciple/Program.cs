using System;

namespace LiskovSubstitutionPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            //usando a classe base
            Console.WriteLine("LSP - USANDO A CLASSE BASE");
            var conta = new Conta();
            conta.Saldo = 100;
            conta.Saque(250);
            Console.WriteLine($"Saldo da conta: {conta.Saldo}.");



            //usando a classe derivada nada deve mudar
            //portanto nesse exemplo está sendo infligido o LSP
            Console.WriteLine("\n\nLSP - USANDO A CLASSE DERIVADA");
            var contaPoupanca = new ContaPoupanca();
            contaPoupanca.Saldo = 100;
            contaPoupanca.Saque(250);
            Console.WriteLine($"Saldo da conta poupança: {contaPoupanca.Saldo}.");


            Console.ReadLine();
        }
    }
}

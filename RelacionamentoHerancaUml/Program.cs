using System;

namespace RelacionamentoHerancaUml
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente cr = new ContaCorrente();
            cr.Deposito(1000);
            cr.Saque(500);
            cr.DescontoJuros(100);
            Console.WriteLine($"Saldo da CR: {cr.Saldo.ToString("F2")}");

            ContaPoupanca cp = new ContaPoupanca();
            cp.Deposito(1500);
            cp.Saque(200);
            cp.CreditoJuros(100);
            Console.WriteLine($"Saldo da CP: {cp.Saldo.ToString("F2")}");
        }
    }
}

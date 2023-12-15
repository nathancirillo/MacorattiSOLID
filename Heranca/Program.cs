using System;

namespace Heranca
{
    class Conta
    {
        public int Numero { get; set; }
        public decimal Saldo { get; set; }

        public Conta()
        {
            //Esse construtor sempre será chamado primeiro na classe derivada.
            Console.WriteLine("Chamou o construtor base...");
        }

        protected virtual void ImprimirSaldo()
        {
            Console.WriteLine("R$ 99.99.");
        }

        protected void OcultarMetodo()
        {
            Console.WriteLine("Exemplo de ocultação de método na classe derivada.");
        }

    }

    class ContaCorrente : Conta
    {
        public decimal TaxaJuros { get; set; }

        protected override void ImprimirSaldo()
        {
            Console.WriteLine("Novo saldo: R$ 100,00.");
        }


        protected new void OcultarMetodo()
        {
            Console.WriteLine("Exemplo de ocultação de método...");
        }

       

        static void Main(string[] args)
        {
            // Todos os membros que são públicos: campos, propriedades e métodos são herdados. 
            // Membros do tipo privado não são herdados; 
            // Se usar o modificador protected é visível em classes derivadas (independente do assembly);
            // Se usar o modificador internal é visível somente em classes derivadas dentro do mesmo assembly; 
            // Toda e qualquer classe no C# é derivada de Object (classe base); 
            // O construtor da classe base sempre será herdado e executado primeiro nas classes derivadas; 

            ContaCorrente cc = new ContaCorrente();
            cc.Numero = 1;
            cc.Saldo = 1564.34m;
            cc.TaxaJuros = 1.5m;           
            cc.ImprimirSaldo();
            cc.OcultarMetodo();

        }
    }



}

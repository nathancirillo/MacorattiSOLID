using System;

namespace ModeloDominio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cliente anêmico
            ClienteAnemico();

            //Cliente Rico
            ClienteRico();

            Console.ReadLine();
        }

        private static void ClienteRico()
        {
            ClienteRico cr = new ClienteRico(1, "", "teste");
            Console.WriteLine($"Id: {cr.Id} - Nome: {cr.Name} - Endereço: {cr.Address}");
        }

        static void ClienteAnemico()
        {
            ClienteAnemico ca = new ClienteAnemico();
            ca.Id = -1;
            ca.Address = null;
            Console.WriteLine($"Id:{ca.Id} Nome: {ca.Name} Endereço: {ca.Address}");
        }
    }
}

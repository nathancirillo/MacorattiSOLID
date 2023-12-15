using System;
using System.Collections.Generic;
using System.Text;

namespace MacorattiOOP.Entities
{   
    public class Exemplo
    {
        public string Nome { get; set; }

        public Exemplo(string Nome)
        {
            this.Nome = Nome;

            Teste teste = new Teste(this);

            Console.WriteLine(teste.Nome);
        }
    }
}

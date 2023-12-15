using System;
using System.Collections.Generic;
using System.Text;

namespace MacorattiOOP.Entities
{
    public class Teste
    {
        public string Nome { get; set; }
        public Teste(Exemplo exemplo)
        {
            this.Nome = exemplo.Nome;
        }
    }
}

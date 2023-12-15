using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class Figura
    {
        public virtual void Desenhar()
        {
            Console.WriteLine($"Desenhando Figura Padrão...");
        }
    }
}

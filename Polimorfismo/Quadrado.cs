using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class Quadrado : Figura
    {
        public override void Desenhar()
        {
            Console.WriteLine($"Desenhando Quadrado.");
        }
    }
}

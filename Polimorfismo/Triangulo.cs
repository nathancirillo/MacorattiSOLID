using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class Triangulo : Figura
    {
        public override void Desenhar()
        {
            Console.WriteLine($"Desenhando Triângulo.");
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Polimorfismo
{
    class Circulo : Figura
    {
        public override void Desenhar()
        {
            Console.WriteLine($"Denhando Círculo.");
        }
    }
}

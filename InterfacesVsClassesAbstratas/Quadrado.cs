using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesVsClassesAbstratas
{
    class Quadrado : Forma
    {

        public Quadrado(string nome): base(nome)
        {
        }

        public override void Desenhar()
        {
            Console.WriteLine($"Desenhando o {Nome}");
            Duplicar();
        }

        public override void Identificar()
        {
            Console.WriteLine($"Eu sou o {Nome}");
        }
    }
}

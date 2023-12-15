using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesVsClassesAbstratas
{
    class Triangulo : IForma
    {
        public string Nome { get; set ; }

        public Triangulo(string nome)
        {
            Nome = nome; 
        }

        public void Desenhar()
        {
            Console.WriteLine($"Desenhando o {Nome}");
            Duplicar();
        }

        public void Duplicar()
        {
            Console.WriteLine($"Duplicando o {Nome}");
        }

        public void Identificar()
        {
            Console.WriteLine($"Eu sou o {Nome}");
        }
    }
}

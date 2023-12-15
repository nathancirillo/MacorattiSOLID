using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesVsClassesAbstratas
{
    abstract class Forma
    {
        protected string Nome { get; set; }

        public Forma(string nome) 
        {
            Nome = nome;
        }

        public abstract void Desenhar();
        public abstract void Identificar();

        protected void Duplicar()
        {
            Console.WriteLine($"Duplicando forma...");
        }

    }
}

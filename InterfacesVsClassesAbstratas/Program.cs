using System;

namespace InterfacesVsClassesAbstratas
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrado q = new Quadrado("Quadrado");
            q.Desenhar();
            q.Identificar();

            Triangulo t = new Triangulo("Triângulo");
            t.Desenhar();
            t.Identificar();
        }
    }
}

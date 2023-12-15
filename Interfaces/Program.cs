using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            GravarArquivo ga = new GravarArquivo();
            ga.Gravar();
            ga.GravarXml();
        }
    }
}

using System;

namespace InterfacesDesacoplamento
{
    class Program
    {
        static void Main(string[] args)
        {
            var registroConsole = new RegistroOcorrencia(new RegistroConsole());
            registroConsole.Registrar("registro no console");

            var registroArquivo = new RegistroOcorrencia(new RegistroArquivo(@"C:\OutputPrograms\teste.txt"));
            registroArquivo.Registrar("registro no arquivo");
        }
    }
}

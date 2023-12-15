using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDesacoplamento
{
    class RegistroConsole : IRegistro
    {
        public void Registrar(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}

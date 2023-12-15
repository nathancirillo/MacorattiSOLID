using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesDesacoplamento
{
    class RegistroOcorrencia
    {
        private readonly IRegistro _registro;

        public RegistroOcorrencia(IRegistro registro)
        {
            _registro = registro;
        }

        public void Registrar(string mensagem)
        {
            _registro.Registrar($"Mensagem: {mensagem} - Hora: {DateTime.Now}.");
        }
    }
}

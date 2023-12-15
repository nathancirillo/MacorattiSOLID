using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InterfacesDesacoplamento
{
    class RegistroArquivo : IRegistro
    {
        private readonly string _caminhoArquivo;

        public RegistroArquivo(string path)
        {
            _caminhoArquivo = path; 
        }

        public void Registrar(string mensagem)
        {
            Log(mensagem);
        }

        private void Log(string mensagem)
        {
            using (var streamWriter = new StreamWriter(_caminhoArquivo, true))
            {
                streamWriter.WriteLine(mensagem);
            }
        }
    }
}

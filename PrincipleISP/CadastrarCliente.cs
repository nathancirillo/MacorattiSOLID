using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipleISP
{
    class CadastrarCliente : IPersistencia, IEnviarEmail
    {
        public void EnviarEmail()
        {
            Console.WriteLine("Enviar Email");
        }

        public void SalvarDataBase()
        {
            Console.WriteLine("Salvar na base");
        }

        public void ValidarDados()
        {
            Console.WriteLine("Validar dados");
        }
    }
}

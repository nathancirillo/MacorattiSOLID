using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipioDIP
{
    class RecuperarSenhaSemDIP
    {
        private MySqlConnection _conexaoBanco;

        public RecuperarSenhaSemDIP()
        {
            //Veja que aqui há um forte acoplamento
            _conexaoBanco = new MySqlConnection();
        }
    }

    class MySqlConnection
    {
        public void Conectar()
        {
            Console.WriteLine("Conexão com o BD");
        }
    }

}

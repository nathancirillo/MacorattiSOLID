using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipioDIP
{
    class RecuperarSenhaComDIP
    {
        //Aqui a classe de alto nível está dependendo de uma abstração
        private IDataBaseConnection _conexaoMySql;

        public RecuperarSenhaComDIP(IDataBaseConnection conexaoMySql)
        {
            _conexaoMySql = conexaoMySql;
        }

    }


    class ConnectionMySql : IDataBaseConnection
    {
        public void Conectar()
        {
            Console.WriteLine("Conexão com o MySQL.");
        }
    }

    interface IDataBaseConnection
    {
        void Conectar(); 
    }


}

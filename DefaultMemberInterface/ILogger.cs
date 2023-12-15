using System;
using System.Collections.Generic;
using System.Text;

namespace DefaultMemberInterface
{
    interface ILogger
    {
        void Info(string mensagem);
        void Error(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}

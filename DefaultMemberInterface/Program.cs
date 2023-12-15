using System;

namespace DefaultMemberInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = new ConsoleLogger();
            logger.Error("teste");           
        }
    }
}

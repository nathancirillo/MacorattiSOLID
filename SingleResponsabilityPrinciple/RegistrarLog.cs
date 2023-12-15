using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SingleResponsabilityPrinciple
{
    class RegistrarLog : ILogger
    {
        public void Info(string message)
        {
            File.WriteAllText(@"C:\OutputPrograms\Log.txt", message);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloDominio.ValidationClass
{
    class DomainValidationOperationException : Exception
    {
        public DomainValidationOperationException(string error) : base(error)
        { 
        }

        public static void When(bool error, string message)
        {
            if (error)
                throw new DomainValidationOperationException(message);
        }

    }
}

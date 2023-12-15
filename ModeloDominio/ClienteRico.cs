using ModeloDominio.ValidationClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloDominio
{
    class ClienteRico
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string Address { get; private set; }


        public ClienteRico(int id, string name, string address) 
        {

            //Forma mais verbosa: 

            //if (id <= 0)
            //    throw new InvalidOperationException("Id não pode ser menor ou igual a zero!");

            //if (String.IsNullOrEmpty(name))
            //    throw new InvalidOperationException("O nome deve ser informado!");

            //if (String.IsNullOrEmpty(address))
            //    throw new InvalidOperationException("O endereço deve ser informado!");

            //Forma melhor: 
            DomainValidationOperationException.When(id <= 0, "Id não pode ser menor ou igual a zero!");
            DomainValidationOperationException.When(String.IsNullOrEmpty(name), "O nome deve ser informado!");
            DomainValidationOperationException.When(String.IsNullOrEmpty(address), "O endereço deve ser informado!");



            Id = id;
            Name = name;
            Address = address; 
        }
    }
}

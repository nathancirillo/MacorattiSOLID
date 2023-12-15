using System;
using System.Collections.Generic;
using System.Text;

namespace MacorattiOOP.Entities
{
    class Pessoa
    {
        //propriedade automática
        public string Nome { get;} //somente leitura      
        public string Genero { get; set; }
       
        //field
        private int idade;

        //propriedade
        public int Idade
        {
            get { return idade; }
            set { 
                    if(value >= 18)
                         idade = value;
                    else
                        Console.WriteLine("Idade inválida!");
                }
        }


        //construtor default
        public Pessoa(string nome)
        {
            this.Nome = nome; 
        }


        //construtor personalizado
        public Pessoa(string nome, int idade, string genero)
        {
            this.Nome = nome;
            this.Genero = genero;
            this.Idade = idade;            
        }
       

        public void Identificacao()         
        {
            Console.WriteLine($"Meu nome é: {Nome}, tenho {Idade} anos e sou do sexo {Genero}.");
        }
    }
}

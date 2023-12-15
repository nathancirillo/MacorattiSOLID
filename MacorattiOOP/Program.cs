using MacorattiOOP.Entities;
using System;

namespace MacorattiOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //Construtor sem parâmetro
            Pessoa pessoaUm = new Pessoa("Nathan");          
            pessoaUm.Idade = 33;
            pessoaUm.Genero = "Masculino";
            pessoaUm.Identificacao();

            //Construtor com parâmetro
            Pessoa pessoaDois = new Pessoa("Mariana", 17, "Feminino");
            pessoaDois.Identificacao();


            //Uso do this para passagem de instãncia para método
            Exemplo exemplo = new Exemplo("Instância");


        }
    }
}

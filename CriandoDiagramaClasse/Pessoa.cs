using System;

namespace CriandoDiagramaClasse
{
    public class Pessoa
    {
        private string dataNascimento;
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }

        public Pessoa(string nome, int idade, string sexo)
        {
            Nome = nome;
            Idade = idade;
            Sexo = sexo; 
        }

        public void IdentificarPessoa()
        {
            Console.WriteLine($"Nome: {Nome} - Idade: {Idade} - Sexo: {Sexo}.");
        }
    }
}

using MetodosExtensao.Utils;
using System;

namespace Utils
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Um método de extensão permite adicionar novas funcionalidades a um tipo existente, 
               sem ser necessário extende-lo. Ele poderá ser chamado como se fosse um método de instância. 
               O seu uso vai ao encontro do Princípio Aberto/Fechado (OCP) que diz que devemos ser capazes de 
               estender o comportamento de uma classe sem modificá-la. 
               O método de extensão deve ser static e no parâmetro o tipo deve ser precedido da palavra this.
            */

            string mensagem = "Esse é um Exemplo ONde somente a Primeira letra deve ser Maiúscula.";
            string novaMensagem = mensagem.PrimeiraLetraMaiuscula();
            Console.WriteLine(mensagem);
            Console.WriteLine(novaMensagem);
            Console.ReadLine();
        }
    }
    
}

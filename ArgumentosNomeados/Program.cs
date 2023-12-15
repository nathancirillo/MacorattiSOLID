using System;

namespace ArgumentosNomeados
{
    class Program
    {
        static void EnviaEmail(string destino, string assunto, string texto)
        {
            Console.WriteLine($"Destino: {destino}, Assunto: {assunto}, Texto: {texto}.");
        }

        static void Main(string[] args)
        {
            //Por default a passagem de parâmetros deve respeitar a ordem dos mesmos no método:
            EnviaEmail("nathan_cirillo@hotmail.com", "Oportunidade", "Deus fará você ser o melhor programador.");

            //Porém é possível nomear os parâmetros e passar em ordem diferente: 
            EnviaEmail(texto: "Esse é o novo texto", assunto: "Parãmetros Nomeados", destino: "vanfontes2010@hotmail.com");
        }
    }
}

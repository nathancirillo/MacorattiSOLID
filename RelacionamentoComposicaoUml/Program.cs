using System;
using System.Collections.Generic;

namespace RelacionamentoComposicaoUml
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Departamento : IDisposable
    {
        private Escola escola;
        private string nome;

        internal Departamento(Escola escola, string nome)
        {
            this.escola = escola;
            this.nome = nome; 
        }

        public void Dispose()
        {            
        }
    }

    public class Escola : IDisposable
    {

        public string Nome { get; set; }

        //Isso caracteriza a composição, ou seja, uma Escola contém um ou mais departamentos.
        private List<Departamento> departamentos = new List<Departamento>();

        public void AddDepartamento(string nome)
        {
            departamentos.Add(new Departamento(this,nome));
        }

        public void Dispose()
        {
            foreach (var departamento in departamentos)
            {
                departamento.Dispose();
            }
        }       
    }


}

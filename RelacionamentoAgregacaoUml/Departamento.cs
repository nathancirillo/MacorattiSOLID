using System;
using System.Collections.Generic;
using System.Text;

namespace RelacionamentoAgregacaoUml
{
    class Departamento : IDisposable
    {
        public string Nome { get; set; }

        //Essa linha representa a agregação com a classe Professor. 
        public List<Professor> Professores { get; set; }
        public void Dispose() { }
    }
}

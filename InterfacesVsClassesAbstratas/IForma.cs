using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesVsClassesAbstratas
{
    interface IForma
    {
        string Nome { get; set; }
        void Desenhar();
        void Identificar();
        void Duplicar();
    }
}

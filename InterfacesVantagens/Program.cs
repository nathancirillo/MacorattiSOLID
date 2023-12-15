using System;

namespace InterfacesVantagens
{
    class Program
    {
        static void Main(string[] args)
        {
            Gravacao gv = new Gravacao();
            gv.GravarJSON();
            gv.GravarXML();
            gv.GravarPadrao();

            IGravarArquivo ga = new Gravacao();
            ga.GravarJSON();
            ga.GravarXML();
            //não terei acesso a gravação padrão.
        }
    }

    interface IGravarArquivo
    {
        void GravarXML();
        void GravarJSON();
    }

    class ArquivoBase
    {
        public virtual void GravarPadrao()
        { 

        }
    }

    class Gravacao : ArquivoBase, IGravarArquivo
    {
        public override void GravarPadrao()
        {            
        }

        public void GravarXML()
        { 
        }

        public void GravarJSON()
        { 
        }
    }
}

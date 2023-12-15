using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipleISP
{
    class CadastrarProduto : IPersistencia
    {


        //Esse método não deveria fazer parte da classe. 
        //Viola princípio ISP, pois a interface obriga ele a ser implementado.
        //public void EnviarEmail()
        //{
        //    throw new NotImplementedException();
        //}

        public void SalvarDataBase()
        {
            Console.WriteLine("Salvar na base");
        }
        
        
        public void ValidarDados()
        {
            Console.WriteLine("Validar dados");
        }
    }
}

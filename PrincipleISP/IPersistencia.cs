using System;
using System.Collections.Generic;
using System.Text;

namespace PrincipleISP
{
    interface IPersistencia
    {
        
        void SalvarDataBase();
        void ValidarDados();


        //Será enviada para outra interface para que a classe de produto
        //não tenha acesso a esse método. Não violando assim o princípio
        //ISP. 
        //void EnviarEmail();

    }
}

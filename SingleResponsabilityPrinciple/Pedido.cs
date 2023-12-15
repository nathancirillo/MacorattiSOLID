using System;
using System.Collections.Generic;
using System.Text;

namespace SingleResponsabilityPrinciple
{
    class Pedido
    {
        public long Quantidade { get; set; }

        public DateTime Data { get; set; }


        private ILogger infoLogger;

        private EnviarEmail enviarEmail;


        public Pedido()
        {
            enviarEmail = new EnviarEmail();
            infoLogger = new RegistrarLog();
        }

        public void IncluirPedido()
        {
            try
            {
                //lógica para incluir pedido
                infoLogger.Info("Sucesso: Pedido incluído!");

                //enviando o e-mail
                enviarEmail.Body = "Body";
                enviarEmail.From = "From";
                enviarEmail.To = "To";
                enviarEmail.Subject = "Subject";
                enviarEmail.Enviar();
             
            }
            catch (Exception ex)
            {
                infoLogger.Info("Erro: inclusão de pedido. " + ex.ToString());
            }
        }

        public void DeletarPedido()
        {
            try
            {
                //lógica para deletar o pedido
            }
            catch (Exception ex)
            {
                infoLogger.Info("Erro: deletar o pedido. " + ex.Message);
            }
        }
    }
}

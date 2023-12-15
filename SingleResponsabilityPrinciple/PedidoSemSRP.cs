using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mail;
using System.Text;

namespace SingleResponsabilityPrinciple
{
    class PedidoSemSRP
    {
        public long Quantidade { get; set; }
        public DateTime Date { get; set; }

        public void IncluirPedido()
        {
            try
            {
                //lógica para incluir o pedido

                MailMessage mailMessage = new MailMessage("EmailFrom", "EmailTo", "EmailSubject", "EmailBody");

                this.EnviaEmailPedido(mailMessage);
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"C:\OutputPrograms\ErrorLog.txt",ex.ToString());
            }
        }


        public void DeletaPedido()
        {
            try
            {
                //lógica para deletar pedido                
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"C:\OutputPrograms\ErrorLog.txt", ex.ToString());
            }
        }

        private void EnviaEmailPedido(MailMessage mailMessage)
        {
            try
            {
                //lógica para enviar o pedido
            }
            catch (Exception ex)
            {
                File.WriteAllText(@"C:\OutputPrograms\ErrorLog.txt", ex.ToString());
            }            
        }
    }
}

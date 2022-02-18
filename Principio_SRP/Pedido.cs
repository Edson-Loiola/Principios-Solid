using System;
using System.Collections.Generic;
using System.Text;

namespace Principio_SRP
{
    //SRP - Príncipio da responsabilidade única.
    public class Pedido
    {
        public long Quantidade { get; set; }
        public DateTime Data { get; set; }
        private ILoger infoLogger;
        private EnviarEmail enviaEmail;

        public Pedido()
        {
            enviaEmail = new EnviarEmail();
            infoLogger   = new RegistraaLog();
        }

        public void IncluirPedido()
        {
            try
            {
                infoLogger.Info("Incluindo um pedido.");

                enviaEmail.EmailFrom = "ed@gmail.com";
                enviaEmail.EmailTo = "milla@gmail.com";
                enviaEmail.EmailSubject = "SRP";
                enviaEmail.EmailBody = "Olá";
                enviaEmail.Enviar();

            }
            catch (Exception ex)
            {
                infoLogger.Info("erro ao enviar email: " + ex.Message);
            }

        }

        public void DeletarPedido()
        {
            try
            {
                infoLogger.Info("Pedido deletado em " + DateTime.Now);
            }
            catch (Exception ex)
            {

                infoLogger.Info("erro ao deletar pedido:  " + ex.Message);
            }
        }
    }
}

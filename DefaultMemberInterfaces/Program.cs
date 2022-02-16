using System;

namespace DefaultMemberInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {

            //Para usar aquele metodo criado dentro da interface
            ILogger logger = new ConsoleLogger();
            logger.Erro("erro");
          
        }
    }
}

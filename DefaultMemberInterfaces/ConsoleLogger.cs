using System;
using System.Collections.Generic;
using System.Text;

namespace DefaultMemberInterfaces
{
    class ConsoleLogger : ILogger
    {
        public void Info(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}

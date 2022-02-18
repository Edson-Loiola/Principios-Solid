using System;
using System.Collections.Generic;
using System.Text;

namespace Principio_SRP
{
    //SRP - Príncipio da responsabilidade única.

    class RegistraaLog : ILoger
    {
        public void Info(string info)
        {
            Console.WriteLine(info);
        }
    }
}

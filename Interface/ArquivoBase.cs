using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class ArquivoBase
    {
        public virtual void Nome()// Metodo virtual pode ser sobrescrito ou não
        {
            Console.WriteLine("Definir nome do arquivo!");
        }
    }
}

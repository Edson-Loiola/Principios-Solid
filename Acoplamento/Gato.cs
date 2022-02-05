using System;
using System.Collections.Generic;
using System.Text;

namespace Acoplamento_x_Heranca
{
    public class Gato
    {
        Animal gato = new Animal();
        ComportamentoAndar andar = new ComportamentoAndar();

        public void Miau()
        {
            Console.WriteLine("miau...");
        }


    }
}

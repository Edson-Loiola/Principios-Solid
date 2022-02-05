using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    public class Demo : ITeste, ITestando //Posso implementar mais de uma interface separando por ","
    {
        public void Desenhar() //metodo da interface ITeste
        {
            throw new NotImplementedException();
        }

        public void pintar() //metodo da interface ITestando
        {
            throw new NotImplementedException();
        }
    }
}

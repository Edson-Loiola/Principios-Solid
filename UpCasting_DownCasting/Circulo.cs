using System;
using System.Collections.Generic;
using System.Text;

namespace UpCasting_DownCasting
{
    public class Circulo : Forma
    {
        public override void Desenhar()
        {
            Console.WriteLine("Desenhar Circulo");
        }

        public void PintarCirculo()
        {
            Console.WriteLine("Pintando o circulo");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_HerancaPolimorfismo.Exercicio_2
{
    class Ave : Animal
    {

        public Ave(string tipo ) : base(tipo)
        {

        }
        public override void Mover()
        {
            Console.WriteLine("Voando 100 metros");
        }
    }
}

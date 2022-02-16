using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_HerancaPolimorfismo.Exercicio_2
{
    class Peixe : Animal
    {
        public Peixe(string tipo ) : base(tipo)
        {

        }
        public override void Mover()
        {
            Console.WriteLine("Nadando 100 metros");
        }
    }
}

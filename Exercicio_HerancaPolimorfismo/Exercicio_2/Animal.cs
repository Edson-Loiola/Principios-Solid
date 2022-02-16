using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_HerancaPolimorfismo.Exercicio_2
{
   abstract class Animal
    {
        public string Tipo { get; set; }

        public Animal(string tipo)
        {
            Tipo = tipo;
        }

        public abstract void Mover(); //as classes de cada tipo que vão criar a implementação
        
    }
}

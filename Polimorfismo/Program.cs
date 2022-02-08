using System;
using System.Collections.Generic;

namespace Polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Polimorfismo é o princípio pela qual duas ou mais classes derivadas de uma mesma superclasse podem invocar métodos que tem a mesma assinatura mas comportamentos distintos,
            //que são especializados para cada classe derivada, usando para tanto uma referência a um objeto do tipo da superclasse


            var figurass = new List<Figura>
            {
                    new Triangulo(),
                    new Circulo()
            };


            foreach (var figura in figurass)
            {
                figura.Desenhar();
            }

            Console.WriteLine();
        }



    }
}

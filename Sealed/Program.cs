using System;

namespace Sealed
{
    class Program
    {

        public sealed class CalculaSoma  //Classe "sealed" não pode ser herdada desta forma restringe a herança
        {
            public int Somar (int a, int b)
            {
                return a + b;
            }
        }


 

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

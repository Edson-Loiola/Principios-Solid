using System;

namespace UpCasting_DownCasting
{
    class Program
    {
        static void Main(string[] args)
        {
          
            Circulo circulo = new Circulo();
            Forma f = circulo;   //UpCasting
            Console.WriteLine(f == circulo);//true
            f.Desenhar();

        }
    }
}

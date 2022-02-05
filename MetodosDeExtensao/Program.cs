using System;

namespace MetodosDeExtensao
{
    class Program
    {
        static void Main(string[] args)
        {

            var texto1 = "curso";
            var texto2 = "edson";


            //usando metodo de extensao
            texto1 = texto1.CaixaAltaPrimeiraLetra(); //É como se fosse um método do proprio Visual Studio!
            texto2 = texto2.CaixaAltaPrimeiraLetra();

            Console.WriteLine(texto1);
            Console.WriteLine(texto2);
        }
    }
}

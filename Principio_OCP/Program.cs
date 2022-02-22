using System;

namespace Principio_OCP
{
    public class Program
    {
        static void Main(string[] args)
        {
            //OCP - Príncipio aberto fechado. Fechado para mudanças e aberto para implementação.
            //Você deve ser capaz de estender um comportamento de uma classe sem a necessidade de alterá-la.

            Produto produto1 = new Produto(
                    1,
                    "Caneta",
                    "Caneta Esferográfica azul",
                    2.00M,
                    3.40M,
                    100,
                    true
                );

            // Console.WriteLine($"{produto1.Nome} - Lucro = {produto1.MargemLucro()}"); //não funcionou o metodo de extensão
            
        }
    }
}

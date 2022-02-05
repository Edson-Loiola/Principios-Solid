using MetodosStaticos;
using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {


            //Esse meotodos foram definidos como staticos, então posso chamalos a partir da classe, sem precisar instancia-la. 
            //Se não fossem staticos, para acessa-los eu precisaria instar a classe. Ex: Calculadora calc = new Calculadora() e acessa o metod a partir de calc.somar

            Console.WriteLine("Soma = " + Calculadora.Somar(5, 5));
            Console.WriteLine("Subtração = " + Calculadora.Subtrair(10, 5));
        }
    }
}

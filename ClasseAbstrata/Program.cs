using System;

namespace ClasseAbstrata
{
    class Program
    {
        static void Main(string[] args)
        {


            //Classe abstrata é um tipo especial de classe que não pode ser instanciada, ou seja, voce não pode criar um objeto a partir dessa classe.
            //ela pode conter metodos abstratos. Esse metodo possui somente a definição de assinatura, a implementação dee ser na classe derivada


            Quadrado q = new Quadrado();
            Console.WriteLine(q.Descricao());

            Console.WriteLine("Informe a cor da figura:");
            q.Cor = Console.ReadLine();


            Console.WriteLine("Informe o lado do quadrado:");
            q.Lado = Convert.ToInt32(Console.ReadLine());

            q.CalcularArea();
            q.CalcularPerimetro();

            Console.WriteLine($"Área quadrado: {q.Area} m2");
            Console.WriteLine($"O perimetro quadrado é: {q.Perimetro} m2");
            Console.WriteLine($"Cor do quadrado: {q.Cor}");






        }
    }
}

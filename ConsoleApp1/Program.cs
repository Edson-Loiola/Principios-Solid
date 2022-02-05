using System;

namespace ConsoleApp1 //o namespace é usado para organizar o código. É tbm um conainer de classes
{
    class Program
    {

        //metodo statico: não preciso declarar uma instancia para utilizá-lo
        //motodo void: não tem retorno

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Pessoa pessoa1 = new Pessoa(); //no C# todas as classes herdam de Object
            pessoa1.nome = "Edson";
            pessoa1.idade = 29;
            pessoa1.genero = "Masculino";

            pessoa1.Identificar();

            Pessoa pessoa2 = new Pessoa("Milla", 28, "Feminino");
            pessoa2.Identificar();





            Console.WriteLine("//---------------------------------------------------------------------------------------------"); 





            Encapsulamento ec = new Encapsulamento("Eds");
            //ec.Nome = "Monteiro" //O erro é pq a prop Nome é somente leitura conforme encapsulamento.
            ec.Genero = "Masculino";
            ec.Idade = 17;

            Console.WriteLine(ec.Nome);
            Console.WriteLine(ec.Idade);



        }
    }


    //posso criar outra classe dentro do namespace
    class Teste
    {
        //código
    }

}





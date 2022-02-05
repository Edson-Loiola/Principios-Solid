using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Encapsulamento
    {
    

        private string nome;
        private string genero;
        private int idade;

        //ctor
        public Encapsulamento(string nome)
        {
            this.Nome = nome;
        }


        //Encapsulento das propriedades
        public string Nome { get; } //nome pode ser retornado mas não poderá ser alterado pois não tem set


        public string Genero
        {
            set
            {
                genero = value;
                Console.WriteLine(genero);
            }
        }


        public int Idade
        {
            set
            {
                if (value < 18)
                {
                    Console.WriteLine("Idade tem que ser maior que 18");
                }
                else
                {
                    this.idade = value;

                }
            }
            get { return idade; }
        }

    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Pessoa
    {
        public string nome { get; set; }
        public int idade { get; set; }
        public string genero { get; set; }


        public Pessoa()
        {
            //cosntrutor padrão. Com ele não preciso passar os parametros quando instanciar a classe
        }

        //nesse construtor (pode ter mais de um ctor - sobrecarga), no momento de instanciar o objeto preciso passar os valores dos atributos
        public Pessoa(string nome, int idade, string genero)
        {
            this.nome = nome;
            this.idade = idade;
            this.genero = genero;
        }


        //construtor serve para inicializar os valores dos campos da clase
        //public Pessoa()
        //{
        //    nome = "Edson";
        //    idade = 29;
        //    genero = "Masculino";
        //}



        public void Identificar()
        {
            Console.WriteLine($"Olá, sou o {nome}, tenho {idade} e sou do sexo {genero}.");
        }
    }
}

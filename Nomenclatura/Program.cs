using System;

namespace Nomenclatura
{
    class Program
    {
        static void Main(string[] args)
        {

            //Identificadores precisam começar com sublinados " _"
            //Não pode ser começado com números, caracteres especiais, palavras reservadas
            //C# é case sensitive (diferencia palavras de maisuculas e minusculas)
            //Não pode usar palavras reservadas


            //PascalCasing: Para(Metodos, construtores, propriedade, tipos e namespaces)
            //Coloca-se em maiusculo o primeiro caractere de cada palavra. Ex: NomeClinete, CalculoImposto, PessoFisica

            //CamelCasing: Coloca-se em maiusculo o primeiro caractere das segundas palavra. Ex: nomeClineteAtivo, calculoImposto, pessoFisica


        }       

    }

    class CalculaDesconto //PascalCasing
    {
        double taxaEncargos = 1.99; //camelCasing
        public int ValorImposto { get; set; } //PascalCasing

        public double CalculoEncargos(double valorTotal)  //PascalCasing o nome do metodo
        {
            return valorTotal + taxaEncargos; //camelCasing
        }

    }
}

using System;

namespace Metodos
{
    class Program
    {

        //Definição de assinatura do método:

        //*static: não precisa ser instanciado ou que não depede de um objeto

        //*public: é o nível de acesso do metodo;

        //*se for void não vai ter retorno, se for int/string/list ele precisar ter retorno(return);

        //*Pode ter parametros ou não;

        static public int Somar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }




        //Sobrecarga do metodo ou Overloadin: Método com mesmo NOME mas com assinatura diferente
        static public double Somar(double numero1, double numero2, double numero3)
        {
            return numero1 + numero2 + numero3;
        }

        static public int Somar(params int[] numeros)
        {
            var resultado = 0;

            foreach (var num in numeros)
            {
                resultado = resultado + num;  //resultadp  +=num;
            }
            return resultado;
        }




        static void Main(string[] args)
        {

            //Método com o mesmo nome assinaturas diferentes
            var resultado1 = Somar(10, 10);
            var resultado2 = Program.Somar(10, 20, 30);
            var resultado3 = Somar(new int[] { 1, 2, 3, 4, 5, 6, 7 }); // ou
            var resultado4 = Somar(1, 2, 3, 4, 5, 6, 7);
        }
    }
}

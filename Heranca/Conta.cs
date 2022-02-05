using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }

        public Conta()
        {
            Console.WriteLine("Construtor da Classe Conta");
        }



        //a palavra virtual significa que esse metodo vai ser sobrescrito na classe que está recebendo herança
        public virtual void GetSaldo()
        {
            Console.WriteLine($"Saldo: {Saldo}");
        }
    }
}

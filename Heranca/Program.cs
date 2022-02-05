using System;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaPoupanca cp = new ContaPoupanca();

            cp.Numero = 01020;  //propriedade herdada da classe base Conta
            cp.Saldo = 500.45;  //propriedade herdada da classe base Conta
            cp.GetSaldo();

            //Obs: Membros privados não são herdados por heraça para outra classe


            Console.WriteLine("-------------------------------------------------------------------------------------------");

            var carro = new Carro("13123-ADFFVF"); // ao iniciar será chamado o construtor de Veiculo e de carro, pois o construtor da classe base sempre será chamado primeiro e depois o da herança
            carro.Teste();

        }
    }
}

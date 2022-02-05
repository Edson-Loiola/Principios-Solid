using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    class ContaPoupanca : Conta
    {
        public int JurosMensais { get; set; }

        //na hernaça pode sobrescrever um metodo herdado da classe base. Para isso na classe base insira a palavra chave virtual e na classe que herdou insira a palavra override
        public override void GetSaldo()
        {
            Console.WriteLine($"Saldo Pp: {Saldo}");
        }

    }
}

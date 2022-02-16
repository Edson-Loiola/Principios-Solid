using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio_HerancaPolimorfismo
{
    public class Transacao : ConectarBancoDados, ITransacao, IRelatorio
    {
        public void Executar()
        {
            Console.WriteLine("Processando Transação...");
        }

        public void Imprimir()
        {
            Console.WriteLine("Imprimindo..");
        }
    }
}

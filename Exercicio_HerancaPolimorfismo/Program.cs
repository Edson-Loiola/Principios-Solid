using Exercicio_HerancaPolimorfismo.Exercicio_2;
using System;

namespace Exercicio_HerancaPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ex 1
            var trs = new Transacao();
            trs.Conectar();
            trs.Executar();
            trs.Imprimir();


            //Ex 2
            Animal animal1 = new Ave("Pato");
            animal1.Mover();

            Animal animal2 = new Peixe("Tubaraão");
            animal2.Mover();

        }
    }
}

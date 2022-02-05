using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    class Carro : Veiculo
    {
        public Carro(string numeroChassis) : base(numeroChassis)
        {
            //inicializar outros campos da classe Carro
            Console.WriteLine($"Inicializando Carro: {numeroChassis}");
        }

        public Carro()
        {
            Console.WriteLine($"Iniciando classe Carro!");
        }

        public override void Teste()
        {
            base.Teste();
            Console.WriteLine("sobresvrevi teste");
        }
    }
}

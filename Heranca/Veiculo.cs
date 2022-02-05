using System;
using System.Collections.Generic;
using System.Text;

namespace Heranca
{
    class Veiculo
    {
        private string numeroChassis;
        public Veiculo(string _numeroChassis)
        {
            numeroChassis = _numeroChassis;
            Console.WriteLine($"Inicializando Veiculo: {_numeroChassis}");
        }

        public Veiculo()
        {
            Console.WriteLine("Inicializando Veiculo");
        }

        public virtual void Teste()
        {
            Console.WriteLine("acesso teste");
        }
    }
}

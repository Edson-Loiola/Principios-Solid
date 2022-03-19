using System;
using System.Collections.Generic;
using System.Text;

namespace Principio_DIP.FracoAcoplamento
{
    class MySqlConnection : IDataBaseConnection
    {
        public void Conectar()
        {
            Console.WriteLine("Conexão com MySQL");
        }
    }
}

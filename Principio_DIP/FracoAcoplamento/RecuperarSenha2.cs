using MySql.Data.MySqlClient;
using Principio_DIP.FracoAcoplamento;
using System;
using System.Collections.Generic;
using System.Text;

namespace Principio_DIP.ForteAcoplamento
{
    public class RecuperarSenha2
    {
        //Aqui vamos usar o padrão de projeto da 'injeção da dependencia' para obter a 'inversão da depência'.
        //Com isso estamos favorecendo a reutilização de código.

        private IDataBaseConnection conexBanco;
        
        public RecuperarSenha2(IDataBaseConnection _conexao)
        {
            conexBanco = _conexao;            
        }

    }
}

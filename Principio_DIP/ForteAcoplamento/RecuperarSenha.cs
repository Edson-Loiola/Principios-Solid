using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace Principio_DIP.ForteAcoplamento
{

    //Forte acoplamento que viola o principio da inversão da dependencia
    public class RecuperarSenha
    {
        private MySqlConnection conexBanco;

        public RecuperarSenha()
        {
            conexBanco = new MySqlConnection();
            
        }
    }
}

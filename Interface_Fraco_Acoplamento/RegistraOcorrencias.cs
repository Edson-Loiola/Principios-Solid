using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_Fraco_Acoplamento
{
    public class RegistraOcorrencias
    {
        private readonly IRegistgro _registro;

        public RegistraOcorrencias(IRegistgro registro) //injeção de dependencia do IRegistro no construtor da classe
        {
            _registro = registro;
        }

        public void Registrar(string mensagem)
        {
            _registro.RegistraInfo($"{mensagem} : {DateTime.Now}"); //o motodo está na interface e não na classe
        }

    }
}

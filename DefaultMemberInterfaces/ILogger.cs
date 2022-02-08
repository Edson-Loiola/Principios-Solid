using System;
using System.Collections.Generic;
using System.Text;

namespace DefaultMemberInterfaces
{
    interface ILogger
    {
        void Info(string mensagem);


        //implementação na interface. Esse método não terá obrigatoriedade de ter quer implementado em outra classes, o que evitar quebrar o código
        void Erro(string mensagem)
        {
            Console.WriteLine(mensagem);
        }
    }
}

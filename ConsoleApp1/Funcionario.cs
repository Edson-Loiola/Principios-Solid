using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Funcionario
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Funcionario(string Nome, string Email)
        {
            this.Nome = Nome;
            this.Email = Email;

            //Use this para qualificar as propriedades Nome e Email evitando confusao com os nomes dos param usados no construtor
        }
    }
}

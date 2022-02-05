using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloDominio
{
    class ClienteRico
    {
        public int Id { get; private set; } // private set - meu id não pede ser modificado por alguem
        public string Nome { get; private set; }
        public string Endereco { get; private set; }

        public ClienteRico(int id, string nome, string endereco)
        {
            //- Uma formde de fazer validação
            //if (id < 0)
            //    throw new InvalidOperationException("Id inválido");

            //if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(endereco))
            //    throw new InvalidOperationException();


            //- A mesma vaidação acima, porém mais performatico, criada separada em uma classe chamada DomainExceptionValidation
            DomainExceptionValidation.When(id < 0, "Id inválido!");
            DomainExceptionValidation.When(string.IsNullOrEmpty(nome), "O nome deve ser informado!");
            DomainExceptionValidation.When(string.IsNullOrEmpty(endereco), "O endereço deve ser informado!");

            Id = id;
            Nome = nome;
            Endereco = endereco;

        }
    }
}

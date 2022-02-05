using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloDominio
{
    class DomainExceptionValidation : Exception 
    {
        public DomainExceptionValidation(string error) : base(error)
        {

        }

        //metodo statico que verifica se tem erro, se tiver ele passa a msg de erro
        public static void When(bool hasError, string error)
        {
            if (hasError)
            {
                throw new DomainExceptionValidation(error);
            }
        }

    }
}

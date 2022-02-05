using System;
using System.Collections.Generic;
using System.Text;

namespace MetodosDeExtensao
{
    public static class MetodosExtensao
    {

        //Métodos de etensão precisao ter a classe e os metodos staticos
        public static string CaixaAltaPrimeiraLetra( this string palavra )
        {
            if (palavra.Length > 0 )
            {
                char[] letras = palavra.ToCharArray();
                letras[0] = char.ToUpper(letras[0]);
                return new string(letras);
            }
            return palavra;
        }
    }
}

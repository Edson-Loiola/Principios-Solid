using System;
using System.Collections.Generic;
using System.Text;

namespace Interface
{
    class GravarXML : ArquivoBase, IGravar  //Posso herdar outra classes e a interface. As classes devem ser passadas primeiras.
    {
        public void GravarArquivo()
        {
            throw new NotImplementedException();
        }

        public virtual void Nome()// Metodo virtual pode ser sobrescrito ou não
        {
            Console.WriteLine("Definir nome em GravarXML!");
        }
    }
}

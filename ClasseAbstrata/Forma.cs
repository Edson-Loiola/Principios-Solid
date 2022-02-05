using System;
using System.Collections.Generic;
using System.Text;

namespace ClasseAbstrata
{
   public abstract class Forma  //Classe abstrata.
    {

        public string Cor { get; set; }
        public double Area { get; set; }
        public double Perimetro { get; set; }

        //metodos abstratos
        public abstract void CalcularArea();
        public abstract void CalcularPerimetro();
        public string Descricao()
        {
            return "Sou a classe abstrata Forma.";
        }




    }
}

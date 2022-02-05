using System;

namespace Assembly1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Aula sobre modificadores de acesso
    //      Classe3 c3 = new Classe3();  //essa classe está com o modificador de acesso internal. não será possivel acessar.
    //      c3.nome = "";


            Classe2 c2 = new Classe2(); // A classe está com modificador de acesso public.
   //       c2.nome = ""; // a propriedade está como private, então ninguem tem acesso
            c2.sobrenome = ""; //a propriedade está como internal, então apenas classes dentro do assembly1 terá acesso
        }
    }
}




//Modificadores de acesso - Usado para definir o nível de acesso / a visibilidade para classes, campos, métodos e propriedades
//São eles:

// PUBLIC - Não existe restrição de acesso
// PRIVATE - Acesso limitado a membros da mesma classe. (padrão) 
// PROTECTED - Acesso limitado a membros da mesma classe e das classes que herdeiras
// INTERAL - Acesso limitado a classes definidas dentro do assembly do projetoa tual
// PROTECTED INTERNAL - acesso limitado ao assembly e ao tipos derivados da classe que o contém
// PRIVATE PROTECTED - O acesso é limitado a classe que o contem ou a tipos derivados da classe que o contém no assembly atual.

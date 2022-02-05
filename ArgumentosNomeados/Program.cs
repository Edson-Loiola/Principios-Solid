using System;

namespace ArgumentosNomeados
{
    class Program
    {

        static void Enviar(string destino, string titulo, string assunto)
        {
            //Console.WriteLine($"{destino} - {titulo} - {assunto}");
        }


        static void Main(string[] args)
        {
            //Argumentos nomeados: posso passar os parametros diferente da ordem em que foram criados. {param: tipo}
            //*Não funcionou quando imprimiu*
            Enviar(destino: "ed@gmail.com", titulo: "Urgente", assunto: "Teste");

            Enviar(assunto: "Teste", titulo: "Urgente", destino: "ed@gmail.com" );

            Enviar(titulo: "Urgente", assunto: "Teste", destino: "ed@gmail.com");
        }
    }
}

using System;

namespace ModeloDominio
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Modelo de dominio anémico - Quem for usar terá total dominio para modificar essa classe
            ClienteAnemico clienteAnemico = new ClienteAnemico();
           //var a = clienteAnemico.Id = -1;
           //var b = clienteAnemico.Nome = "dddfhehee";
           //var c = clienteAnemico.Endereco = null;

           // Console.WriteLine($"{a} - {b} - {c}");


            ////Modelo de dominio rico - Contém restrições e validações
            ClienteRico clienteRico = new ClienteRico(1, "", null); 
            Console.WriteLine($"{clienteRico.Id} - {clienteRico.Nome} - {clienteRico.Endereco}");

        }
    }
}

using System;

namespace Interface_Fraco_Acoplamento
{
    //ESSA CLASSE TEM APENAS UMA RESPONSABILIDADE DE GRAVAR O LOG NO CONSOLE
    public class RegistraNoConsole : IRegistgro
    {
        public void RegistraInfo(string messagem)
        {
            Console.WriteLine($"info : {messagem}");
        }
    }
}

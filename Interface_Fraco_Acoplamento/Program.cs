using System;

namespace Interface_Fraco_Acoplamento
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            var registrarOcorrenciasConsile = new RegistraOcorrencias(new RegistraNoConsole());

            registrarOcorrenciasConsile.Registrar("registro console");

            var registraOcorrenciaArquivo = new RegistraOcorrencias(new ImplementarNoArquivo(@"C:\Users\edson\Desktop\CursosEdson\SOLID\teste.txt"));
            registraOcorrenciaArquivo.Registrar("regsitro no arquivo");
        }
    }
}

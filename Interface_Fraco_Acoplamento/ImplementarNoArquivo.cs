using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Interface_Fraco_Acoplamento
{
    //ESSA CLASSE TEM APENAS UMA RESPONSABILIDADE DE GRAVAR O LOG NO ARQUIVO
    public class ImplementarNoArquivo : IRegistgro
    {
        private readonly string _caminhoArquivo;

        public ImplementarNoArquivo(string path)
        {
            _caminhoArquivo = path;
        }

        public void RegistraInfo(string messagem)
        {
            try
            {
                Log(messagem);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);               
            }
            
        }

        private void Log (string mensagem)
        {
            using (var streamWriter = new StreamWriter(_caminhoArquivo, true))
            {
                streamWriter.WriteLine(mensagem);
            }
        }
    }
}

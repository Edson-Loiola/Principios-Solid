using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uma interface é um tipo de classe que contém apenas as assinaturas de metodos, propriedades, eventos e indexadores,
            //todos os membros de uma interface são públicos e abstratos.

            //Uma interface funciona como um contrato entre si e qualquer classe que a implementa
            //Uma classe que herda uma interface é obrigada a implementar todos os seus membros

            //-Ela não contem membros privados
            //-Não contém implementação
            //-Os membros são todos publicos e abstratos
            //-Não pode ser instaciada
            //-Não contém construtor

            //Um dos pilares da POO diz que devemos programar para uma interface e não para uma implementação (Erich     Gamma).
            // As 5 vantagens de usar interfaces:
            // 1ª: Contrato que ajuda na organizção do código;
            // 2ª: Permite criar sistemas fracamente acoplados e mais flexíveis.
            // 3ª: Deixa o códifo mais flexível permitindo trocar a implementação de um compononente em tempo de execução
            // 4ª: Incluir novos recursos ou reimplementar recursos já existentes de mudanças nas regras  de negocios não irá qubrar o sistema já existente
            // 5ª: O códifo gerado é mais limpo e mais fácil de manter e entender pois existem uma separação de responsabilidades entre os componentes. 



            //--------------------------------------------------------------------------------------------

            GravarXML gravar = new GravarXML();
            gravar.GravarArquivo();
            gravar.Nome();

            


        }
    }
}

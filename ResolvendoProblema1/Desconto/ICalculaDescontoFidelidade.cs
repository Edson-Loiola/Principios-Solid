using System;
using System.Collections.Generic;
using System.Text;

namespace ResolvendoProblema1.Desconto
{
    public interface ICalculaDescontoFidelidade
    {
        decimal AplicarDescontoFidelidade(decimal preco, int tempoDeContaEmAnos);
    }
}

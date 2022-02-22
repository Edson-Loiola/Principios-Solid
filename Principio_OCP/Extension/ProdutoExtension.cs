﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Principio_OCP.Extension
{
    public static class ProdutoExtension
    {
        //Método de extensão para calcular margem de lucro
        public static double MargemLucro( this Produto produto)
        {
            try
            {
                var lucroLiquido = produto.Venda - produto.Custo;
                var margemLucro = (lucroLiquido / produto.Venda) * 100;

                return Convert.ToDouble(margemLucro);

            }
            catch (Exception)
            {
                throw new InvalidOperationException("Erro ao calcular a margem de lucro");
            }
        }
    }
}

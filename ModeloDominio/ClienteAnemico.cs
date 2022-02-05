using System;
using System.Collections.Generic;
using System.Text;

namespace ModeloDominio
{
    //Modelo de dominio anémico - Sem logica sem regras. Quem for usar terá total dominio para modificar essa classe
    public class ClienteAnemico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
                
    }
}

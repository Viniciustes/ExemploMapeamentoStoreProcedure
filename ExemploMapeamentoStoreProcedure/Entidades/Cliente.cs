using System;
using System.ComponentModel.DataAnnotations;

namespace ExemploMapeamentoStoreProcedure.Entidades
{
    public class Cliente
    {
        public Cliente()
        {
            IdCliente = Guid.NewGuid();
        }

        [Key]
        public Guid IdCliente { get; private set; }
        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public string CPF { get; set; }
    }
}
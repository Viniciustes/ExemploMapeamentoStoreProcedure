using ExemploMapeamentoStoreProcedure.Data;
using ExemploMapeamentoStoreProcedure.Entidades;
using System;

namespace ExemploMapeamentoStoreProcedure
{
    class Program
    {
        static void Main(string[] args)
        {
            using (BdContexto bd = new BdContexto())
            {
                var cliente = new Cliente()
                {
                    Nome = "Nome do Cliente",
                    DataNascimento = DateTime.Now,
                    CPF = "999.999.999-11"
                };

                bd.Clientes.Add(cliente);
                bd.SaveChanges();
            }
        }
    }
}

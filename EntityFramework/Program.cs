using System;

namespace EntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var baseDeDados = new MinhaDbContext())
            {
                var vendedor = new Vendedor();
                var cliente = new Cliente();

                baseDeDados.Clientes.Add(new Cliente { Nome = "Luis", Endereco = "Rua do Cajú" });
                baseDeDados.Clientes.Add(new Cliente { Nome = "Lorena", Endereco = "Rua do Cajú" });

                baseDeDados.Vendedores.Add(new Vendedor { Nome = "Henrique", MetadeVenda = 15 });
                baseDeDados.Vendedores.Add(new Vendedor { Nome = "Eduardo", MetadeVenda = 28 });

                baseDeDados.SaveChanges();
            }
        }
    }
}

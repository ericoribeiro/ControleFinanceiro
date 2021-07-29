using ControleFinanceiro.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ControleFinanceiro.Infra.Data.EF
{
    public class EFContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Despesa> Despesas { get; set; }
        public DbSet<Receita> Receitas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            if (!builder.IsConfigured)
            {
                builder.UseSqlServer(@"");
            }
        }
    }
}

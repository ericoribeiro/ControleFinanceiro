using ControleFinanceiro.Domain.Contracts.Repositories;
using ControleFinanceiro.Domain.Entities;
using ControleFinanceiro.Infra.Data.EF;
using ControleFinanceiro.Infra.Data.Repositories;

namespace ControleFinanceiro.Infra.Repositories
{
    public class RepositorioUsuario : RepositorioBase<Usuario>, IRepositorioUsuario
    {
        private EFContext _context { get; set; }

        public RepositorioUsuario(EFContext context) : base(context)
        {
            _context = context;
        }
    }
}

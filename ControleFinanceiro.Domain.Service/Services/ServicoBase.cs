using ControleFinanceiro.Domain.Contracts.Repositories;
using ControleFinanceiro.Domain.Contracts.Services;
using ControleFinanceiro.Infra.Data.EF;

namespace ControleFinanceiro.Domain.Service.Services
{
    public class ServicoBase<TEntity> : IServicoBase<TEntity> where TEntity : class
    {
        private readonly IRepositorioBase<TEntity> _repositorioBase;
        private readonly EFContext _context;

        public ServicoBase(IRepositorioBase<TEntity> repositorioBase, EFContext context)
        {
            _repositorioBase = repositorioBase;
            _context = context;
        }

        public virtual TEntity Alterar(TEntity entity)
        {
            entity = _repositorioBase.Alterar(entity);
            Commit();
            return entity;
        }

        public virtual void Excluir(TEntity entity)
        {
            _repositorioBase.Excluir(entity);
            Commit();
        }

        public virtual TEntity Incluir(TEntity entity)
        {
            entity = _repositorioBase.Incluir(entity);
            Commit();
            return entity;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
    }
}

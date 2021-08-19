using ControleFinanceiro.Domain.Contracts.Repositories;
using ControleFinanceiro.Infra.Data.EF;
using System.Collections.Generic;
using System.Linq;

namespace ControleFinanceiro.Infra.Data.Repositories
{
    public class RepositorioBase<TEntity> : IRepositorioBase<TEntity> where TEntity : class
    {
        private readonly EFContext _context;

        public RepositorioBase(EFContext context)
        {
            _context = context;
        }

        public virtual TEntity Alterar(TEntity entity)
        {
            _context.Set<TEntity>().Update(entity);
            return entity;
        }

        public virtual void Excluir(TEntity entity)
        {
            _context.Set<TEntity>().Remove(entity);
        }

        public virtual TEntity Incluir(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);
            return entity;
        }

        public virtual TEntity Obter(int id)
        {
            return _context.Set<TEntity>().Find(id);
        }

        public virtual List<TEntity> Obter()
        {
            return _context.Set<TEntity>().ToList();
        }
    }
}

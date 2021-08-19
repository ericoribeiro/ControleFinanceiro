using ControleFinanceiro.Domain.Contracts.Repositories;
using ControleFinanceiro.Domain.Entities;
using ControleFinanceiro.Infra.Data.EF;
using ControleFinanceiro.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ControleFinanceiro.Infra.Repositories
{
    public class RepositorioReceita : RepositorioBase<Receita>, IRepositorioReceita
    {
        private EFContext _context { get; set; }

        public RepositorioReceita(EFContext context) : base(context) 
        {
            _context = context;
        }

        public List<Receita> ListarReceitaPorData(DateTime data, int idUsuario)
        {
            return _context.Receitas
                           .Where(x => x.Data == data && x.UsuarioID == idUsuario)
                           .ToList();
        }
    }
}

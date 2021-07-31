using ControleFinanceiro.Domain.Contracts.Repositories;
using ControleFinanceiro.Domain.Entities;
using ControleFinanceiro.Infra.Data.EF;
using ControleFinanceiro.Infra.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ControleFinanceiro.Infra.Repositories
{
    public class RepositorioDespesa : RepositorioBase<Despesa>, IRepositorioDespesa
    {
        private EFContext _context { get; set; }

        public RepositorioDespesa(EFContext context) : base(context)
        {
            _context = context;
        }

        public List<Despesa> ListarDespesaPorData(DateTime data, int idUsuario)
        {
            return _context.Despesas
                           .Where(x => x.Data == data && x.UsuarioID == idUsuario)
                           .ToList();
        }
    }
}

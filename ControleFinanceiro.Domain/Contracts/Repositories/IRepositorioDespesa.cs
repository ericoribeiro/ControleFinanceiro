using ControleFinanceiro.Domain.Entities;
using System;
using System.Collections.Generic;

namespace ControleFinanceiro.Domain.Contracts.Repositories
{
    public interface IRepositorioDespesa : IRepositorioBase<Despesa>
    {
        List<Despesa> ListarDespesaPorData(DateTime data, int idUsuario);
    }
}

using ControleFinanceiro.Domain.Entities;
using System;
using System.Collections.Generic;

namespace ControleFinanceiro.Domain.Contracts.Repositories
{
    public interface IRepositorioReceita : IRepositorioBase<Receita>
    {
        List<Receita> ListarReceitaPorData(DateTime data, int idUsuario);
    }
}

using ControleFinanceiro.Domain.Entities;
using System;
using System.Collections.Generic;

namespace ControleFinanceiro.Domain.Contracts.Services
{
    public interface IServicoReceita : IServicoBase<Receita>
    {
        List<Receita> ListarReceitaPorData(DateTime data, int idUsuario);
    }
}

using ControleFinanceiro.Domain.Entities;
using System;
using System.Collections.Generic;

namespace ControleFinanceiro.Domain.Contracts.Services
{
    public interface IServicoDespesa : IServicoBase<Despesa>
    {
        List<Despesa> ListarDespesaPorData(DateTime data, int idUsuario);
    }
}

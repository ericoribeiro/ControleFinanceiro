using ControleFinanceiro.Domain.Contracts.Repositories;
using ControleFinanceiro.Domain.Contracts.Services;
using ControleFinanceiro.Domain.Entities;
using ControleFinanceiro.Infra.Data.EF;
using System;
using System.Collections.Generic;

namespace ControleFinanceiro.Domain.Service.Services
{
    public class ServicoDespesa : ServicoBase<Despesa>, IServicoDespesa
    {
        private readonly IRepositorioDespesa _repositorioDespesa;

        public ServicoDespesa(IRepositorioDespesa repositorioDespesa, EFContext context) : base(repositorioDespesa, context)
        {
            _repositorioDespesa = repositorioDespesa;
        }

        public List<Despesa> ListarDespesaPorData(DateTime data, int idUsuario)
        {
            return _repositorioDespesa.ListarDespesaPorData(data, idUsuario);
        }
    }
}

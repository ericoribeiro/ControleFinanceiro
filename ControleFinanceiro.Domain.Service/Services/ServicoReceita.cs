using ControleFinanceiro.Domain.Contracts.Repositories;
using ControleFinanceiro.Domain.Contracts.Services;
using ControleFinanceiro.Domain.Entities;
using ControleFinanceiro.Infra.Data.EF;
using System;
using System.Collections.Generic;

namespace ControleFinanceiro.Domain.Service.Services
{
    public class ServicoReceita : ServicoBase<Receita>, IServicoReceita
    {
        private readonly IRepositorioReceita _repositorioReceita;

        public ServicoReceita(IRepositorioReceita repositorioReceita, EFContext context) : base(repositorioReceita, context)
        {
            _repositorioReceita = repositorioReceita;
        }

        public List<Receita> ListarReceitaPorData(DateTime data, int idUsuario)
        {
            return _repositorioReceita.ListarReceitaPorData(data, idUsuario);
        }
    }
}

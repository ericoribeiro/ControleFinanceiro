using System.Collections.Generic;

namespace ControleFinanceiro.Domain.Entities
{
    public class Usuario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }

        public List<Despesa> Despesas { get; set; }
        public List<Receita> Receitas { get; set; }
    }
}

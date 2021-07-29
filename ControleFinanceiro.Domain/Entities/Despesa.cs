using System;

namespace ControleFinanceiro.Domain.Entities
{
    public class Despesa
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }

        public int UsuarioID { get; set; }
        public Usuario Usuario { get; set; }
    }
}

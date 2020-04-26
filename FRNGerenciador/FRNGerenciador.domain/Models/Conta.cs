using System;
using System.Collections.Generic;

namespace FRNGerenciador.domain.Models
{
    public class Conta
    {
        public int Id { get; set; }
        public int Parcelas { get; set; }
        public decimal ValorTotal { get; set; }
        public decimal ValorParcela { get; set; }
        public int Ativa { get; set; }
        public int IdDono { get; set; }
        public List<int> IdCartoes { get; set; }
        public DateTime Vencimento { get; set; }
    }
}
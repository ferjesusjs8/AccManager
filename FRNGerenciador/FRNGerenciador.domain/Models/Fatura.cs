using System;
using System.Collections.Generic;

namespace FRNGerenciador.domain.Models
{
    public class Fatura
    {
        public int Id { get; set; }
        public string MesAno { get; set; }
        public List<int> IdContas { get; set; }
        public int IdCartao { get; set; }
        public int IdDono { get; set; }
        public int Ativa { get; set; }
        public decimal Valor { get; set; }
        public DateTime Vencimento { get; set; }
    }
}
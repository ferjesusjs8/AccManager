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
        public Owner Dono { get; set; }
        public List<Cartao> Cartoes { get; set; }
        public DateTime Vencimento { get; set; }
    }
}
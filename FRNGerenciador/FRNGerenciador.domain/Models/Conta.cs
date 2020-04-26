using System;
using System.Collections.Generic;

namespace FRNGerenciador.domain.Models
{
    public class Conta
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Parcela> Parcelas { get; set; }
        public decimal ValorTotal { get; set; }
        public bool Ativa { get; set; }
        public Owner Dono { get; set; }
        public List<Cartao> Cartoes { get; set; }
        public DateTime Vencimento { get; set; }
        public DateTime Criacao { get; set; }
        public DateTime Atualizacao { get; set; }
    }
}
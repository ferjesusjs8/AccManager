using System;
using System.Collections.Generic;

namespace FRNGerenciador.domain.Models
{
    public class Cartao
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Owner Dono { get; set; }
        public string FinalCartao { get; set; }
        public decimal Limite { get; set; }
        public List<Fatura> Faturas { get; set; }
        public Bandeira Bandeira { get; set; }
        public bool Ativo { get; set; }
        public DateTime Criacao { get; set; }
        public DateTime Atualizacao { get; set; }
    }
}
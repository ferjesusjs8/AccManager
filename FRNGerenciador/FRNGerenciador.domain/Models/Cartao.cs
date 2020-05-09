using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FRNGerenciador.domain.Models
{
    public class Cartao
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Pessoa Dono { get; set; }
        public string FinalCartao { get; set; }
        public decimal Limite { get; set; }
        public List<Fatura> Faturas { get; set; }
        public Bandeira Bandeira { get; set; }
        public bool Ativo { get; set; }
        public DateTime Criacao { get; set; }
        public DateTime Atualizacao { get; set; }
    }
}
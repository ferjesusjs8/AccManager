using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FRNGerenciador.domain.Models
{
    public class Fatura
    {
        [Key]
        public int Id { get; set; }
        public string MesAno { get; set; }
        public List<Conta> Contas { get; set; }
        public Cartao Cartao { get; set; }
        public Pessoa Dono { get; set; }
        public double Valor { get; set; }
        public bool Ativo { get; set; }
        public List<Parcela> Parcelamento { get; set; }
        public DateTime Vencimento { get; set; }
        public DateTime Criacao { get; set; }
        public DateTime Atualizacao { get; set; }
    }
}
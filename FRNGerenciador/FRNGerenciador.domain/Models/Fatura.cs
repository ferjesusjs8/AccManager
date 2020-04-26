using System;
using System.Collections.Generic;

namespace FRNGerenciador.domain.Models
{
    public class Fatura
    {
        public int Id { get; set; }
        public string MesAno { get; set; }
        public List<Conta> Contas { get; set; }
        public Cartao Cartao { get; set; }
        public Owner Dono { get; set; }
        public int Ativa { get; set; }
        public double Valor { get; set; }
        public List<Parcela> Parcelamento { get; set; }
        public DateTime Vencimento { get; set; }
        public DateTime Criacao { get; set; }
        public DateTime Atualizacao { get; set; }
    }
}
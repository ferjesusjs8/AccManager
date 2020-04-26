using System;

namespace FRNGerenciador.domain.Models
{
    public class Parcela
    {
        public int Id { get; set; }
        public decimal Valor { get; set; }
        public DateTime Criacao { get; set; }
        public DateTime Atualizacao { get; set; }
    }
}
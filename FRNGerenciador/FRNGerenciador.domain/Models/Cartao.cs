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
        public string Bandeira { get; set; }
        public int QuantidadeParcelas { get; set; }
        public int Ativo { get; set; }
        public List<Conta> Contas { get; set; }
    }
}
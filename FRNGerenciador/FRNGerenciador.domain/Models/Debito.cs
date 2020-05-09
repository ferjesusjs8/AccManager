using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FRNGerenciador.domain.Models
{
    public class Debito
    {
        [Key]
        public int Id { get; set; }
        public string MesAno { get; set; }
        public Salario Pagamento { get; set; }
        public List<Conta> Contas { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; }
        public DateTime Criacao { get; set; }
        public DateTime Atualizacao { get; set; }
    }
}

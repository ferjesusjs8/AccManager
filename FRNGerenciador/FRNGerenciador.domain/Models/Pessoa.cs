using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FRNGerenciador.domain.Models
{
    public class Pessoa
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Cartao> Cartoes { get; set; }
        public List<Saldo> Saldos { get; set; }
        public List<Debito> Debitos { get; set; }
        public List<Pessoa> Dependentes { get; set; }
        public Cargo Cargo { get; set; }
        public bool Ativo { get; set; }
        public DateTime Criacao { get; set; }
        public DateTime Atualizacao { get; set; }
    }
}
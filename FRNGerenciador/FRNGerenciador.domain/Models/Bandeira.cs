using System;
using System.ComponentModel.DataAnnotations;

namespace FRNGerenciador.domain.Models
{
    public class Bandeira
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
        public DateTime Criacao { get; set; }
        public DateTime Atualizacao { get; set; }
    }
}
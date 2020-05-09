using System;
using System.ComponentModel.DataAnnotations;

namespace FRNGerenciador.domain.Models
{
    public class Cargo
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public Salario Salario { get; set; }
        public RegimeContratacao RegimeContratacao { get; set; }
        public Hierarquia Hierarquia { get; set; }
        public bool Ativo { get; set; }
        public DateTime Insercao { get; set; }
        public DateTime Atualizacao { get; set; }
    }
}
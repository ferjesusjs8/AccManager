using System;
using System.ComponentModel.DataAnnotations;

namespace FRNGerenciador.domain.Models
{
    public class Salario
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public TipoSalario TipoSalario { get; set; }
        public float Valor { get; set; }
        public bool Ativo { get; set; }
        public DateTime Insercao { get; set; }
        public DateTime Atualizacao { get; set; }
    }
}
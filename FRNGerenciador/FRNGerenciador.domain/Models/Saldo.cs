using FRNGerenciador.domain.Enums;
using System;

namespace FRNGerenciador.domain.Models
{
    public class Saldo
    {
        public int Id { get; set; }
        public string MesAno { get; set; }
        public ESalario TipoSalario { get; set; }
        public Owner Dono { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; }
        public DateTime Criacao { get; set; }
        public DateTime Atualizacao { get; set; }
    }
}

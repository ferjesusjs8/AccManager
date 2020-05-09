using System;
using System.ComponentModel.DataAnnotations;

namespace FRNGerenciador.domain.Models
{
    public class Ferias
    {
        [Key]
        public int Id { get; set; }
        public double Pagamento
        {
            get
            {
                return this.Pagamento;
            }
            set
            {
                this.Pagamento = Math.Round(value, 2);
            }
        }
        public bool Ativo { get; set; }
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public DateTime Criacao { get; set; }
        public DateTime Atualizacao { get; set; }
    }
}
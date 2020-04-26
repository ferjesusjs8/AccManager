using System;

namespace FRNGerenciador.domain.Models
{
    public class Ferias
    {
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
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public DateTime Criacao { get; set; }
        public DateTime Atualizacao { get; set; }
    }
}
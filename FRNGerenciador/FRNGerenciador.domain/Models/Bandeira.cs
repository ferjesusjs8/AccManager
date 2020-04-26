using System;

namespace FRNGerenciador.domain.Models
{
    public class Bandeira
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Ativo { get; set; }
        public DateTime Criacao { get; set; }
        public DateTime Atualizacao { get; set; }
    }
}
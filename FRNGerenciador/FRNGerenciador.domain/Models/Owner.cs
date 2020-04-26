using System.Collections.Generic;

namespace FRNGerenciador.domain.Models
{
    public class Owner
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public List<Cartao> Cartoes { get; set; }
    }
}
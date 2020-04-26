using System;
using System.Collections.Generic;
using System.Text;

namespace FRNGerenciador.domain.Models
{
    public class Debito
    {
        public int Id { get; set; }
        public string MesAno { get; set; }
        public List<int> IdDono { get; set; }
    }
}

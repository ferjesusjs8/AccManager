﻿using System;
using System.ComponentModel.DataAnnotations;

namespace FRNGerenciador.domain.Models
{
    public class Saldo
    {
        [Key]
        public int Id { get; set; }
        public string MesAno { get; set; }
        public Salario TipoSalario { get; set; }
        public Pessoa Dono { get; set; }
        public decimal Valor { get; set; }
        public bool Ativo { get; set; }
        public DateTime Criacao { get; set; }
        public DateTime Atualizacao { get; set; }
    }
}

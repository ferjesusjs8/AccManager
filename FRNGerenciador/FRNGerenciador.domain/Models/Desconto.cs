﻿using System;
using System.ComponentModel.DataAnnotations;

namespace FRNGerenciador.domain.Models
{
    public class Desconto
    {
        [Key]
        public int Id { get; set; }
        public string Descricao { get; set; }
        public double Percentual { get; set; }
        public bool Ativo { get; set; }
        public DateTime Criacao { get; set; }
        public DateTime Atualizacao { get; set; }
    }
}